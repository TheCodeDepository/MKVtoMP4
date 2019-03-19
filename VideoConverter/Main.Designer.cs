namespace VideoConverter
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.startConvertBtn = new MetroFramework.Controls.MetroButton();
            this.cancelConvertBtn = new MetroFramework.Controls.MetroButton();
            this.inputFileTxt = new MetroFramework.Controls.MetroTextBox();
            this.outputFileTxt = new MetroFramework.Controls.MetroTextBox();
            this.timeElpasedlbl = new MetroFramework.Controls.MetroLabel();
            this.timeRemaining = new MetroFramework.Controls.MetroLabel();
            this.timeElapsed = new MetroFramework.Controls.MetroLabel();
            this.TimeRemainingName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.sizeLbl = new MetroFramework.Controls.MetroLabel();
            this.bitrateLbl = new MetroFramework.Controls.MetroLabel();
            this.fpsLbl = new MetroFramework.Controls.MetroLabel();
            this.frameLbl = new MetroFramework.Controls.MetroLabel();
            this.prossdurLbl = new MetroFramework.Controls.MetroLabel();
            this.sizeBox = new MetroFramework.Controls.MetroLabel();
            this.BitrateBox = new MetroFramework.Controls.MetroLabel();
            this.frameBox = new MetroFramework.Controls.MetroLabel();
            this.fpsBox = new MetroFramework.Controls.MetroLabel();
            this.processedBox = new MetroFramework.Controls.MetroLabel();
            this.ConversionStates = new System.Windows.Forms.Panel();
            this.fileType = new System.Windows.Forms.ComboBox();
            this.ConversionStates.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(23, 162);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(754, 23);
            this.progressBar.TabIndex = 0;
            // 
            // startConvertBtn
            // 
            this.startConvertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startConvertBtn.Location = new System.Drawing.Point(648, 63);
            this.startConvertBtn.Name = "startConvertBtn";
            this.startConvertBtn.Size = new System.Drawing.Size(106, 23);
            this.startConvertBtn.TabIndex = 21;
            this.startConvertBtn.Text = "Start Convertion";
            this.startConvertBtn.UseSelectable = true;
            this.startConvertBtn.Click += new System.EventHandler(this.startConvertBtn_Click);
            // 
            // cancelConvertBtn
            // 
            this.cancelConvertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelConvertBtn.Enabled = false;
            this.cancelConvertBtn.Location = new System.Drawing.Point(648, 92);
            this.cancelConvertBtn.Name = "cancelConvertBtn";
            this.cancelConvertBtn.Size = new System.Drawing.Size(106, 23);
            this.cancelConvertBtn.TabIndex = 22;
            this.cancelConvertBtn.Text = "Cancel";
            this.cancelConvertBtn.UseSelectable = true;
            this.cancelConvertBtn.Click += new System.EventHandler(this.cancelConvertBtn_Click);
            // 
            // inputFileTxt
            // 
            // 
            // 
            // 
            this.inputFileTxt.CustomButton.Image = null;
            this.inputFileTxt.CustomButton.Location = new System.Drawing.Point(409, 1);
            this.inputFileTxt.CustomButton.Name = "";
            this.inputFileTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.inputFileTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputFileTxt.CustomButton.TabIndex = 1;
            this.inputFileTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputFileTxt.CustomButton.UseSelectable = true;
            this.inputFileTxt.Lines = new string[0];
            this.inputFileTxt.Location = new System.Drawing.Point(106, 63);
            this.inputFileTxt.MaxLength = 32767;
            this.inputFileTxt.Name = "inputFileTxt";
            this.inputFileTxt.PasswordChar = '\0';
            this.inputFileTxt.ReadOnly = true;
            this.inputFileTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputFileTxt.SelectedText = "";
            this.inputFileTxt.SelectionLength = 0;
            this.inputFileTxt.SelectionStart = 0;
            this.inputFileTxt.ShortcutsEnabled = true;
            this.inputFileTxt.ShowButton = true;
            this.inputFileTxt.Size = new System.Drawing.Size(431, 23);
            this.inputFileTxt.TabIndex = 24;
            this.inputFileTxt.UseSelectable = true;
            this.inputFileTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputFileTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.inputFileTxt.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.inputFileTxt_ButtonClick);
            // 
            // outputFileTxt
            // 
            // 
            // 
            // 
            this.outputFileTxt.CustomButton.Image = null;
            this.outputFileTxt.CustomButton.Location = new System.Drawing.Point(409, 1);
            this.outputFileTxt.CustomButton.Name = "";
            this.outputFileTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.outputFileTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.outputFileTxt.CustomButton.TabIndex = 1;
            this.outputFileTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.outputFileTxt.CustomButton.UseSelectable = true;
            this.outputFileTxt.Lines = new string[0];
            this.outputFileTxt.Location = new System.Drawing.Point(106, 92);
            this.outputFileTxt.MaxLength = 32767;
            this.outputFileTxt.Name = "outputFileTxt";
            this.outputFileTxt.PasswordChar = '\0';
            this.outputFileTxt.ReadOnly = true;
            this.outputFileTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.outputFileTxt.SelectedText = "";
            this.outputFileTxt.SelectionLength = 0;
            this.outputFileTxt.SelectionStart = 0;
            this.outputFileTxt.ShortcutsEnabled = true;
            this.outputFileTxt.ShowButton = true;
            this.outputFileTxt.Size = new System.Drawing.Size(431, 23);
            this.outputFileTxt.TabIndex = 25;
            this.outputFileTxt.UseSelectable = true;
            this.outputFileTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.outputFileTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.outputFileTxt.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.outputFileTxt_ButtonClick);
            // 
            // timeElpasedlbl
            // 
            this.timeElpasedlbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeElpasedlbl.Location = new System.Drawing.Point(535, 136);
            this.timeElpasedlbl.Name = "timeElpasedlbl";
            this.timeElpasedlbl.Size = new System.Drawing.Size(93, 23);
            this.timeElpasedlbl.TabIndex = 26;
            this.timeElpasedlbl.Text = "Time Elapsed:";
            this.timeElpasedlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeRemaining
            // 
            this.timeRemaining.Location = new System.Drawing.Point(172, 136);
            this.timeRemaining.Name = "timeRemaining";
            this.timeRemaining.Size = new System.Drawing.Size(134, 23);
            this.timeRemaining.TabIndex = 27;
            this.timeRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeElapsed
            // 
            this.timeElapsed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeElapsed.Location = new System.Drawing.Point(634, 136);
            this.timeElapsed.Name = "timeElapsed";
            this.timeElapsed.Size = new System.Drawing.Size(118, 23);
            this.timeElapsed.TabIndex = 28;
            this.timeElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeRemainingName
            // 
            this.TimeRemainingName.Location = new System.Drawing.Point(35, 136);
            this.TimeRemainingName.Name = "TimeRemainingName";
            this.TimeRemainingName.Size = new System.Drawing.Size(131, 23);
            this.TimeRemainingName.TabIndex = 29;
            this.TimeRemainingName.Text = "Time Remaining:";
            this.TimeRemainingName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(39, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 23);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Input:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(39, 92);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 23);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "Output:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sizeLbl
            // 
            this.sizeLbl.Location = new System.Drawing.Point(4, 5);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(131, 23);
            this.sizeLbl.TabIndex = 32;
            this.sizeLbl.Text = "Size:";
            this.sizeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bitrateLbl
            // 
            this.bitrateLbl.Location = new System.Drawing.Point(4, 29);
            this.bitrateLbl.Name = "bitrateLbl";
            this.bitrateLbl.Size = new System.Drawing.Size(131, 23);
            this.bitrateLbl.TabIndex = 33;
            this.bitrateLbl.Text = "Bitrate:";
            this.bitrateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fpsLbl
            // 
            this.fpsLbl.Location = new System.Drawing.Point(4, 77);
            this.fpsLbl.Name = "fpsLbl";
            this.fpsLbl.Size = new System.Drawing.Size(131, 23);
            this.fpsLbl.TabIndex = 35;
            this.fpsLbl.Text = "Frames per second:";
            this.fpsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frameLbl
            // 
            this.frameLbl.Location = new System.Drawing.Point(4, 53);
            this.frameLbl.Name = "frameLbl";
            this.frameLbl.Size = new System.Drawing.Size(131, 23);
            this.frameLbl.TabIndex = 34;
            this.frameLbl.Text = "Frame:";
            this.frameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prossdurLbl
            // 
            this.prossdurLbl.Location = new System.Drawing.Point(4, 101);
            this.prossdurLbl.Name = "prossdurLbl";
            this.prossdurLbl.Size = new System.Drawing.Size(131, 23);
            this.prossdurLbl.TabIndex = 36;
            this.prossdurLbl.Text = "Processed Duration:";
            this.prossdurLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sizeBox
            // 
            this.sizeBox.Location = new System.Drawing.Point(141, 5);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(134, 23);
            this.sizeBox.TabIndex = 37;
            this.sizeBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BitrateBox
            // 
            this.BitrateBox.Location = new System.Drawing.Point(141, 29);
            this.BitrateBox.Name = "BitrateBox";
            this.BitrateBox.Size = new System.Drawing.Size(134, 23);
            this.BitrateBox.TabIndex = 38;
            this.BitrateBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frameBox
            // 
            this.frameBox.Location = new System.Drawing.Point(141, 53);
            this.frameBox.Name = "frameBox";
            this.frameBox.Size = new System.Drawing.Size(134, 23);
            this.frameBox.TabIndex = 39;
            this.frameBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fpsBox
            // 
            this.fpsBox.Location = new System.Drawing.Point(141, 77);
            this.fpsBox.Name = "fpsBox";
            this.fpsBox.Size = new System.Drawing.Size(134, 23);
            this.fpsBox.TabIndex = 40;
            this.fpsBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // processedBox
            // 
            this.processedBox.Location = new System.Drawing.Point(141, 101);
            this.processedBox.Name = "processedBox";
            this.processedBox.Size = new System.Drawing.Size(134, 23);
            this.processedBox.TabIndex = 41;
            this.processedBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConversionStates
            // 
            this.ConversionStates.Controls.Add(this.sizeLbl);
            this.ConversionStates.Controls.Add(this.processedBox);
            this.ConversionStates.Controls.Add(this.bitrateLbl);
            this.ConversionStates.Controls.Add(this.fpsBox);
            this.ConversionStates.Controls.Add(this.frameLbl);
            this.ConversionStates.Controls.Add(this.frameBox);
            this.ConversionStates.Controls.Add(this.fpsLbl);
            this.ConversionStates.Controls.Add(this.BitrateBox);
            this.ConversionStates.Controls.Add(this.prossdurLbl);
            this.ConversionStates.Controls.Add(this.sizeBox);
            this.ConversionStates.Location = new System.Drawing.Point(35, 191);
            this.ConversionStates.Name = "ConversionStates";
            this.ConversionStates.Size = new System.Drawing.Size(280, 129);
            this.ConversionStates.TabIndex = 42;
            // 
            // fileType
            // 
            this.fileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.fileType.FormattingEnabled = true;
            this.fileType.Items.AddRange(new object[] {
            ".mp4",
            ".avi",
            ".mkv",
            ".wmv",
            ".flv",
            ".mov"});
            this.fileType.Location = new System.Drawing.Point(543, 92);
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(88, 23);
            this.fileType.TabIndex = 43;
            this.fileType.Text = ".mp4";
            this.fileType.SelectedIndexChanged += new System.EventHandler(this.fileType_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.fileType);
            this.Controls.Add(this.ConversionStates);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TimeRemainingName);
            this.Controls.Add(this.timeElapsed);
            this.Controls.Add(this.outputFileTxt);
            this.Controls.Add(this.inputFileTxt);
            this.Controls.Add(this.timeRemaining);
            this.Controls.Add(this.cancelConvertBtn);
            this.Controls.Add(this.startConvertBtn);
            this.Controls.Add(this.timeElpasedlbl);
            this.Controls.Add(this.progressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Video Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ConversionStates.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private MetroFramework.Controls.MetroButton startConvertBtn;
        private MetroFramework.Controls.MetroButton cancelConvertBtn;
        private MetroFramework.Controls.MetroTextBox inputFileTxt;
        private MetroFramework.Controls.MetroTextBox outputFileTxt;
        private MetroFramework.Controls.MetroLabel timeElpasedlbl;
        private MetroFramework.Controls.MetroLabel timeRemaining;
        private MetroFramework.Controls.MetroLabel timeElapsed;
        private MetroFramework.Controls.MetroLabel TimeRemainingName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel sizeLbl;
        private MetroFramework.Controls.MetroLabel bitrateLbl;
        private MetroFramework.Controls.MetroLabel fpsLbl;
        private MetroFramework.Controls.MetroLabel frameLbl;
        private MetroFramework.Controls.MetroLabel prossdurLbl;
        private MetroFramework.Controls.MetroLabel sizeBox;
        private MetroFramework.Controls.MetroLabel BitrateBox;
        private MetroFramework.Controls.MetroLabel frameBox;
        private MetroFramework.Controls.MetroLabel fpsBox;
        private MetroFramework.Controls.MetroLabel processedBox;
        private System.Windows.Forms.Panel ConversionStates;
        private System.Windows.Forms.ComboBox fileType;
    }
}

