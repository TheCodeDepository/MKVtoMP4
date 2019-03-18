using FFmpeg.NET;
using FFmpeg.NET.Enums;
using FFmpeg.NET.Events;
using System;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using System.Diagnostics;



namespace VideoConverter
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        public string Input { get { return inputFileTxt.Text; } set { inputFileTxt.Text = value; } }
        public string Output { get { return outputFileTxt.Text; } set { outputFileTxt.Text = value; } }

        public Engine ffmpegEngine { get; set; }
        public bool Processing { get; set; }

        TimeSpan video_Length;
        DateTime time_started;

        private void startConvertBtn_Click(object sender, EventArgs e)
        {
            time_started = DateTime.Now;
            video_Length = FileProperties.GetTimeSpanProperty(Input, FileProperties.PropertiesEnum.Length);
            ConvertVideo();
            startConvertBtn.Enabled = false;
            cancelConvertBtn.Enabled = true;
        }

        private void ConvertVideo()
        {
            ffmpegEngine = new Engine("ffmpeg.exe");

            ffmpegEngine.Progress += OnProgress;
            ffmpegEngine.Complete += OnComplete;

            ffmpegEngine.ConvertAsync(new MediaFile(Input), new MediaFile(Output));
            Processing = true;
        }

        private void UpdateFields(ConversionProgressEventArgs e)
        {
            var time_taken = DateTime.Now.Subtract(time_started).TotalSeconds;
            var processed = e.ProcessedDuration.TotalSeconds;
            var amount_left = video_Length.TotalSeconds - processed;

            var time_remaining = (time_taken / processed) * amount_left;
            var percent_Complete = (processed / video_Length.TotalSeconds) * 100;

            progressBar.Value = (int)percent_Complete;

            timeRemaining.Text = new TimeSpan(0, 0, (int)time_remaining / 60, 0).ToString();
            timeElapsed.Text = new TimeSpan(0, 0, 0, (int)time_taken).ToString();

            BitrateBox.Text = e.Bitrate.ToString();
            fpsBox.Text = e.Fps.ToString();
            frameBox.Text = e.Frame.ToString();
            sizeBox.Text = (e.SizeKb / 1000.00).ToString() + " MB";
            processedBox.Text = new TimeSpan(0, 0, 0, (int)processed).ToString();
        }



        //Events
        private void OnComplete(object sender, ConversionCompleteEventArgs e)
        {
            Processing = false;
            MetroMessageBox.Show(this, "Process Complete!");
            progressBar.Value = 0;
            cancelConvertBtn.Enabled = false;
            startConvertBtn.Enabled = true;
        }

        private void OnProgress(object sender, ConversionProgressEventArgs e)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<ConversionProgressEventArgs>(UpdateFields), e);
            }
            else
            {
                UpdateFields(e);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Processing)
            {
                if (!CancelConversion())
                {
                    e.Cancel = true;
                }
            }
        }

        private bool CancelConversion()
        {
            var result = MetroMessageBox.Show(this,
                 "Are you sure you wish to cancel?",
                 "Are you sure?",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Process[] procs = Process.GetProcessesByName("ffmpeg");
                foreach (Process proc in procs)
                {
                    proc.Kill();
                }
                ffmpegEngine = null;
                Processing = false;
                startConvertBtn.Enabled = true;
                cancelConvertBtn.Enabled = false;
                return true;
            }
            else
            {
                return false;
            }
        }



        private void cancelConvertBtn_Click(object sender, EventArgs e)
        {
            CancelConversion();
        }

        private void inputFileTxt_ButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Input = open.FileName;
                Output = UpdateSamplePath(open.FileName, fileType.Text);
            }
        }

        private string UpdateSamplePath(string input, string extension = ".mp4")
        {
            return Path.GetDirectoryName(input)
                                + "\\"
                                + Path.GetFileNameWithoutExtension(input)
                                + "_output"
                                + extension;
        }

        private void fileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(fileType.Text) && !String.IsNullOrWhiteSpace(Input))
            {
                Output = UpdateSamplePath(Input, fileType.Text);
            }
        }
    }
}
