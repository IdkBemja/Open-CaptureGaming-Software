namespace Open_CaptureGaming_Software.app.designs
{
    partial class main
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
            main_menu = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            videoToolStripMenuItem1 = new ToolStripMenuItem();
            audioToolStripMenuItem1 = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            githubToolStripMenuItem = new ToolStripMenuItem();
            discordToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            capturevideo_box = new PictureBox();
            main_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)capturevideo_box).BeginInit();
            SuspendLayout();
            // 
            // main_menu
            // 
            main_menu.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, helpToolStripMenuItem });
            main_menu.Location = new Point(0, 0);
            main_menu.Name = "main_menu";
            main_menu.Size = new Size(800, 24);
            main_menu.TabIndex = 1;
            main_menu.Text = "main_menu";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { videoToolStripMenuItem1, audioToolStripMenuItem1 });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // videoToolStripMenuItem1
            // 
            videoToolStripMenuItem1.Name = "videoToolStripMenuItem1";
            videoToolStripMenuItem1.Size = new Size(106, 22);
            videoToolStripMenuItem1.Text = "Video";
            // 
            // audioToolStripMenuItem1
            // 
            audioToolStripMenuItem1.Name = "audioToolStripMenuItem1";
            audioToolStripMenuItem1.Size = new Size(106, 22);
            audioToolStripMenuItem1.Text = "Audio";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { githubToolStripMenuItem, discordToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // githubToolStripMenuItem
            // 
            githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            githubToolStripMenuItem.Size = new Size(114, 22);
            githubToolStripMenuItem.Text = "Github";
            githubToolStripMenuItem.Click += githubToolStripMenuItem_Click;
            // 
            // discordToolStripMenuItem
            // 
            discordToolStripMenuItem.Name = "discordToolStripMenuItem";
            discordToolStripMenuItem.Size = new Size(114, 22);
            discordToolStripMenuItem.Text = "Discord";
            discordToolStripMenuItem.Click += discordToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(114, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // capturevideo_box
            // 
            capturevideo_box.Dock = DockStyle.Fill;
            capturevideo_box.Location = new Point(0, 24);
            capturevideo_box.Name = "capturevideo_box";
            capturevideo_box.Size = new Size(800, 426);
            capturevideo_box.TabIndex = 2;
            capturevideo_box.TabStop = false;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(capturevideo_box);
            Controls.Add(main_menu);
            MainMenuStrip = main_menu;
            Name = "main";
            Text = "CG Share";
            Load += main_Load;
            Resize += main_Resize;
            FormClosed += main_closed;
            main_menu.ResumeLayout(false);
            main_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)capturevideo_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip main_menu;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem videoToolStripMenuItem1;
        private ToolStripMenuItem audioToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem githubToolStripMenuItem;
        private ToolStripMenuItem discordToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private PictureBox capturevideo_box;
    }
}