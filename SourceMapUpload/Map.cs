using Microsoft.VisualBasic.FileIO;
using Renci.SshNet;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Text;

namespace SourceMapUpload;

// todo: pakrat
public class Map {
    private readonly CompileConfig _config;

    private string _mapPath;

    public Map(CompileConfig config) {
        _config = config;
        _mapPath = Path.ChangeExtension(_config.VmfPath, "bsp");
    }

    public bool Compile() {
        List<string> commands = [];
        string compileToolsPath = Directory.GetParent(_config.GamePath)! + @"\bin\x64";
        Console.WriteLine(compileToolsPath);

        commands.Add($"""
                      cd "{compileToolsPath}"
                      """);

        if (_config.BspSetting != Constants.BspNo) {
            StringBuilder sb = new();

            sb.Append($"""
                       .\vbsp.exe -game "{_config.GamePath}"
                       """);

            if (_config.BspSetting == Constants.BspOnlyEntities) {
                sb.Append(" -onlyents");
            }

            sb.Append($"""
                        "{_config.VmfPath}"
                       """);

            commands.Add(sb.ToString());
        }

        if (_config.VisSetting != Constants.VisNo) {
            StringBuilder sb = new();

            sb.Append($"""
                       .\vvis.exe -game "{_config.GamePath}"
                       """);

            if (_config.VisSetting == Constants.VisFast) {
                sb.Append(" -fast");
            }

            sb.Append($"""
                        "{_mapPath}"
                       """);

            commands.Add(sb.ToString());
        }

        if (_config.RadSetting != Constants.RadNo) {
            StringBuilder sb = new();

            sb.Append($"""
                       .\vrad.exe -game "{_config.GamePath}"
                       """);

            if (_config.RadSetting == Constants.RadFast) {
                sb.Append(" -fast");
            }

            if (_config.RadHdr) {
                sb.Append(" -hdr");
            }

            sb.Append($"""
                        "{_mapPath}"
                       """);

            commands.Add(sb.ToString());
        }

        if (_config.AddTimestamp) {
            string mapName = Path.GetFileNameWithoutExtension(_mapPath);
            string newMapName = $"dev_{mapName}_{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";
            string? parentDirectory = Path.GetDirectoryName(_mapPath);
            string oldMapPath = _mapPath;
            _mapPath = Path.Combine(parentDirectory ?? "", newMapName) + Path.GetExtension(oldMapPath);

            commands.Add($"""
                          cp "{oldMapPath}" "{_mapPath}"
                          """);
        }

        if (_config.PackAssets) {
            // pakrat -auto <basedir> <filename>
            commands.Add($"""
                          cd "{Path.GetDirectoryName(_config.PakratPath)}"
                          """);

            commands.Add($"""
                          & ".\{Path.GetFileName(_config.PakratPath)}" -auto "{_config.GamePath}" "{_mapPath}"
                          """);
        }

        if (_config.CopyOnFinish) {
            StringBuilder sb = new();

            sb.Append("cp")
                .Append($"""
                          "{_mapPath}"
                         """);

            string mapPath = _config.GamePath + @"\maps";

            sb.Append($"""
                        "{mapPath}"
                       """);

            commands.Add(sb.ToString());
        }

        using PowerShell ps = PowerShell.Create();

        Console.WriteLine($"\n===== Start compiling：{_mapPath} =====");

        for (int i = 0; i < commands.Count; i++) {
            string command = commands[i];
            ps.Commands.Clear();

            Console.WriteLine($"\n===== Running ({i + 1}/{commands.Count})：{command} =====");

            ps.AddScript(command);

            Collection<PSObject>? results = ps.Invoke();

            if (ps.HadErrors) {
                foreach (ErrorRecord? error in ps.Streams.Error) {
                    Console.Error.WriteLine($"Error：{error}");
                }

                return false;
            }

            foreach (PSObject result in results) {
                Console.WriteLine(result.ToString());
            }
        }

        Console.WriteLine($"\n===== Compilation finished：{_mapPath} =====");

        return true;
    }

    public bool Upload() {
        RemoteConfig remoteConfig = _config.RemoteConfig;
        string remoteMapPath = remoteConfig.RemotePath + "/" + Path.GetFileName(_mapPath);

        if (!File.Exists(_mapPath)) {
            Console.Error.WriteLine($"Error: Map file {_mapPath} does not exist.");

            return false;
        }

        ConnectionInfo connectionInfo = new(
            remoteConfig.Host,
            remoteConfig.Port,
            remoteConfig.User,
            new PrivateKeyAuthenticationMethod(remoteConfig.User, new PrivateKeyFile(remoteConfig.LoginKeyPath))
        );

        using ScpClient scpClient = new(connectionInfo);

        Console.WriteLine($"\n===== Start uploading: {_mapPath} → {remoteMapPath} =====");

        try {
            scpClient.Connect();

            using (FileStream fileStream = new(_mapPath, FileMode.Open, FileAccess.Read)) {
                scpClient.Upload(fileStream, remoteMapPath);
            }

            Console.WriteLine($"\n===== Map uploaded: {_mapPath} → {remoteMapPath} =====");

            return true;
        } catch (Exception ex) {
            Console.WriteLine($"Error: Failed to upload the map to the remote server! Reason: {ex.Message}");

            return false;
        } finally {
            if (scpClient.IsConnected) {
                scpClient.Disconnect();
            }
        }
    }
}
