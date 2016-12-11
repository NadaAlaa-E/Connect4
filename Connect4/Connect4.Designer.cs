namespace Connect4
{
    partial class Connect4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.player1Score = new System.Windows.Forms.Label();
            this.player2Score = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.turnPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Location = new System.Drawing.Point(281, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 817);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(281, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 134);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // newGameBtn
            // 
            this.newGameBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameBtn.Location = new System.Drawing.Point(33, 220);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(180, 64);
            this.newGameBtn.TabIndex = 2;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // player1Score
            // 
            this.player1Score.AutoSize = true;
            this.player1Score.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Score.Location = new System.Drawing.Point(28, 74);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(74, 26);
            this.player1Score.TabIndex = 3;
            this.player1Score.Text = "label1";
            // 
            // player2Score
            // 
            this.player2Score.AutoSize = true;
            this.player2Score.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Score.Location = new System.Drawing.Point(28, 129);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(74, 26);
            this.player2Score.TabIndex = 4;
            this.player2Score.Text = "label1";
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLabel.Location = new System.Drawing.Point(1336, 258);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(74, 26);
            this.turnLabel.TabIndex = 5;
            this.turnLabel.Text = "label1";
            // 
            // turnPanel
            // 
            this.turnPanel.Location = new System.Drawing.Point(1341, 314);
            this.turnPanel.Name = "turnPanel";
            this.turnPanel.Size = new System.Drawing.Size(160, 42);
            this.turnPanel.TabIndex = 6;
            this.turnPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.turnPanel_Paint);
            // 
            // Connect4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1560, 983);
            this.Controls.Add(this.turnPanel);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Connect4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect4";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Connect4_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Label player2Score;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Panel turnPanel;
    }
}