namespace AndOTA
{
    partial class AndOTA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AndOTA));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDataFile = new System.Windows.Forms.TextBox();
            this.textBoxTransferList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBrowseDataFile = new System.Windows.Forms.Button();
            this.buttonBrowseTransferList = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonSaveOutputFile = new System.Windows.Forms.Button();
            this.textBoxOutputFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.labelListVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.divider1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelBlocks = new System.Windows.Forms.ToolStripStatusLabel();
            this.divider2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data file:";
            // 
            // textBoxDataFile
            // 
            this.textBoxDataFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDataFile.Location = new System.Drawing.Point(82, 12);
            this.textBoxDataFile.Name = "textBoxDataFile";
            this.textBoxDataFile.Size = new System.Drawing.Size(399, 20);
            this.textBoxDataFile.TabIndex = 1;
            // 
            // textBoxTransferList
            // 
            this.textBoxTransferList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTransferList.Location = new System.Drawing.Point(82, 40);
            this.textBoxTransferList.Name = "textBoxTransferList";
            this.textBoxTransferList.Size = new System.Drawing.Size(399, 20);
            this.textBoxTransferList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transfer list:";
            // 
            // buttonBrowseDataFile
            // 
            this.buttonBrowseDataFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseDataFile.Location = new System.Drawing.Point(487, 12);
            this.buttonBrowseDataFile.Name = "buttonBrowseDataFile";
            this.buttonBrowseDataFile.Size = new System.Drawing.Size(25, 20);
            this.buttonBrowseDataFile.TabIndex = 4;
            this.buttonBrowseDataFile.Text = "...";
            this.buttonBrowseDataFile.UseVisualStyleBackColor = true;
            this.buttonBrowseDataFile.Click += new System.EventHandler(this.buttonBrowseDataFile_Click);
            // 
            // buttonBrowseTransferList
            // 
            this.buttonBrowseTransferList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseTransferList.Location = new System.Drawing.Point(487, 40);
            this.buttonBrowseTransferList.Name = "buttonBrowseTransferList";
            this.buttonBrowseTransferList.Size = new System.Drawing.Size(25, 20);
            this.buttonBrowseTransferList.TabIndex = 5;
            this.buttonBrowseTransferList.Text = "...";
            this.buttonBrowseTransferList.UseVisualStyleBackColor = true;
            this.buttonBrowseTransferList.Click += new System.EventHandler(this.buttonBrowseTransferList_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConvert.Enabled = false;
            this.buttonConvert.Location = new System.Drawing.Point(432, 96);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(80, 23);
            this.buttonConvert.TabIndex = 6;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonSaveOutputFile
            // 
            this.buttonSaveOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveOutputFile.Location = new System.Drawing.Point(487, 68);
            this.buttonSaveOutputFile.Name = "buttonSaveOutputFile";
            this.buttonSaveOutputFile.Size = new System.Drawing.Size(25, 20);
            this.buttonSaveOutputFile.TabIndex = 9;
            this.buttonSaveOutputFile.Text = "...";
            this.buttonSaveOutputFile.UseVisualStyleBackColor = true;
            this.buttonSaveOutputFile.Click += new System.EventHandler(this.buttonSaveOutputFile_Click);
            // 
            // textBoxOutputFile
            // 
            this.textBoxOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputFile.Location = new System.Drawing.Point(82, 68);
            this.textBoxOutputFile.Name = "textBoxOutputFile";
            this.textBoxOutputFile.Size = new System.Drawing.Size(399, 20);
            this.textBoxOutputFile.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Output file:";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelListVersion,
            this.divider1,
            this.labelBlocks,
            this.divider2,
            this.labelStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 129);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(524, 22);
            this.statusBar.TabIndex = 10;
            this.statusBar.Text = "statusStrip1";
            // 
            // labelListVersion
            // 
            this.labelListVersion.Name = "labelListVersion";
            this.labelListVersion.Size = new System.Drawing.Size(77, 17);
            this.labelListVersion.Text = "List version: -";
            // 
            // divider1
            // 
            this.divider1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.divider1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(4, 17);
            // 
            // labelBlocks
            // 
            this.labelBlocks.Name = "labelBlocks";
            this.labelBlocks.Size = new System.Drawing.Size(95, 17);
            this.labelBlocks.Text = "Blocks to write: -";
            // 
            // divider2
            // 
            this.divider2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.divider2.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.divider2.Name = "divider2";
            this.divider2.Size = new System.Drawing.Size(4, 17);
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(64, 17);
            this.labelStatus.Text = "Status: Idle";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 96);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(414, 23);
            this.progressBar.TabIndex = 11;
            // 
            // AndOTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 151);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.buttonSaveOutputFile);
            this.Controls.Add(this.textBoxOutputFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonBrowseTransferList);
            this.Controls.Add(this.buttonBrowseDataFile);
            this.Controls.Add(this.textBoxTransferList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDataFile);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(540, 190);
            this.Name = "AndOTA";
            this.Text = "AndOTA";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDataFile;
        private System.Windows.Forms.TextBox textBoxTransferList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBrowseDataFile;
        private System.Windows.Forms.Button buttonBrowseTransferList;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonSaveOutputFile;
        private System.Windows.Forms.TextBox textBoxOutputFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel labelListVersion;
        private System.Windows.Forms.ToolStripStatusLabel labelBlocks;
        private System.Windows.Forms.ToolStripStatusLabel divider1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel divider2;
    }
}

