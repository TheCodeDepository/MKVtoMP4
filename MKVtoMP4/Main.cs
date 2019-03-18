using FFmpeg.NET;
using FFmpeg.NET.Enums;
using FFmpeg.NET.Events;
using System;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using System.Diagnostics;



namespace MKVtoMP4
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        public string Input { get; set; }
        public string Output { get; set; }

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
            ffmpegEngine = new Engine("C:\\ffmpeg\\ffmpeg.exe");

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

            progressBar1.Value = (int)percent_Complete;

            timeRemaining.Text = new TimeSpan(0, 0, (int)time_remaining / 60, 0).ToString();
            timeElapsed.Text = new TimeSpan(0, 0, 0, (int)time_taken).ToString();

            BitrateBox.Text = e.Bitrate.ToString();
            fpsBox.Text = e.Fps.ToString();
            frameBox.Text = e.Frame.ToString();
            sizeBox.Text = (e.SizeKb / 1000).ToString() + " MB";
            processedBox.Text = new TimeSpan(0, 0, 0, (int)processed).ToString();
        }



        //Events
        private void OnComplete(object sender, ConversionCompleteEventArgs e)
        {
            Processing = false;
            MetroFramework.MetroMessageBox.Show(this, "Process Complete!");
            progressBar1.Value = 0;
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
                if (File.Exists(Output))
                {
                    File.Delete(Output);
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
                inputFileTxt.Text = open.FileName;
                outputFileTxt.Text = Path.GetDirectoryName(open.FileName) 
                                    + "\\"
                                    + Path.GetFileNameWithoutExtension(open.FileName)
                                    + "_CONVERTED.mp4";
                Input = open.FileName;
                Output = outputFileTxt.Text;
            }
        }
    }
}
