namespace MP3_Player_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button2 = new Button();
            playlistBox = new ListBox();
            btnSavePlaylist = new Button();
            btnLoadPlaylist = new Button();
            btnAddToPlaylist = new Button();
            volumeSlider = new TrackBar();
            lblCurrentTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblNowPlaying = new Label();
            removeButton = new Button();
            trackBar1 = new TrackBar();
            nextTrackButton = new Button();
            prevTrackButton = new Button();
            chkShuffle = new CheckBox();
            lblFavorite = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)volumeSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(297, 283);
            button2.Name = "button2";
            button2.Size = new Size(54, 38);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // playlistBox
            // 
            playlistBox.BackColor = SystemColors.WindowFrame;
            playlistBox.ForeColor = Color.FromArgb(224, 224, 224);
            playlistBox.FormattingEnabled = true;
            playlistBox.ItemHeight = 13;
            playlistBox.Location = new Point(487, 12);
            playlistBox.Name = "playlistBox";
            playlistBox.Size = new Size(187, 147);
            playlistBox.TabIndex = 2;
            playlistBox.SelectedIndexChanged += playlistBox_SelectedIndexChanged;
            playlistBox.DoubleClick += playlistBox_DoubleClick;
            // 
            // btnSavePlaylist
            // 
            btnSavePlaylist.BackColor = Color.Transparent;
            btnSavePlaylist.BackgroundImage = (Image)resources.GetObject("btnSavePlaylist.BackgroundImage");
            btnSavePlaylist.BackgroundImageLayout = ImageLayout.Stretch;
            btnSavePlaylist.Image = (Image)resources.GetObject("btnSavePlaylist.Image");
            btnSavePlaylist.Location = new Point(497, 165);
            btnSavePlaylist.Name = "btnSavePlaylist";
            btnSavePlaylist.Size = new Size(32, 32);
            btnSavePlaylist.TabIndex = 3;
            btnSavePlaylist.UseVisualStyleBackColor = false;
            btnSavePlaylist.Click += btnSavePlaylist_Click;
            // 
            // btnLoadPlaylist
            // 
            btnLoadPlaylist.BackColor = Color.Transparent;
            btnLoadPlaylist.BackgroundImage = (Image)resources.GetObject("btnLoadPlaylist.BackgroundImage");
            btnLoadPlaylist.BackgroundImageLayout = ImageLayout.Stretch;
            btnLoadPlaylist.Location = new Point(543, 165);
            btnLoadPlaylist.Name = "btnLoadPlaylist";
            btnLoadPlaylist.Size = new Size(32, 32);
            btnLoadPlaylist.TabIndex = 4;
            btnLoadPlaylist.UseVisualStyleBackColor = false;
            btnLoadPlaylist.Click += btnLoadPlaylist_Click;
            // 
            // btnAddToPlaylist
            // 
            btnAddToPlaylist.BackColor = Color.Transparent;
            btnAddToPlaylist.BackgroundImage = (Image)resources.GetObject("btnAddToPlaylist.BackgroundImage");
            btnAddToPlaylist.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddToPlaylist.Location = new Point(589, 165);
            btnAddToPlaylist.Name = "btnAddToPlaylist";
            btnAddToPlaylist.Size = new Size(32, 32);
            btnAddToPlaylist.TabIndex = 5;
            btnAddToPlaylist.UseVisualStyleBackColor = false;
            btnAddToPlaylist.Click += btnAddToPlaylist_Click;
            // 
            // volumeSlider
            // 
            volumeSlider.Location = new Point(562, 293);
            volumeSlider.Maximum = 100;
            volumeSlider.Name = "volumeSlider";
            volumeSlider.Size = new Size(104, 45);
            volumeSlider.TabIndex = 0;
            volumeSlider.TickFrequency = 10;
            volumeSlider.Value = 50;
            volumeSlider.Scroll += volumeSlider_Scroll;
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.AutoSize = true;
            lblCurrentTime.ForeColor = Color.FromArgb(224, 224, 224);
            lblCurrentTime.Location = new Point(532, 365);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(61, 13);
            lblCurrentTime.TabIndex = 7;
            lblCurrentTime.Text = "0:00 / 0:00";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // lblNowPlaying
            // 
            lblNowPlaying.AutoSize = true;
            lblNowPlaying.ForeColor = Color.FromArgb(224, 224, 224);
            lblNowPlaying.Location = new Point(124, 329);
            lblNowPlaying.Name = "lblNowPlaying";
            lblNowPlaying.Size = new Size(75, 13);
            lblNowPlaying.TabIndex = 8;
            lblNowPlaying.Text = "Зараз грає: - ";
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.Transparent;
            removeButton.BackgroundImage = (Image)resources.GetObject("removeButton.BackgroundImage");
            removeButton.BackgroundImageLayout = ImageLayout.Stretch;
            removeButton.Location = new Point(635, 165);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(32, 32);
            removeButton.TabIndex = 9;
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += button1_Click_1;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(124, 345);
            trackBar1.Maximum = 1000;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(402, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // nextTrackButton
            // 
            nextTrackButton.BackColor = Color.Transparent;
            nextTrackButton.BackgroundImage = (Image)resources.GetObject("nextTrackButton.BackgroundImage");
            nextTrackButton.BackgroundImageLayout = ImageLayout.Stretch;
            nextTrackButton.Location = new Point(357, 283);
            nextTrackButton.Name = "nextTrackButton";
            nextTrackButton.Size = new Size(42, 38);
            nextTrackButton.TabIndex = 11;
            nextTrackButton.UseVisualStyleBackColor = false;
            nextTrackButton.Click += nextTrackButton_Click;
            // 
            // prevTrackButton
            // 
            prevTrackButton.BackColor = Color.Transparent;
            prevTrackButton.BackgroundImage = (Image)resources.GetObject("prevTrackButton.BackgroundImage");
            prevTrackButton.BackgroundImageLayout = ImageLayout.Stretch;
            prevTrackButton.Location = new Point(249, 283);
            prevTrackButton.Name = "prevTrackButton";
            prevTrackButton.Size = new Size(42, 38);
            prevTrackButton.TabIndex = 12;
            prevTrackButton.UseVisualStyleBackColor = false;
            prevTrackButton.Click += prevTrackButton_Click;
            // 
            // chkShuffle
            // 
            chkShuffle.AutoSize = true;
            chkShuffle.ForeColor = Color.FromArgb(224, 224, 224);
            chkShuffle.Location = new Point(421, 12);
            chkShuffle.Name = "chkShuffle";
            chkShuffle.Size = new Size(60, 17);
            chkShuffle.TabIndex = 13;
            chkShuffle.Text = "Shuffle";
            chkShuffle.UseVisualStyleBackColor = true;
            chkShuffle.CheckedChanged += chkShuffle_CheckedChanged;
            // 
            // lblFavorite
            // 
            lblFavorite.AutoSize = true;
            lblFavorite.ForeColor = Color.FromArgb(224, 224, 224);
            lblFavorite.Location = new Point(12, 13);
            lblFavorite.Name = "lblFavorite";
            lblFavorite.Size = new Size(106, 13);
            lblFavorite.TabIndex = 14;
            lblFavorite.Text = "Улюблений трек: - ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(543, 297);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(661, 297);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(686, 390);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblFavorite);
            Controls.Add(chkShuffle);
            Controls.Add(prevTrackButton);
            Controls.Add(nextTrackButton);
            Controls.Add(trackBar1);
            Controls.Add(removeButton);
            Controls.Add(lblNowPlaying);
            Controls.Add(lblCurrentTime);
            Controls.Add(volumeSlider);
            Controls.Add(btnAddToPlaylist);
            Controls.Add(btnLoadPlaylist);
            Controls.Add(btnSavePlaylist);
            Controls.Add(playlistBox);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)volumeSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private ListBox playlistBox;
        private Button btnSavePlaylist;
        private Button btnLoadPlaylist;
        private Button btnAddToPlaylist;
        private TrackBar volumeSlider;
        private Label lblCurrentTime;
        private System.Windows.Forms.Timer timer1;
        private Label lblNowPlaying;
        private Button removeButton;
        private TrackBar trackBar1;
        private Button nextTrackButton;
        private Button prevTrackButton;
        private CheckBox chkShuffle;
        private Label lblFavorite;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
