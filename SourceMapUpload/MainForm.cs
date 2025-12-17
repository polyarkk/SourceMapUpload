using Tomlyn;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace SourceMapUpload;

public partial class MainForm : Form {
    public MainForm() {
        InitializeComponent();
        OnCheckBoxUploadChanged(null!, null!);
        OnCheckBoxPackAssetsChanged(null!, null!);
        LoadSettings();
    }

    private void OnButtonCompileClick(object sender, EventArgs e) {
        buttonCompile.Enabled = false;

        CompileConfig? config = MakeConfig();

        if (config == null) {
            return;
        }

        if (config is {
            BspSetting: Constants.BspNo,
            VisSetting: Constants.VisNo,
            RadSetting: Constants.RadNo,
            EnableRemote: false,
        }) {
            MessageBox.Show("Nothing to do.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            buttonCompile.Enabled = true;

            return;
        }

        SaveSettings(config);

        Map map = new(config);

        if (config is not {
            BspSetting: Constants.BspNo,
            VisSetting: Constants.VisNo,
            RadSetting: Constants.RadNo,
        }) {
            bool compileSuccess = map.Compile();

            if (!compileSuccess) {
                MessageBox.Show("Error occured upon compiling the map! Check console output.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                buttonCompile.Enabled = true;

                return;
            }
        }

        if (!config.EnableRemote) {
            MessageBox.Show("Map compiled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            buttonCompile.Enabled = true;

            return;
        }

        bool uploadSuccess = map.Upload();

        if (!uploadSuccess) {
            MessageBox.Show("Error occured upon uploading the map! Check console output.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        } else {
            MessageBox.Show("Map compiled/uploaded successfully!", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        buttonCompile.Enabled = true;
    }

    private void OnCheckBoxUploadChanged(object sender, EventArgs e) {
        bool @checked = checkBoxUpload.Checked;

        textBoxHost.Enabled = @checked;
        textBoxPort.Enabled = @checked;
        textBoxUser.Enabled = @checked;
        buttonBrowseLoginKey.Enabled = @checked;
        textBoxRemotePath.Enabled = @checked;
    }

    private void OnTextBoxPortKeyPress(object sender, KeyPressEventArgs e) {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
            e.Handled = true;
        }
    }

    private CompileConfig? MakeConfig(bool suppressErrors = false) {
        if (string.IsNullOrWhiteSpace(textBoxGamePath.Text) && !suppressErrors) {
            MessageBox.Show("Please specify a game path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return null;
        }

        if (string.IsNullOrWhiteSpace(textBoxVmfPath.Text) && !suppressErrors) {
            MessageBox.Show("Please specify a path to your VMF file.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return null;
        }

        if (checkBoxPackAssets.Checked && string.IsNullOrWhiteSpace(textBoxPakratPath.Text) && !suppressErrors) {
            MessageBox.Show("Please specify a path to Pakrat.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return null;
        }

        int bspSetting = -1;

        if (radioButtonBspNo.Checked) {
            bspSetting = Constants.BspNo;
        } else if (radioButtonBspNormal.Checked) {
            bspSetting = Constants.BspNormal;
        } else if (radioButtonBspOnlyEntities.Checked) {
            bspSetting = Constants.BspOnlyEntities;
        }

        int visSetting = -1;

        if (radioButtonVisNo.Checked) {
            visSetting = Constants.VisNo;
        } else if (radioButtonVisNormal.Checked) {
            visSetting = Constants.VisNormal;
        } else if (radioButtonVisFast.Checked) {
            visSetting = Constants.VisFast;
        }

        int radSetting = -1;

        if (radioButtonRadNo.Checked) {
            radSetting = Constants.RadNo;
        } else if (radioButtonRadNormal.Checked) {
            radSetting = Constants.RadNormal;
        } else if (radioButtonRadFast.Checked) {
            radSetting = Constants.RadFast;
        }

        CompileConfig config = new() {
            VmfPath = textBoxVmfPath.Text,
            GamePath = textBoxGamePath.Text,
            BspSetting = bspSetting,
            VisSetting = visSetting,
            RadSetting = radSetting,
            RadHdr = checkBoxRadHdr.Checked,
            PackAssets = checkBoxPackAssets.Checked,
            PakratPath = textBoxPakratPath.Text,
            AddTimestamp = checkBoxAddTimestamp.Checked,
            CopyOnFinish = checkBoxCopyOnFinish.Checked,
        };

        if (checkBoxUpload.Checked) {
            config.EnableRemote = true;

            if (string.IsNullOrWhiteSpace(textBoxHost.Text) && !suppressErrors) {
                MessageBox.Show("Please specify your remote host.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }

            if (string.IsNullOrWhiteSpace(textBoxUser.Text) && !suppressErrors) {
                MessageBox.Show("Please specify your remote user.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }

            if (string.IsNullOrWhiteSpace(textBoxLoginKeyPath.Text) && !suppressErrors) {
                MessageBox.Show("Please specify a path to your login key.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }

            if (string.IsNullOrWhiteSpace(textBoxRemotePath.Text) && !suppressErrors) {
                MessageBox.Show("Please specify a path to your remote BSP directory.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }

            if (!int.TryParse(textBoxPort.Text, out int port)) {
                port = 22;
            }

            config.RemoteConfig = new RemoteConfig {
                Host = textBoxHost.Text,
                Port = port,
                User = textBoxUser.Text,
                LoginKeyPath = textBoxLoginKeyPath.Text,
                RemotePath = textBoxRemotePath.Text,
            };
        }

        return config;
    }

    private void LoadSettings() {
        try {
            string toml = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.toml"));

            CompileConfig config = Toml.ToModel<CompileConfig>(toml);

            textBoxVmfPath.Text = config.VmfPath;
            textBoxGamePath.Text = config.GamePath;

            switch (config.BspSetting) {
            case Constants.BspNo:
                radioButtonBspNo.Checked = true;
                break;
            case Constants.BspNormal:
                radioButtonBspNormal.Checked = true;
                break;
            case Constants.BspOnlyEntities:
                radioButtonBspOnlyEntities.Checked = true;
                break;
            }

            switch (config.VisSetting) {
            case Constants.VisNo:
                radioButtonVisNo.Checked = true;
                break;
            case Constants.VisNormal:
                radioButtonVisNormal.Checked = true;
                break;
            case Constants.VisFast:
                radioButtonVisFast.Checked = true;
                break;
            }

            switch (config.RadSetting) {
            case Constants.RadNo:
                radioButtonRadNo.Checked = true;
                break;
            case Constants.RadNormal:
                radioButtonRadNormal.Checked = true;
                break;
            case Constants.RadFast:
                radioButtonRadFast.Checked = true;
                break;
            }

            checkBoxRadHdr.Checked = config.RadHdr;
            checkBoxPackAssets.Checked = config.PackAssets;
            textBoxPakratPath.Text = config.PakratPath;
            checkBoxAddTimestamp.Checked = config.AddTimestamp;
            checkBoxCopyOnFinish.Checked = config.CopyOnFinish;

            if (config.EnableRemote) {
                checkBoxUpload.Checked = true;
                textBoxHost.Text = config.RemoteConfig.Host;
                textBoxPort.Text = config.RemoteConfig.Port.ToString();
                textBoxUser.Text = config.RemoteConfig.User;
                textBoxLoginKeyPath.Text = config.RemoteConfig.LoginKeyPath;
                textBoxRemotePath.Text = config.RemoteConfig.RemotePath;
            } else {
                checkBoxUpload.Checked = false;
            }
        } catch {
            // do nothing
        }
    }

    private static void SaveSettings(CompileConfig config) {
        string toml = Toml.FromModel(config);
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.toml");

        File.Delete(path);
        File.WriteAllText(path, toml);
    }

    private void OnMainFormClosing(object sender, FormClosingEventArgs e) {
        CompileConfig? config = MakeConfig(true);

        if (config != null) {
            SaveSettings(config);
        }
    }

    private static DialogResult BrowseFile(out string? path, string filter = "All Files|*.*") {
        OpenFileDialog dialog = new();

        dialog.Filter = filter;

        DialogResult result = dialog.ShowDialog();

        path = result == DialogResult.OK ? dialog.FileName : null;

        return result;
    }

    private void OnButtonBrowseVmfClick(object sender, EventArgs e) {
        if (BrowseFile(out string? path, "Valve Map Files|*.vmf") == DialogResult.OK) {
            textBoxVmfPath.Text = path;
        }
    }

    private void OnButtonBrowseGameClick(object sender, EventArgs e) {
        FolderBrowserDialog dialog = new();

        if (dialog.ShowDialog() == DialogResult.OK) {
            textBoxGamePath.Text = dialog.SelectedPath;
        }
    }

    private void OnButtonBrowseLoginKeyClick(object sender, EventArgs e) {
        if (BrowseFile(out string? path) == DialogResult.OK) {
            textBoxLoginKeyPath.Text = path;
        }
    }

    private void OnButtonBrowsePakratClick(object sender, EventArgs e) {
        if (BrowseFile(out string? path, "Pakrat Executable|*.bat") == DialogResult.OK) {
            textBoxPakratPath.Text = path;
        }
    }

    private void OnCheckBoxPackAssetsChanged(object sender, EventArgs e) {
        bool @checked = checkBoxPackAssets.Checked;

        buttonBrowsePakrat.Enabled = @checked;
    }
}
