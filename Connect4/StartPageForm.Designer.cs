namespace Connect4
{
    partial class StartPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPageForm));
            this.player1Name = new System.Windows.Forms.Label();
            this.player2Name = new System.Windows.Forms.Label();
            this.player1Txt = new System.Windows.Forms.TextBox();
            this.player2Txt = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.p1error = new System.Windows.Forms.Label();
            this.p2error = new System.Windows.Forms.Label();
            this.PlayerInfoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartUpPanel = new System.Windows.Forms.Panel();
            this.LogoImage = new System.Windows.Forms.PictureBox();
            this.humanVsComputerButton = new System.Windows.Forms.Button();
            this.computerVsHumanButton = new System.Windows.Forms.Button();
            this.humanVsHumanButton = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayerInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.StartUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // player1Name
            // 
            this.player1Name.AutoSize = true;
            this.player1Name.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Name.ForeColor = System.Drawing.SystemColors.Window;
            this.player1Name.Location = new System.Drawing.Point(459, 390);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(98, 26);
            this.player1Name.TabIndex = 0;
            this.player1Name.Text = "Player 1";
            // 
            // player2Name
            // 
            this.player2Name.AutoSize = true;
            this.player2Name.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Name.ForeColor = System.Drawing.SystemColors.Window;
            this.player2Name.Location = new System.Drawing.Point(459, 475);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(98, 26);
            this.player2Name.TabIndex = 1;
            this.player2Name.Text = "Player 2";
            this.player2Name.Visible = false;
            // 
            // player1Txt
            // 
            this.player1Txt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Txt.Location = new System.Drawing.Point(609, 387);
            this.player1Txt.Name = "player1Txt";
            this.player1Txt.Size = new System.Drawing.Size(310, 35);
            this.player1Txt.TabIndex = 2;
            // 
            // player2Txt
            // 
            this.player2Txt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Txt.Location = new System.Drawing.Point(609, 472);
            this.player2Txt.Name = "player2Txt";
            this.player2Txt.Size = new System.Drawing.Size(310, 35);
            this.player2Txt.TabIndex = 3;
            this.player2Txt.Visible = false;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(987, 369);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(210, 65);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // p1error
            // 
            this.p1error.AutoSize = true;
            this.p1error.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1error.ForeColor = System.Drawing.Color.Red;
            this.p1error.Location = new System.Drawing.Point(605, 353);
            this.p1error.Name = "p1error";
            this.p1error.Size = new System.Drawing.Size(158, 23);
            this.p1error.TabIndex = 5;
            this.p1error.Text = "Please enter name";
            this.p1error.Visible = false;
            // 
            // p2error
            // 
            this.p2error.AutoSize = true;
            this.p2error.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2error.ForeColor = System.Drawing.Color.Red;
            this.p2error.Location = new System.Drawing.Point(605, 442);
            this.p2error.Name = "p2error";
            this.p2error.Size = new System.Drawing.Size(158, 23);
            this.p2error.TabIndex = 6;
            this.p2error.Text = "Please enter name";
            this.p2error.Visible = false;
            // 
            // PlayerInfoPanel
            // 
            this.PlayerInfoPanel.BackColor = System.Drawing.SystemColors.WindowText;
            this.PlayerInfoPanel.Controls.Add(this.pictureBox1);
            this.PlayerInfoPanel.Controls.Add(this.startBtn);
            this.PlayerInfoPanel.Controls.Add(this.p2error);
            this.PlayerInfoPanel.Controls.Add(this.player1Name);
            this.PlayerInfoPanel.Controls.Add(this.p1error);
            this.PlayerInfoPanel.Controls.Add(this.player2Name);
            this.PlayerInfoPanel.Controls.Add(this.player1Txt);
            this.PlayerInfoPanel.Controls.Add(this.player2Txt);
            this.PlayerInfoPanel.Location = new System.Drawing.Point(0, 43);
            this.PlayerInfoPanel.Name = "PlayerInfoPanel";
            this.PlayerInfoPanel.Size = new System.Drawing.Size(1560, 940);
            this.PlayerInfoPanel.TabIndex = 7;
            this.PlayerInfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayerInfoPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(926, 216);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1560, 40);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(111, 38);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.difficultyToolStripMenuItem.Text = "Difficulty";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Checked = true;
            this.easyToolStripMenuItem.CheckOnClick = true;
            this.easyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.easyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.CheckOnClick = true;
            this.mediumToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.CheckOnClick = true;
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // StartUpPanel
            // 
            this.StartUpPanel.BackColor = System.Drawing.SystemColors.WindowText;
            this.StartUpPanel.Controls.Add(this.LogoImage);
            this.StartUpPanel.Controls.Add(this.humanVsComputerButton);
            this.StartUpPanel.Controls.Add(this.computerVsHumanButton);
            this.StartUpPanel.Controls.Add(this.humanVsHumanButton);
            this.StartUpPanel.Location = new System.Drawing.Point(0, 43);
            this.StartUpPanel.Name = "StartUpPanel";
            this.StartUpPanel.Size = new System.Drawing.Size(1557, 940);
            this.StartUpPanel.TabIndex = 8;
            // 
            // LogoImage
            // 
            this.LogoImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoImage.BackgroundImage")));
            this.LogoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LogoImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("LogoImage.InitialImage")));
            this.LogoImage.Location = new System.Drawing.Point(325, 71);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(926, 216);
            this.LogoImage.TabIndex = 4;
            this.LogoImage.TabStop = false;
            // 
            // humanVsComputerButton
            // 
            this.humanVsComputerButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.humanVsComputerButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.humanVsComputerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humanVsComputerButton.Location = new System.Drawing.Point(511, 507);
            this.humanVsComputerButton.Name = "humanVsComputerButton";
            this.humanVsComputerButton.Size = new System.Drawing.Size(534, 86);
            this.humanVsComputerButton.TabIndex = 3;
            this.humanVsComputerButton.Text = "Human Vs. Computer";
            this.humanVsComputerButton.UseVisualStyleBackColor = true;
            this.humanVsComputerButton.Click += new System.EventHandler(this.humanVsComputerButton_Click);
            // 
            // computerVsHumanButton
            // 
            this.computerVsHumanButton.FlatAppearance.BorderSize = 2;
            this.computerVsHumanButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.computerVsHumanButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.computerVsHumanButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.computerVsHumanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerVsHumanButton.Location = new System.Drawing.Point(511, 615);
            this.computerVsHumanButton.Name = "computerVsHumanButton";
            this.computerVsHumanButton.Size = new System.Drawing.Size(534, 86);
            this.computerVsHumanButton.TabIndex = 2;
            this.computerVsHumanButton.Text = "Computer Vs. Human";
            this.computerVsHumanButton.UseVisualStyleBackColor = true;
            this.computerVsHumanButton.Click += new System.EventHandler(this.computerVsHumanButton_Click);
            // 
            // humanVsHumanButton
            // 
            this.humanVsHumanButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.humanVsHumanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humanVsHumanButton.Location = new System.Drawing.Point(511, 399);
            this.humanVsHumanButton.Name = "humanVsHumanButton";
            this.humanVsHumanButton.Size = new System.Drawing.Size(534, 86);
            this.humanVsHumanButton.TabIndex = 1;
            this.humanVsHumanButton.Text = "Human Vs. Human";
            this.humanVsHumanButton.UseVisualStyleBackColor = true;
            this.humanVsHumanButton.Click += new System.EventHandler(this.humanVsHumanButton_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // StartPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1560, 983);
            this.Controls.Add(this.StartUpPanel);
            this.Controls.Add(this.PlayerInfoPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartPageForm";
            this.Text = "Form1";
            this.PlayerInfoPanel.ResumeLayout(false);
            this.PlayerInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StartUpPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1Name;
        private System.Windows.Forms.Label player2Name;
        private System.Windows.Forms.TextBox player1Txt;
        private System.Windows.Forms.TextBox player2Txt;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label p1error;
        private System.Windows.Forms.Label p2error;
        private System.Windows.Forms.Panel PlayerInfoPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.Panel StartUpPanel;
        private System.Windows.Forms.Button humanVsComputerButton;
        private System.Windows.Forms.Button computerVsHumanButton;
        private System.Windows.Forms.Button humanVsHumanButton;
        private System.Windows.Forms.PictureBox LogoImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
    }
}

