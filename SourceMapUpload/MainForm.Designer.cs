namespace SourceMapUpload;

partial class MainForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

#region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        groupBoxBsp = new System.Windows.Forms.GroupBox();
        radioButtonBspOnlyEntities = new System.Windows.Forms.RadioButton();
        radioButtonBspNormal = new System.Windows.Forms.RadioButton();
        radioButtonBspNo = new System.Windows.Forms.RadioButton();
        groupBoxVis = new System.Windows.Forms.GroupBox();
        radioButtonVisFast = new System.Windows.Forms.RadioButton();
        radioButtonVisNormal = new System.Windows.Forms.RadioButton();
        radioButtonVisNo = new System.Windows.Forms.RadioButton();
        groupBoxRad = new System.Windows.Forms.GroupBox();
        checkBoxRadHdr = new System.Windows.Forms.CheckBox();
        radioButtonRadFast = new System.Windows.Forms.RadioButton();
        radioButtonRadNormal = new System.Windows.Forms.RadioButton();
        radioButtonRadNo = new System.Windows.Forms.RadioButton();
        label1 = new System.Windows.Forms.Label();
        textBoxHost = new System.Windows.Forms.TextBox();
        textBoxLoginKeyPath = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        buttonBrowseLoginKey = new System.Windows.Forms.Button();
        textBoxRemotePath = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        buttonBrowseVmf = new System.Windows.Forms.Button();
        textBoxVmfPath = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        buttonCompile = new System.Windows.Forms.Button();
        buttonBrowseGame = new System.Windows.Forms.Button();
        textBoxGamePath = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        checkBoxUpload = new System.Windows.Forms.CheckBox();
        textBoxUser = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        textBoxPort = new System.Windows.Forms.TextBox();
        checkBoxCopyOnFinish = new System.Windows.Forms.CheckBox();
        checkBoxPackAssets = new System.Windows.Forms.CheckBox();
        buttonBrowsePakrat = new System.Windows.Forms.Button();
        textBoxPakratPath = new System.Windows.Forms.TextBox();
        label8 = new System.Windows.Forms.Label();
        checkBoxAddTimestamp = new System.Windows.Forms.CheckBox();
        groupBoxBsp.SuspendLayout();
        groupBoxVis.SuspendLayout();
        groupBoxRad.SuspendLayout();
        SuspendLayout();
        // 
        // groupBoxBsp
        // 
        groupBoxBsp.Controls.Add(radioButtonBspOnlyEntities);
        groupBoxBsp.Controls.Add(radioButtonBspNormal);
        groupBoxBsp.Controls.Add(radioButtonBspNo);
        groupBoxBsp.Location = new System.Drawing.Point(12, 67);
        groupBoxBsp.Name = "groupBoxBsp";
        groupBoxBsp.Size = new System.Drawing.Size(121, 105);
        groupBoxBsp.TabIndex = 0;
        groupBoxBsp.TabStop = false;
        groupBoxBsp.Text = "Run BSP";
        // 
        // radioButtonBspOnlyEntities
        // 
        radioButtonBspOnlyEntities.Location = new System.Drawing.Point(6, 78);
        radioButtonBspOnlyEntities.Name = "radioButtonBspOnlyEntities";
        radioButtonBspOnlyEntities.Size = new System.Drawing.Size(109, 21);
        radioButtonBspOnlyEntities.TabIndex = 2;
        radioButtonBspOnlyEntities.Text = "Only Entities";
        radioButtonBspOnlyEntities.UseVisualStyleBackColor = true;
        // 
        // radioButtonBspNormal
        // 
        radioButtonBspNormal.Checked = true;
        radioButtonBspNormal.Location = new System.Drawing.Point(6, 50);
        radioButtonBspNormal.Name = "radioButtonBspNormal";
        radioButtonBspNormal.Size = new System.Drawing.Size(109, 21);
        radioButtonBspNormal.TabIndex = 1;
        radioButtonBspNormal.TabStop = true;
        radioButtonBspNormal.Text = "Normal";
        radioButtonBspNormal.UseVisualStyleBackColor = true;
        // 
        // radioButtonBspNo
        // 
        radioButtonBspNo.Location = new System.Drawing.Point(6, 22);
        radioButtonBspNo.Name = "radioButtonBspNo";
        radioButtonBspNo.Size = new System.Drawing.Size(109, 21);
        radioButtonBspNo.TabIndex = 0;
        radioButtonBspNo.Text = "No";
        radioButtonBspNo.UseVisualStyleBackColor = true;
        // 
        // groupBoxVis
        // 
        groupBoxVis.Controls.Add(radioButtonVisFast);
        groupBoxVis.Controls.Add(radioButtonVisNormal);
        groupBoxVis.Controls.Add(radioButtonVisNo);
        groupBoxVis.Location = new System.Drawing.Point(139, 67);
        groupBoxVis.Name = "groupBoxVis";
        groupBoxVis.Size = new System.Drawing.Size(121, 105);
        groupBoxVis.TabIndex = 3;
        groupBoxVis.TabStop = false;
        groupBoxVis.Text = "Run VIS";
        // 
        // radioButtonVisFast
        // 
        radioButtonVisFast.Location = new System.Drawing.Point(6, 78);
        radioButtonVisFast.Name = "radioButtonVisFast";
        radioButtonVisFast.Size = new System.Drawing.Size(109, 21);
        radioButtonVisFast.TabIndex = 2;
        radioButtonVisFast.Text = "Fast";
        radioButtonVisFast.UseVisualStyleBackColor = true;
        // 
        // radioButtonVisNormal
        // 
        radioButtonVisNormal.Checked = true;
        radioButtonVisNormal.Location = new System.Drawing.Point(6, 50);
        radioButtonVisNormal.Name = "radioButtonVisNormal";
        radioButtonVisNormal.Size = new System.Drawing.Size(109, 21);
        radioButtonVisNormal.TabIndex = 1;
        radioButtonVisNormal.TabStop = true;
        radioButtonVisNormal.Text = "Normal";
        radioButtonVisNormal.UseVisualStyleBackColor = true;
        // 
        // radioButtonVisNo
        // 
        radioButtonVisNo.Location = new System.Drawing.Point(6, 22);
        radioButtonVisNo.Name = "radioButtonVisNo";
        radioButtonVisNo.Size = new System.Drawing.Size(109, 21);
        radioButtonVisNo.TabIndex = 0;
        radioButtonVisNo.Text = "No";
        radioButtonVisNo.UseVisualStyleBackColor = true;
        // 
        // groupBoxRad
        // 
        groupBoxRad.Controls.Add(checkBoxRadHdr);
        groupBoxRad.Controls.Add(radioButtonRadFast);
        groupBoxRad.Controls.Add(radioButtonRadNormal);
        groupBoxRad.Controls.Add(radioButtonRadNo);
        groupBoxRad.Location = new System.Drawing.Point(266, 67);
        groupBoxRad.Name = "groupBoxRad";
        groupBoxRad.Size = new System.Drawing.Size(121, 105);
        groupBoxRad.TabIndex = 4;
        groupBoxRad.TabStop = false;
        groupBoxRad.Text = "Run RAD";
        // 
        // checkBoxRadHdr
        // 
        checkBoxRadHdr.Location = new System.Drawing.Point(59, 22);
        checkBoxRadHdr.Name = "checkBoxRadHdr";
        checkBoxRadHdr.Size = new System.Drawing.Size(56, 21);
        checkBoxRadHdr.TabIndex = 5;
        checkBoxRadHdr.Text = "HDR";
        checkBoxRadHdr.UseVisualStyleBackColor = true;
        // 
        // radioButtonRadFast
        // 
        radioButtonRadFast.Location = new System.Drawing.Point(6, 78);
        radioButtonRadFast.Name = "radioButtonRadFast";
        radioButtonRadFast.Size = new System.Drawing.Size(109, 21);
        radioButtonRadFast.TabIndex = 2;
        radioButtonRadFast.Text = "Fast";
        radioButtonRadFast.UseVisualStyleBackColor = true;
        // 
        // radioButtonRadNormal
        // 
        radioButtonRadNormal.Checked = true;
        radioButtonRadNormal.Location = new System.Drawing.Point(6, 50);
        radioButtonRadNormal.Name = "radioButtonRadNormal";
        radioButtonRadNormal.Size = new System.Drawing.Size(109, 21);
        radioButtonRadNormal.TabIndex = 1;
        radioButtonRadNormal.TabStop = true;
        radioButtonRadNormal.Text = "Normal";
        radioButtonRadNormal.UseVisualStyleBackColor = true;
        // 
        // radioButtonRadNo
        // 
        radioButtonRadNo.Location = new System.Drawing.Point(6, 22);
        radioButtonRadNo.Name = "radioButtonRadNo";
        radioButtonRadNo.Size = new System.Drawing.Size(47, 21);
        radioButtonRadNo.TabIndex = 0;
        radioButtonRadNo.Text = "No";
        radioButtonRadNo.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(12, 321);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(86, 23);
        label1.TabIndex = 6;
        label1.Text = "Host";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // textBoxHost
        // 
        textBoxHost.Location = new System.Drawing.Point(104, 321);
        textBoxHost.Name = "textBoxHost";
        textBoxHost.Size = new System.Drawing.Size(158, 23);
        textBoxHost.TabIndex = 7;
        // 
        // textBoxLoginKeyPath
        // 
        textBoxLoginKeyPath.Enabled = false;
        textBoxLoginKeyPath.Location = new System.Drawing.Point(104, 379);
        textBoxLoginKeyPath.Name = "textBoxLoginKeyPath";
        textBoxLoginKeyPath.Size = new System.Drawing.Size(200, 23);
        textBoxLoginKeyPath.TabIndex = 9;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(12, 379);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(86, 23);
        label2.TabIndex = 8;
        label2.Text = "Login Key";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // buttonBrowseLoginKey
        // 
        buttonBrowseLoginKey.Location = new System.Drawing.Point(310, 379);
        buttonBrowseLoginKey.Name = "buttonBrowseLoginKey";
        buttonBrowseLoginKey.Size = new System.Drawing.Size(77, 23);
        buttonBrowseLoginKey.TabIndex = 10;
        buttonBrowseLoginKey.Text = "Browse";
        buttonBrowseLoginKey.UseVisualStyleBackColor = true;
        buttonBrowseLoginKey.Click += OnButtonBrowseLoginKeyClick;
        // 
        // textBoxRemotePath
        // 
        textBoxRemotePath.Location = new System.Drawing.Point(104, 408);
        textBoxRemotePath.Name = "textBoxRemotePath";
        textBoxRemotePath.Size = new System.Drawing.Size(283, 23);
        textBoxRemotePath.TabIndex = 12;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(12, 408);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(86, 23);
        label3.TabIndex = 11;
        label3.Text = "Remote Path";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // buttonBrowseVmf
        // 
        buttonBrowseVmf.Location = new System.Drawing.Point(310, 9);
        buttonBrowseVmf.Name = "buttonBrowseVmf";
        buttonBrowseVmf.Size = new System.Drawing.Size(77, 23);
        buttonBrowseVmf.TabIndex = 15;
        buttonBrowseVmf.Text = "Browse";
        buttonBrowseVmf.UseVisualStyleBackColor = true;
        buttonBrowseVmf.Click += OnButtonBrowseVmfClick;
        // 
        // textBoxVmfPath
        // 
        textBoxVmfPath.Enabled = false;
        textBoxVmfPath.Location = new System.Drawing.Point(104, 9);
        textBoxVmfPath.Name = "textBoxVmfPath";
        textBoxVmfPath.Size = new System.Drawing.Size(200, 23);
        textBoxVmfPath.TabIndex = 14;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(12, 9);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(86, 23);
        label4.TabIndex = 13;
        label4.Text = "VMF File";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // buttonCompile
        // 
        buttonCompile.Location = new System.Drawing.Point(266, 441);
        buttonCompile.Name = "buttonCompile";
        buttonCompile.Size = new System.Drawing.Size(121, 31);
        buttonCompile.TabIndex = 16;
        buttonCompile.Text = "Compile!";
        buttonCompile.UseVisualStyleBackColor = true;
        buttonCompile.Click += OnButtonCompileClick;
        // 
        // buttonBrowseGame
        // 
        buttonBrowseGame.Location = new System.Drawing.Point(310, 38);
        buttonBrowseGame.Name = "buttonBrowseGame";
        buttonBrowseGame.Size = new System.Drawing.Size(77, 23);
        buttonBrowseGame.TabIndex = 19;
        buttonBrowseGame.Text = "Browse";
        buttonBrowseGame.UseVisualStyleBackColor = true;
        buttonBrowseGame.Click += OnButtonBrowseGameClick;
        // 
        // textBoxGamePath
        // 
        textBoxGamePath.Enabled = false;
        textBoxGamePath.Location = new System.Drawing.Point(104, 38);
        textBoxGamePath.Name = "textBoxGamePath";
        textBoxGamePath.Size = new System.Drawing.Size(200, 23);
        textBoxGamePath.TabIndex = 18;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(12, 38);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(86, 23);
        label5.TabIndex = 17;
        label5.Text = "Game Path";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // checkBoxUpload
        // 
        checkBoxUpload.Checked = true;
        checkBoxUpload.CheckState = System.Windows.Forms.CheckState.Checked;
        checkBoxUpload.Location = new System.Drawing.Point(12, 294);
        checkBoxUpload.Name = "checkBoxUpload";
        checkBoxUpload.Size = new System.Drawing.Size(354, 24);
        checkBoxUpload.TabIndex = 20;
        checkBoxUpload.Text = "Upload to remote server";
        checkBoxUpload.UseVisualStyleBackColor = true;
        checkBoxUpload.CheckedChanged += OnCheckBoxUploadChanged;
        // 
        // textBoxUser
        // 
        textBoxUser.Location = new System.Drawing.Point(104, 350);
        textBoxUser.Name = "textBoxUser";
        textBoxUser.Size = new System.Drawing.Size(283, 23);
        textBoxUser.TabIndex = 22;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(12, 350);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(86, 23);
        label6.TabIndex = 21;
        label6.Text = "User";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(268, 321);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(36, 23);
        label7.TabIndex = 23;
        label7.Text = "Port";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // textBoxPort
        // 
        textBoxPort.Location = new System.Drawing.Point(310, 321);
        textBoxPort.Name = "textBoxPort";
        textBoxPort.PlaceholderText = "22";
        textBoxPort.Size = new System.Drawing.Size(77, 23);
        textBoxPort.TabIndex = 24;
        textBoxPort.KeyPress += OnTextBoxPortKeyPress;
        // 
        // checkBoxCopyOnFinish
        // 
        checkBoxCopyOnFinish.Checked = true;
        checkBoxCopyOnFinish.CheckState = System.Windows.Forms.CheckState.Checked;
        checkBoxCopyOnFinish.Location = new System.Drawing.Point(12, 264);
        checkBoxCopyOnFinish.Name = "checkBoxCopyOnFinish";
        checkBoxCopyOnFinish.Size = new System.Drawing.Size(354, 24);
        checkBoxCopyOnFinish.TabIndex = 25;
        checkBoxCopyOnFinish.Text = "Copy the compiled map to game directory";
        checkBoxCopyOnFinish.UseVisualStyleBackColor = true;
        // 
        // checkBoxPackAssets
        // 
        checkBoxPackAssets.Checked = true;
        checkBoxPackAssets.CheckState = System.Windows.Forms.CheckState.Checked;
        checkBoxPackAssets.Location = new System.Drawing.Point(12, 178);
        checkBoxPackAssets.Name = "checkBoxPackAssets";
        checkBoxPackAssets.Size = new System.Drawing.Size(354, 24);
        checkBoxPackAssets.TabIndex = 26;
        checkBoxPackAssets.Text = "Pack assets with Pakrat";
        checkBoxPackAssets.UseVisualStyleBackColor = true;
        checkBoxPackAssets.CheckedChanged += OnCheckBoxPackAssetsChanged;
        // 
        // buttonBrowsePakrat
        // 
        buttonBrowsePakrat.Location = new System.Drawing.Point(310, 205);
        buttonBrowsePakrat.Name = "buttonBrowsePakrat";
        buttonBrowsePakrat.Size = new System.Drawing.Size(77, 23);
        buttonBrowsePakrat.TabIndex = 29;
        buttonBrowsePakrat.Text = "Browse";
        buttonBrowsePakrat.UseVisualStyleBackColor = true;
        buttonBrowsePakrat.Click += OnButtonBrowsePakratClick;
        // 
        // textBoxPakratPath
        // 
        textBoxPakratPath.Enabled = false;
        textBoxPakratPath.Location = new System.Drawing.Point(104, 205);
        textBoxPakratPath.Name = "textBoxPakratPath";
        textBoxPakratPath.Size = new System.Drawing.Size(200, 23);
        textBoxPakratPath.TabIndex = 28;
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(12, 205);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(86, 23);
        label8.TabIndex = 27;
        label8.Text = "Pakrat Path";
        label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // checkBoxAddTimestamp
        // 
        checkBoxAddTimestamp.Checked = true;
        checkBoxAddTimestamp.CheckState = System.Windows.Forms.CheckState.Checked;
        checkBoxAddTimestamp.Location = new System.Drawing.Point(12, 234);
        checkBoxAddTimestamp.Name = "checkBoxAddTimestamp";
        checkBoxAddTimestamp.Size = new System.Drawing.Size(354, 24);
        checkBoxAddTimestamp.TabIndex = 30;
        checkBoxAddTimestamp.Text = "Add dev_ prefix and _timestamp suffix to map name";
        checkBoxAddTimestamp.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(398, 484);
        Controls.Add(checkBoxAddTimestamp);
        Controls.Add(buttonBrowsePakrat);
        Controls.Add(textBoxPakratPath);
        Controls.Add(label8);
        Controls.Add(checkBoxPackAssets);
        Controls.Add(checkBoxCopyOnFinish);
        Controls.Add(textBoxPort);
        Controls.Add(label7);
        Controls.Add(textBoxUser);
        Controls.Add(label6);
        Controls.Add(checkBoxUpload);
        Controls.Add(buttonBrowseGame);
        Controls.Add(textBoxGamePath);
        Controls.Add(label5);
        Controls.Add(buttonCompile);
        Controls.Add(buttonBrowseVmf);
        Controls.Add(textBoxVmfPath);
        Controls.Add(label4);
        Controls.Add(textBoxRemotePath);
        Controls.Add(label3);
        Controls.Add(buttonBrowseLoginKey);
        Controls.Add(textBoxLoginKeyPath);
        Controls.Add(label2);
        Controls.Add(textBoxHost);
        Controls.Add(label1);
        Controls.Add(groupBoxRad);
        Controls.Add(groupBoxVis);
        Controls.Add(groupBoxBsp);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        Text = "Compile & Upload Map";
        FormClosing += OnMainFormClosing;
        groupBoxBsp.ResumeLayout(false);
        groupBoxVis.ResumeLayout(false);
        groupBoxRad.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.CheckBox checkBoxAddTimestamp;

    private System.Windows.Forms.Button buttonBrowsePakrat;

    private System.Windows.Forms.TextBox textBoxPakratPath;

    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.CheckBox checkBoxPackAssets;

    private System.Windows.Forms.CheckBox checkBoxCopyOnFinish;

    private System.Windows.Forms.TextBox textBoxUser;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.TextBox textBoxPort;

    private System.Windows.Forms.CheckBox checkBoxUpload;

    private System.Windows.Forms.Button buttonCompile;

    private System.Windows.Forms.Button buttonBrowseGame;

    private System.Windows.Forms.TextBox textBoxGamePath;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Button buttonBrowseVmf;

    private System.Windows.Forms.TextBox textBoxVmfPath;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.TextBox textBoxRemotePath;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Button buttonBrowseLoginKey;

    private System.Windows.Forms.TextBox textBoxLoginKeyPath;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox textBoxHost;

    private System.Windows.Forms.RadioButton radioButtonBspNo;

    private System.Windows.Forms.RadioButton radioButtonBspNormal;

    private System.Windows.Forms.RadioButton radioButtonBspOnlyEntities;

    private System.Windows.Forms.GroupBox groupBoxVis;

    private System.Windows.Forms.RadioButton radioButtonVisFast;

    private System.Windows.Forms.RadioButton radioButtonVisNormal;

    private System.Windows.Forms.RadioButton radioButtonVisNo;

    private System.Windows.Forms.GroupBox groupBoxRad;

    private System.Windows.Forms.RadioButton radioButtonRadFast;

    private System.Windows.Forms.RadioButton radioButtonRadNormal;

    private System.Windows.Forms.RadioButton radioButtonRadNo;

    private System.Windows.Forms.CheckBox checkBoxRadHdr;

    private System.Windows.Forms.GroupBox groupBoxBsp;

#endregion
}
