namespace Music_Player
{
    partial class MusicPlayerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            TopPanel = new Panel();
            pictureBox1 = new PictureBox();
            lblLogo = new Label();
            listBoxSongs = new ListBox();
            btnSelectSongs = new Button();
            lblFooter = new Label();
            axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.PaleTurquoise;
            TopPanel.Controls.Add(pictureBox1);
            TopPanel.Controls.Add(lblLogo);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(800, 36);
            TopPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(760, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(12, 7);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(126, 23);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Music Player App";
            // 
            // listBoxSongs
            // 
            listBoxSongs.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.ItemHeight = 17;
            listBoxSongs.Location = new Point(575, 51);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(213, 327);
            listBoxSongs.TabIndex = 1;
            listBoxSongs.SelectedIndexChanged += listBoxSongs_SelectedIndexChanged;
            // 
            // btnSelectSongs
            // 
            btnSelectSongs.BackColor = Color.Aquamarine;
            btnSelectSongs.FlatStyle = FlatStyle.Flat;
            btnSelectSongs.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectSongs.ForeColor = Color.Black;
            btnSelectSongs.Location = new Point(575, 384);
            btnSelectSongs.Name = "btnSelectSongs";
            btnSelectSongs.Size = new Size(213, 54);
            btnSelectSongs.TabIndex = 2;
            btnSelectSongs.Text = "Select Songs";
            btnSelectSongs.UseVisualStyleBackColor = false;
            btnSelectSongs.Click += btnSelectSongs_Click;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.BackColor = SystemColors.Control;
            lblFooter.ForeColor = SystemColors.ControlDarkDark;
            lblFooter.Location = new Point(394, 444);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(172, 15);
            lblFooter.TabIndex = 4;
            lblFooter.Text = "Developed By: Andrei Pettmant";
            // 
            // axWindowsMediaPlayer
            // 
            axWindowsMediaPlayer.Enabled = true;
            axWindowsMediaPlayer.Location = new Point(13, 51);
            axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            axWindowsMediaPlayer.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer.OcxState");
            axWindowsMediaPlayer.Size = new Size(552, 387);
            axWindowsMediaPlayer.TabIndex = 5;
            // 
            // MusicPlayerApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(axWindowsMediaPlayer);
            Controls.Add(lblFooter);
            Controls.Add(btnSelectSongs);
            Controls.Add(listBoxSongs);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MusicPlayerApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Player";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Label lblLogo;
        private PictureBox pictureBox1;
        private ListBox listBoxSongs;
        private Button btnSelectSongs;
        private Label lblFooter;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
    }
}
