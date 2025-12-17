namespace SourceMapUpload;

public class CompileConfig {
    public string VmfPath { get; set; } = null!;
    public string GamePath { get; set; } = null!;
    public int BspSetting { get; set; }
    public int VisSetting { get; set; }
    public int RadSetting { get; set; }
    public bool RadHdr { get; set; }
    public bool PackAssets { get; set; }
    public string PakratPath { get; set; } = null!;
    public bool AddTimestamp { get; set; }
    public bool CopyOnFinish { get; set; }
    public bool EnableRemote { get; set; }
    public RemoteConfig RemoteConfig { get; set; } = null!;
}
