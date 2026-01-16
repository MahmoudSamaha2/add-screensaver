using System;
using System.Windows.Forms;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;

namespace ScreensaverPlayer
{
    public class MainForm : Form
    {
        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;
        private VideoView _videoView;
        private string videoPath = "adq screensaver.mp4";

        public MainForm(string[] args)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            this.Load += MainForm_Load;
            this.KeyDown += (s, e) => this.Close();
            this.MouseMove += (s, e) => this.Close();
            this.MouseClick += (s, e) => this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Core.Initialize();
            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);
            _videoView = new VideoView
            {
                MediaPlayer = _mediaPlayer,
                Dock = DockStyle.Fill
            };
            this.Controls.Add(_videoView);

            var media = new Media(_libVLC, videoPath, FromType.FromPath);
            _mediaPlayer.Play(media);
            _mediaPlayer.EndReached += (s, ev) =>
            {
                // Loop video
                _mediaPlayer.Stop();
                _mediaPlayer.Play(media);
            };
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _mediaPlayer?.Dispose();
                _libVLC?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
