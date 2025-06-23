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
            ((System.ComponentModel.ISupportInitialize)volumeSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(297, 283);
            button2.Name = "button2";
            button2.Size = new Size(54, 38);
            button2.TabIndex = 1;
            button2.Text = "Play / Pause";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // playlistBox
            // 
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
            btnSavePlaylist.Location = new Point(487, 165);
            btnSavePlaylist.Name = "btnSavePlaylist";
            btnSavePlaylist.Size = new Size(187, 23);
            btnSavePlaylist.TabIndex = 3;
            btnSavePlaylist.Text = "Save";
            btnSavePlaylist.UseVisualStyleBackColor = true;
            btnSavePlaylist.Click += btnSavePlaylist_Click;
            // 
            // btnLoadPlaylist
            // 
            btnLoadPlaylist.Location = new Point(487, 194);
            btnLoadPlaylist.Name = "btnLoadPlaylist";
            btnLoadPlaylist.Size = new Size(187, 23);
            btnLoadPlaylist.TabIndex = 4;
            btnLoadPlaylist.Text = "Load";
            btnLoadPlaylist.UseVisualStyleBackColor = true;
            btnLoadPlaylist.Click += btnLoadPlaylist_Click;
            // 
            // btnAddToPlaylist
            // 
            btnAddToPlaylist.Location = new Point(487, 223);
            btnAddToPlaylist.Name = "btnAddToPlaylist";
            btnAddToPlaylist.Size = new Size(187, 23);
            btnAddToPlaylist.TabIndex = 5;
            btnAddToPlaylist.Text = "Add";
            btnAddToPlaylist.UseVisualStyleBackColor = true;
            btnAddToPlaylist.Click += btnAddToPlaylist_Click;
            // 
            // volumeSlider
            // 
            volumeSlider.Location = new Point(570, 297);
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
            lblNowPlaying.Location = new Point(124, 329);
            lblNowPlaying.Name = "lblNowPlaying";
            lblNowPlaying.Size = new Size(75, 13);
            lblNowPlaying.TabIndex = 8;
            lblNowPlaying.Text = "Зараз грає: - ";
            // 
            // removeButton
            // 
            removeButton.Location = new Point(487, 252);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(187, 23);
            removeButton.TabIndex = 9;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
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
            nextTrackButton.Location = new Point(357, 283);
            nextTrackButton.Name = "nextTrackButton";
            nextTrackButton.Size = new Size(42, 38);
            nextTrackButton.TabIndex = 11;
            nextTrackButton.Text = ">";
            nextTrackButton.UseVisualStyleBackColor = true;
            nextTrackButton.Click += nextTrackButton_Click;
            // 
            // prevTrackButton
            // 
            prevTrackButton.Location = new Point(249, 283);
            prevTrackButton.Name = "prevTrackButton";
            prevTrackButton.Size = new Size(42, 38);
            prevTrackButton.TabIndex = 12;
            prevTrackButton.Text = "<";
            prevTrackButton.UseVisualStyleBackColor = true;
            prevTrackButton.Click += prevTrackButton_Click;
            // 
            // chkShuffle
            // 
            chkShuffle.AutoSize = true;
            chkShuffle.Location = new Point(421, 12);
            chkShuffle.Name = "chkShuffle";
            chkShuffle.Size = new Size(60, 17);
            chkShuffle.TabIndex = 13;
            chkShuffle.Text = "Shuffle";
            chkShuffle.UseVisualStyleBackColor = true;
            chkShuffle.CheckedChanged += chkShuffle_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 390);
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
    }
}
