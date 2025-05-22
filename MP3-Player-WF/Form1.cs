using System;
using System.Windows.Forms;
using NAudio.Wave;

namespace MP3_Player_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IWavePlayer output = null;
        private AudioFileReader audioFile = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Audio Files|*.mp3;*.wav;*.aiff;*.wma";

            if (open.ShowDialog() != DialogResult.OK) return;

            DisposeAudio();

            try
            {
                audioFile = new AudioFileReader(open.FileName);
                output = new DirectSoundOut(); // або WaveOutEvent, якщо треба менше затримки
                output.Init(audioFile);
                output.Play();

                button2.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при відтворенні: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing)
                    output.Pause();
                else if (output.PlaybackState == PlaybackState.Paused)
                    output.Play();
            }
        }

        private void DisposeAudio()
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing) output.Stop();
                output.Dispose();
                output = null;
            }
            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeAudio();
        }
    }
}
