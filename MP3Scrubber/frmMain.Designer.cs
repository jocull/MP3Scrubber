partial class frmMain
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
        this.label1 = new System.Windows.Forms.Label();
        this.txtFolderPath = new System.Windows.Forms.TextBox();
        this.btnBrowse = new System.Windows.Forms.Button();
        this.btnStart = new System.Windows.Forms.Button();
        this.btnExit = new System.Windows.Forms.Button();
        this.chkRecycle = new System.Windows.Forms.CheckBox();
        this.txtActionLog = new System.Windows.Forms.TextBox();
        this.txtFileDateTime = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.btnCurrentDateTime = new System.Windows.Forms.Button();
        this.chkSimulateDelete = new System.Windows.Forms.CheckBox();
        this.btnTileNames = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(136, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Folder to Scrub (Recursive)";
        // 
        // txtFolderPath
        // 
        this.txtFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.txtFolderPath.Location = new System.Drawing.Point(13, 26);
        this.txtFolderPath.Name = "txtFolderPath";
        this.txtFolderPath.ReadOnly = true;
        this.txtFolderPath.Size = new System.Drawing.Size(292, 20);
        this.txtFolderPath.TabIndex = 1;
        // 
        // btnBrowse
        // 
        this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnBrowse.Location = new System.Drawing.Point(311, 24);
        this.btnBrowse.Name = "btnBrowse";
        this.btnBrowse.Size = new System.Drawing.Size(75, 23);
        this.btnBrowse.TabIndex = 2;
        this.btnBrowse.Text = "Browse...";
        this.btnBrowse.UseVisualStyleBackColor = true;
        this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
        // 
        // btnStart
        // 
        this.btnStart.Location = new System.Drawing.Point(13, 91);
        this.btnStart.Name = "btnStart";
        this.btnStart.Size = new System.Drawing.Size(75, 23);
        this.btnStart.TabIndex = 3;
        this.btnStart.Text = "Scrub!";
        this.btnStart.UseVisualStyleBackColor = true;
        this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
        // 
        // btnExit
        // 
        this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnExit.Location = new System.Drawing.Point(311, 302);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(75, 23);
        this.btnExit.TabIndex = 4;
        this.btnExit.Text = "Exit";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        // 
        // chkRecycle
        // 
        this.chkRecycle.AutoSize = true;
        this.chkRecycle.Checked = true;
        this.chkRecycle.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkRecycle.Location = new System.Drawing.Point(193, 95);
        this.chkRecycle.Name = "chkRecycle";
        this.chkRecycle.Size = new System.Drawing.Size(90, 17);
        this.chkRecycle.TabIndex = 5;
        this.chkRecycle.Text = "Use Recycler";
        this.chkRecycle.UseVisualStyleBackColor = true;
        // 
        // txtActionLog
        // 
        this.txtActionLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.txtActionLog.Location = new System.Drawing.Point(13, 120);
        this.txtActionLog.Multiline = true;
        this.txtActionLog.Name = "txtActionLog";
        this.txtActionLog.ReadOnly = true;
        this.txtActionLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtActionLog.Size = new System.Drawing.Size(373, 176);
        this.txtActionLog.TabIndex = 6;
        this.txtActionLog.Text = "Waiting to go...";
        // 
        // txtFileDateTime
        // 
        this.txtFileDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.txtFileDateTime.Location = new System.Drawing.Point(13, 65);
        this.txtFileDateTime.Name = "txtFileDateTime";
        this.txtFileDateTime.Size = new System.Drawing.Size(263, 20);
        this.txtFileDateTime.TabIndex = 7;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(12, 49);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(154, 13);
        this.label2.TabIndex = 8;
        this.label2.Text = "Remove Files Created Before...";
        // 
        // btnCurrentDateTime
        // 
        this.btnCurrentDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnCurrentDateTime.Location = new System.Drawing.Point(282, 63);
        this.btnCurrentDateTime.Name = "btnCurrentDateTime";
        this.btnCurrentDateTime.Size = new System.Drawing.Size(104, 23);
        this.btnCurrentDateTime.TabIndex = 9;
        this.btnCurrentDateTime.Text = "Current Date/Time";
        this.btnCurrentDateTime.UseVisualStyleBackColor = true;
        this.btnCurrentDateTime.Click += new System.EventHandler(this.btnCurrentDateTime_Click);
        // 
        // chkSimulateDelete
        // 
        this.chkSimulateDelete.AutoSize = true;
        this.chkSimulateDelete.Location = new System.Drawing.Point(289, 95);
        this.chkSimulateDelete.Name = "chkSimulateDelete";
        this.chkSimulateDelete.Size = new System.Drawing.Size(105, 17);
        this.chkSimulateDelete.TabIndex = 10;
        this.chkSimulateDelete.Text = "Simulate Deletes";
        this.chkSimulateDelete.UseVisualStyleBackColor = true;
        // 
        // btnTileNames
        // 
        this.btnTileNames.Location = new System.Drawing.Point(94, 91);
        this.btnTileNames.Name = "btnTileNames";
        this.btnTileNames.Size = new System.Drawing.Size(93, 23);
        this.btnTileNames.TabIndex = 11;
        this.btnTileNames.Text = "Tilt MP3 Names";
        this.btnTileNames.UseVisualStyleBackColor = true;
        this.btnTileNames.Click += new System.EventHandler(this.btnTileNames_Click);
        // 
        // frmMain
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(398, 337);
        this.Controls.Add(this.btnTileNames);
        this.Controls.Add(this.chkSimulateDelete);
        this.Controls.Add(this.btnCurrentDateTime);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.txtFileDateTime);
        this.Controls.Add(this.txtActionLog);
        this.Controls.Add(this.chkRecycle);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnStart);
        this.Controls.Add(this.btnBrowse);
        this.Controls.Add(this.txtFolderPath);
        this.Controls.Add(this.label1);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MinimumSize = new System.Drawing.Size(406, 371);
        this.Name = "frmMain";
        this.Text = "MP3Scrubber";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtFolderPath;
    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.CheckBox chkRecycle;
    private System.Windows.Forms.TextBox txtActionLog;
    private System.Windows.Forms.TextBox txtFileDateTime;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnCurrentDateTime;
    private System.Windows.Forms.CheckBox chkSimulateDelete;
    private System.Windows.Forms.Button btnTileNames;
}