namespace MKVtoMP4
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
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
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 151);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(754, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // startConvertBtn
            // 
            this.startConvertBtn.Location = new System.Drawing.Point(671, 63);
            this.startConvertBtn.Name = "startConvertBtn";
            this.startConvertBtn.Size = new System.Drawing.Size(106, 23);
            this.startConvertBtn.TabIndex = 21;
            this.startConvertBtn.Text = "Start Convertion";
            this.startConvertBtn.UseSelectable = true;
            this.startConvertBtn.Click += new System.EventHandler(this.startConvertBtn_Click);
            // 
            // cancelConvertBtn
            // 
            this.cancelConvertBtn.Enabled = false;
            this.cancelConvertBtn.Location = new System.Drawing.Point(671, 92);
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
            this.inputFileTxt.CustomButton.Location = new System.Drawing.Point(369, 1);
            this.inputFileTxt.CustomButton.Name = "";
            this.inputFileTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.inputFileTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputFileTxt.CustomButton.TabIndex = 1;
            this.inputFileTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputFileTxt.CustomButton.UseSelectable = true;
            this.inputFileTxt.Lines = new string[0];
            this.inputFileTxt.Location = new System.Drawing.Point(102, 63);
            this.inputFileTxt.MaxLength = 32767;
            this.inputFileTxt.Name = "inputFileTxt";
            this.inputFileTxt.PasswordChar = '\0';
            this.inputFileTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputFileTxt.SelectedText = "";
            this.inputFileTxt.SelectionLength = 0;
            this.inputFileTxt.SelectionStart = 0;
            this.inputFileTxt.ShortcutsEnabled = true;
            this.inputFileTxt.ShowButton = true;
            this.inputFileTxt.Size = new System.Drawing.Size(391, 23);
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
            this.outputFileTxt.CustomButton.Location = new System.Drawing.Point(369, 1);
            this.outputFileTxt.CustomButton.Name = "";
            this.outputFileTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.outputFileTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.outputFileTxt.CustomButton.TabIndex = 1;
            this.outputFileTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.outputFileTxt.CustomButton.UseSelectable = true;
            this.outputFileTxt.CustomButton.Visible = false;
            this.outputFileTxt.Lines = new string[0];
            this.outputFileTxt.Location = new System.Drawing.Point(102, 92);
            this.outputFileTxt.MaxLength = 32767;
            this.outputFileTxt.Name = "outputFileTxt";
            this.outputFileTxt.PasswordChar = '\0';
            this.outputFileTxt.ReadOnly = true;
            this.outputFileTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.outputFileTxt.SelectedText = "";
            this.outputFileTxt.SelectionLength = 0;
            this.outputFileTxt.SelectionStart = 0;
            this.outputFileTxt.ShortcutsEnabled = true;
            this.outputFileTxt.Size = new System.Drawing.Size(391, 23);
            this.outputFileTxt.TabIndex = 25;
            this.outputFileTxt.UseSelectable = true;
            this.outputFileTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.outputFileTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // timeElpasedlbl
            // 
            this.timeElpasedlbl.Location = new System.Drawing.Point(280, 177);
            this.timeElpasedlbl.Name = "timeElpasedlbl";
            this.timeElpasedlbl.Size = new System.Drawing.Size(93, 23);
            this.timeElpasedlbl.TabIndex = 26;
            this.timeElpasedlbl.Text = "Time Elapsed:";
            this.timeElpasedlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeRemaining
            // 
            this.timeRemaining.Location = new System.Drawing.Point(139, 177);
            this.timeRemaining.Name = "timeRemaining";
            this.timeRemaining.Size = new System.Drawing.Size(134, 23);
            this.timeRemaining.TabIndex = 27;
            this.timeRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeElapsed
            // 
            this.timeElapsed.Location = new System.Drawing.Point(379, 177);
            this.timeElapsed.Name = "timeElapsed";
            this.timeElapsed.Size = new System.Drawing.Size(134, 23);
            this.timeElapsed.TabIndex = 28;
            this.timeElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeRemainingName
            // 
            this.TimeRemainingName.Location = new System.Drawing.Point(23, 177);
            this.TimeRemainingName.Name = "TimeRemainingName";
            this.TimeRemainingName.Size = new System.Drawing.Size(110, 23);
            this.TimeRemainingName.TabIndex = 29;
            this.TimeRemainingName.Text = "Time Remaining:";
            this.TimeRemainingName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(35, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 23);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Input:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(35, 92);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 23);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "Output:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sizeLbl
            // 
            this.sizeLbl.Location = new System.Drawing.Point(61, 239);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(150, 23);
            this.sizeLbl.TabIndex = 32;
            this.sizeLbl.Text = "Size:";
            this.sizeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bitrateLbl
            // 
            this.bitrateLbl.Location = new System.Drawing.Point(61, 263);
            this.bitrateLbl.Name = "bitrateLbl";
            this.bitrateLbl.Size = new System.Drawing.Size(150, 23);
            this.bitrateLbl.TabIndex = 33;
            this.bitrateLbl.Text = "Bitrate:";
            this.bitrateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fpsLbl
            // 
            this.fpsLbl.Location = new System.Drawing.Point(61, 311);
            this.fpsLbl.Name = "fpsLbl";
            this.fpsLbl.Size = new System.Drawing.Size(150, 23);
            this.fpsLbl.TabIndex = 35;
            this.fpsLbl.Text = "Frames per second:";
            this.fpsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frameLbl
            // 
            this.frameLbl.Location = new System.Drawing.Point(61, 287);
            this.frameLbl.Name = "frameLbl";
            this.frameLbl.Size = new System.Drawing.Size(150, 23);
            this.frameLbl.TabIndex = 34;
            this.frameLbl.Text = "Frame:";
            this.frameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prossdurLbl
            // 
            this.prossdurLbl.Location = new System.Drawing.Point(61, 335);
            this.prossdurLbl.Name = "prossdurLbl";
            this.prossdurLbl.Size = new System.Drawing.Size(150, 23);
            this.prossdurLbl.TabIndex = 36;
            this.prossdurLbl.Text = "Processed Duration:";
            this.prossdurLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sizeBox
            // 
            this.sizeBox.Location = new System.Drawing.Point(217, 239);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(151, 23);
            this.sizeBox.TabIndex = 37;
            this.sizeBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BitrateBox
            // 
            this.BitrateBox.Location = new System.Drawing.Point(217, 263);
            this.BitrateBox.Name = "BitrateBox";
            this.BitrateBox.Size = new System.Drawing.Size(151, 23);
            this.BitrateBox.TabIndex = 38;
            this.BitrateBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frameBox
            // 
            this.frameBox.Location = new System.Drawing.Point(217, 287);
            this.frameBox.Name = "frameBox";
            this.frameBox.Size = new System.Drawing.Size(151, 23);
            this.frameBox.TabIndex = 39;
            this.frameBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fpsBox
            // 
            this.fpsBox.Location = new System.Drawing.Point(217, 311);
            this.fpsBox.Name = "fpsBox";
            this.fpsBox.Size = new System.Drawing.Size(151, 23);
            this.fpsBox.TabIndex = 40;
            this.fpsBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // processedBox
            // 
            this.processedBox.Location = new System.Drawing.Point(217, 335);
            this.processedBox.Name = "processedBox";
            this.processedBox.Size = new System.Drawing.Size(151, 23);
            this.processedBox.TabIndex = 41;
            this.processedBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.processedBox);
            this.Controls.Add(this.fpsBox);
            this.Controls.Add(this.frameBox);
            this.Controls.Add(this.BitrateBox);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.prossdurLbl);
            this.Controls.Add(this.fpsLbl);
            this.Controls.Add(this.frameLbl);
            this.Controls.Add(this.bitrateLbl);
            this.Controls.Add(this.sizeLbl);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TimeRemainingName);
            this.Controls.Add(this.timeElapsed);
            this.Controls.Add(this.timeRemaining);
            this.Controls.Add(this.timeElpasedlbl);
            this.Controls.Add(this.outputFileTxt);
            this.Controls.Add(this.inputFileTxt);
            this.Controls.Add(this.cancelConvertBtn);
            this.Controls.Add(this.startConvertBtn);
            this.Controls.Add(this.progressBar1);
            this.Name = "Main";
            this.Text = "MKV to MP4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
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
    }
}

