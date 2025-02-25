namespace TicTacTou
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
            btnNewGame = new Button();
            lblResultMessage = new Label();
            lblXWin = new Label();
            lblOWin = new Label();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(88, 1);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(84, 33);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "New game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += button1_Click;
            // 
            // lblResultMessage
            // 
            lblResultMessage.AutoSize = true;
            lblResultMessage.BackColor = Color.Lime;
            lblResultMessage.Location = new Point(124, 212);
            lblResultMessage.Name = "lblResultMessage";
            lblResultMessage.Size = new Size(60, 15);
            lblResultMessage.TabIndex = 1;
            lblResultMessage.Text = "WinResult";
            // 
            // lblXWin
            // 
            lblXWin.AutoSize = true;
            lblXWin.Location = new Point(220, 10);
            lblXWin.Name = "lblXWin";
            lblXWin.Size = new Size(17, 15);
            lblXWin.TabIndex = 2;
            lblXWin.Text = "X:";
            lblXWin.Click += label1_Click;
            // 
            // lblOWin
            // 
            lblOWin.AutoSize = true;
            lblOWin.Location = new Point(2, 9);
            lblOWin.Name = "lblOWin";
            lblOWin.Size = new Size(19, 15);
            lblOWin.TabIndex = 3;
            lblOWin.Text = "O:";
            lblOWin.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 236);
            Controls.Add(lblOWin);
            Controls.Add(lblXWin);
            Controls.Add(lblResultMessage);
            Controls.Add(btnNewGame);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewGame;
        private Label lblResultMessage;
        private Label lblXWin;
        private Label lblOWin;
    }
}
