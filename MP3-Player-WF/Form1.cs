using NAudio.Wave;
using System;
using System.Drawing;
using System.Windows.Forms;

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

        private List<string> playlist = new List<string>();
        private int currentIndex = -1;

        private bool isDragging = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;

            playlist.Clear();
            playlistBox.Items.Clear();

            foreach (var line in File.ReadAllLines("lastplaylist.txt"))
            {
                if (File.Exists(line))
                {
                    playlist.Add(line);
                    playlistBox.Items.Add(Path.GetFileName(line));
                }
            }
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
                {
                    output.Pause();
                    button2.Text = "Play";
                }
                else if (output.PlaybackState == PlaybackState.Paused)
                {
                    output.Play();
                    button2.Text = "Pause";
                }
                    
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
            timer1.Stop();
            progressBar.Value = 0;
            lblCurrentTime.Text = "0:00 / 0:00";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeAudio();
        }

        private void playlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToPlaylist_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Audio Files|*.mp3;*.wav";
            open.Multiselect = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in open.FileNames)
                {
                    playlist.Add(file);
                    playlistBox.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void btnLoadPlaylist_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Playlist File|*.txt";

            if (open.ShowDialog() == DialogResult.OK)
            {
                playlist.Clear();
                playlistBox.Items.Clear();

                foreach (var line in File.ReadAllLines(open.FileName))
                {
                    if (File.Exists(line))
                    {
                        playlist.Add(line);
                        playlistBox.Items.Add(Path.GetFileName(line));
                    }
                }
                File.WriteAllLines("lastplaylist.txt", playlist);

                MessageBox.Show("Плейліст завантажено!");
            }
        }

        private void btnSavePlaylist_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Playlist File|*.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(save.FileName, playlist);
                MessageBox.Show("Плейліст збережено!");
            }
        }

        private void playlistBox_DoubleClick(object sender, EventArgs e)
        {
            if (playlistBox.SelectedIndex >= 0)
            {
                currentIndex = playlistBox.SelectedIndex;
                button2.Enabled = true;
                button2.Text = "Pause";
                PlaySelected(currentIndex);
            }
        }

        private void PlaySelected(int index)
        {
            if (index >= 0 && index < playlist.Count)
            {
                DisposeAudio();
                audioFile = new AudioFileReader(playlist[index]);
                output = new DirectSoundOut();
                output.Init(audioFile);
                output.Play();
                lblNowPlaying.Text = "Зараз грає: " + Path.GetFileName(playlist[index]);
                timer1.Start();
            }
        }

        private void volumeSlider_Scroll(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.Volume = volumeSlider.Value / 100f;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (audioFile != null && !isDragging)
            {
                TimeSpan currentTime = audioFile.CurrentTime;
                TimeSpan totalTime = audioFile.TotalTime;

                if (totalTime.TotalSeconds > 0)
                {
                    progressBar.Value = Math.Min(progressBar.Maximum,
                        (int)(currentTime.TotalSeconds / totalTime.TotalSeconds * progressBar.Maximum));
                }

                lblCurrentTime.Text = $"{FormatTime(currentTime)} / {FormatTime(totalTime)}";

                // Перевірка завершення
                if (output != null &&
                    output.PlaybackState == PlaybackState.Stopped &&
                    currentTime >= totalTime &&
                    currentIndex < playlist.Count - 1)
                {
                    currentIndex++;
                    PlaySelected(currentIndex);
                }
            }
        }

        private string FormatTime(TimeSpan time)
        {
            return string.Format("{0}:{1:D2}", (int)time.TotalMinutes, time.Seconds);
        }
        private void progressBar_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }

        private void progressBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (audioFile != null)
            {       
                double ratio = e.X / (double)progressBar.Width;
                audioFile.CurrentTime = TimeSpan.FromSeconds(audioFile.TotalTime.TotalSeconds * ratio);
            }
            isDragging = false;
        }
    }
}