namespace Connect4
{
    partial class InputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player1Txt = new System.Windows.Forms.TextBox();
            this.player2Txt = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.p1error = new System.Windows.Forms.Label();
            this.p2error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2";
            // 
            // player1Txt
            // 
            this.player1Txt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Txt.Location = new System.Drawing.Point(171, 43);
            this.player1Txt.Name = "player1Txt";
            this.player1Txt.Size = new System.Drawing.Size(310, 35);
            this.player1Txt.TabIndex = 2;
            // 
            // player2Txt
            // 
            this.player2Txt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Txt.Location = new System.Drawing.Point(171, 128);
            this.player2Txt.Name = "player2Txt";
            this.player2Txt.Size = new System.Drawing.Size(310, 35);
            this.player2Txt.TabIndex = 3;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(549, 110);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(188, 65);
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
            this.p1error.Location = new System.Drawing.Point(167, 9);
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
            this.p2error.Location = new System.Drawing.Point(167, 98);
            this.p2error.Name = "p2error";
            this.p2error.Size = new System.Drawing.Size(158, 23);
            this.p2error.TabIndex = 6;
            this.p2error.Text = "Please enter name";
            this.p2error.Visible = false;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 199);
            this.Controls.Add(this.p2error);
            this.Controls.Add(this.p1error);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.player2Txt);
            this.Controls.Add(this.player1Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox player1Txt;
        private System.Windows.Forms.TextBox player2Txt;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label p1error;
        private System.Windows.Forms.Label p2error;
    }
}

