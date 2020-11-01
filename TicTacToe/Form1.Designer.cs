namespace TicTacToe
{
    partial class Form1
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
            this.gameTitle = new System.Windows.Forms.Label();
            this.gameInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ninghtButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.seventhButton = new System.Windows.Forms.Button();
            this.sixthButton = new System.Windows.Forms.Button();
            this.fifthButton = new System.Windows.Forms.Button();
            this.fourthButton = new System.Windows.Forms.Button();
            this.thirdButton = new System.Windows.Forms.Button();
            this.secondButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.playGame = new System.Windows.Forms.Button();
            this.xWins = new System.Windows.Forms.Label();
            this.oWins = new System.Windows.Forms.Label();
            this.xScore = new System.Windows.Forms.Label();
            this.oScore = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTitle
            // 
            this.gameTitle.AllowDrop = true;
            this.gameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.Location = new System.Drawing.Point(55, 9);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(252, 60);
            this.gameTitle.TabIndex = 0;
            this.gameTitle.Text = "Tic-Tac-Toe";
            this.gameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameInfo
            // 
            this.gameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfo.ForeColor = System.Drawing.Color.Lime;
            this.gameInfo.Location = new System.Drawing.Point(23, 82);
            this.gameInfo.Name = "gameInfo";
            this.gameInfo.Size = new System.Drawing.Size(320, 26);
            this.gameInfo.TabIndex = 1;
            this.gameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.ninghtButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.eightButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.seventhButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sixthButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.fifthButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fourthButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.thirdButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.secondButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.firstButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 122);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 225);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ninghtButton
            // 
            this.ninghtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ninghtButton.Location = new System.Drawing.Point(215, 153);
            this.ninghtButton.Name = "ninghtButton";
            this.ninghtButton.Size = new System.Drawing.Size(99, 69);
            this.ninghtButton.TabIndex = 8;
            this.ninghtButton.UseVisualStyleBackColor = true;
            this.ninghtButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // eightButton
            // 
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.Location = new System.Drawing.Point(109, 153);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(99, 69);
            this.eightButton.TabIndex = 7;
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // seventhButton
            // 
            this.seventhButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seventhButton.Location = new System.Drawing.Point(3, 153);
            this.seventhButton.Name = "seventhButton";
            this.seventhButton.Size = new System.Drawing.Size(99, 69);
            this.seventhButton.TabIndex = 6;
            this.seventhButton.UseVisualStyleBackColor = true;
            this.seventhButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // sixthButton
            // 
            this.sixthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixthButton.Location = new System.Drawing.Point(215, 78);
            this.sixthButton.Name = "sixthButton";
            this.sixthButton.Size = new System.Drawing.Size(99, 69);
            this.sixthButton.TabIndex = 5;
            this.sixthButton.UseVisualStyleBackColor = true;
            this.sixthButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // fifthButton
            // 
            this.fifthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fifthButton.Location = new System.Drawing.Point(109, 78);
            this.fifthButton.Name = "fifthButton";
            this.fifthButton.Size = new System.Drawing.Size(99, 69);
            this.fifthButton.TabIndex = 4;
            this.fifthButton.UseVisualStyleBackColor = true;
            this.fifthButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // fourthButton
            // 
            this.fourthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthButton.Location = new System.Drawing.Point(3, 78);
            this.fourthButton.Name = "fourthButton";
            this.fourthButton.Size = new System.Drawing.Size(99, 69);
            this.fourthButton.TabIndex = 3;
            this.fourthButton.UseVisualStyleBackColor = true;
            this.fourthButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // thirdButton
            // 
            this.thirdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdButton.Location = new System.Drawing.Point(215, 3);
            this.thirdButton.Name = "thirdButton";
            this.thirdButton.Size = new System.Drawing.Size(99, 69);
            this.thirdButton.TabIndex = 2;
            this.thirdButton.UseVisualStyleBackColor = true;
            this.thirdButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // secondButton
            // 
            this.secondButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondButton.Location = new System.Drawing.Point(109, 3);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(99, 69);
            this.secondButton.TabIndex = 1;
            this.secondButton.UseVisualStyleBackColor = true;
            this.secondButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // firstButton
            // 
            this.firstButton.BackColor = System.Drawing.Color.Transparent;
            this.firstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstButton.Location = new System.Drawing.Point(3, 3);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(99, 69);
            this.firstButton.TabIndex = 0;
            this.firstButton.UseVisualStyleBackColor = false;
            this.firstButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // playGame
            // 
            this.playGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playGame.BackColor = System.Drawing.Color.Lime;
            this.playGame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.playGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.playGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.playGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playGame.Location = new System.Drawing.Point(125, 403);
            this.playGame.Name = "playGame";
            this.playGame.Size = new System.Drawing.Size(117, 35);
            this.playGame.TabIndex = 4;
            this.playGame.Text = "Start";
            this.playGame.UseVisualStyleBackColor = false;
            this.playGame.Click += new System.EventHandler(this.playGame_Click);
            // 
            // xWins
            // 
            this.xWins.AutoSize = true;
            this.xWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xWins.Location = new System.Drawing.Point(23, 367);
            this.xWins.Name = "xWins";
            this.xWins.Size = new System.Drawing.Size(90, 26);
            this.xWins.TabIndex = 5;
            this.xWins.Text = "X wins:";
            // 
            // oWins
            // 
            this.oWins.AutoSize = true;
            this.oWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oWins.Location = new System.Drawing.Point(235, 367);
            this.oWins.Name = "oWins";
            this.oWins.Size = new System.Drawing.Size(92, 26);
            this.oWins.TabIndex = 6;
            this.oWins.Text = "O wins:";
            // 
            // xScore
            // 
            this.xScore.AutoSize = true;
            this.xScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xScore.Location = new System.Drawing.Point(112, 367);
            this.xScore.Name = "xScore";
            this.xScore.Size = new System.Drawing.Size(0, 26);
            this.xScore.TabIndex = 7;
            // 
            // oScore
            // 
            this.oScore.AutoSize = true;
            this.oScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oScore.Location = new System.Drawing.Point(321, 367);
            this.oScore.Name = "oScore";
            this.oScore.Size = new System.Drawing.Size(0, 26);
            this.oScore.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.oScore);
            this.Controls.Add(this.xScore);
            this.Controls.Add(this.oWins);
            this.Controls.Add(this.xWins);
            this.Controls.Add(this.playGame);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gameInfo);
            this.Controls.Add(this.gameTitle);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Label gameInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button playGame;
        private System.Windows.Forms.Button ninghtButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button seventhButton;
        private System.Windows.Forms.Button sixthButton;
        private System.Windows.Forms.Button fourthButton;
        private System.Windows.Forms.Button thirdButton;
        private System.Windows.Forms.Button secondButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button fifthButton;
        private System.Windows.Forms.Label xWins;
        private System.Windows.Forms.Label oWins;
        private System.Windows.Forms.Label xScore;
        private System.Windows.Forms.Label oScore;
    }
}

