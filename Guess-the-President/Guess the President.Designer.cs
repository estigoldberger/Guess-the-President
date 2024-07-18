namespace Match_the_President
{
    partial class Guess_the_President
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
            tblMain = new TableLayoutPanel();
            tblToolbar = new TableLayoutPanel();
            btnStart = new Button();
            btnAnswer = new Button();
            lblPoints = new Label();
            lblPt = new Label();
            lblTurns = new Label();
            lblTurn = new Label();
            tblGame = new TableLayoutPanel();
            lblNum = new Label();
            lblGuess = new Label();
            txtNum = new TextBox();
            txtGuess = new TextBox();
            lblAnswer = new Label();
            tblMain.SuspendLayout();
            tblToolbar.SuspendLayout();
            tblGame.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = Color.Cyan;
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tblMain.Controls.Add(tblToolbar, 0, 0);
            tblMain.Controls.Add(tblGame, 0, 1);
            tblMain.Controls.Add(lblAnswer, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 19.333334F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // tblToolbar
            // 
            tblToolbar.BackColor = Color.White;
            tblToolbar.ColumnCount = 6;
            tblMain.SetColumnSpan(tblToolbar, 3);
            tblToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.9679489F));
            tblToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0320511F));
            tblToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tblToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tblToolbar.Controls.Add(btnStart, 0, 0);
            tblToolbar.Controls.Add(btnAnswer, 1, 0);
            tblToolbar.Controls.Add(lblPoints, 2, 0);
            tblToolbar.Controls.Add(lblPt, 3, 0);
            tblToolbar.Controls.Add(lblTurns, 4, 0);
            tblToolbar.Controls.Add(lblTurn, 5, 0);
            tblToolbar.Dock = DockStyle.Fill;
            tblToolbar.Location = new Point(3, 3);
            tblToolbar.Name = "tblToolbar";
            tblToolbar.RowCount = 1;
            tblToolbar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblToolbar.Size = new Size(794, 50);
            tblToolbar.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStart.AutoSize = true;
            btnStart.BackColor = Color.Fuchsia;
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(57, 10);
            btnStart.Margin = new Padding(3, 10, 3, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(96, 37);
            btnStart.TabIndex = 0;
            btnStart.Text = "&Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // btnAnswer
            // 
            btnAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnswer.AutoSize = true;
            btnAnswer.BackColor = Color.Fuchsia;
            btnAnswer.Enabled = false;
            btnAnswer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnswer.Location = new Point(163, 10);
            btnAnswer.Margin = new Padding(3, 10, 3, 3);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(146, 37);
            btnAnswer.TabIndex = 1;
            btnAnswer.Text = "&Reveal Answer";
            btnAnswer.UseVisualStyleBackColor = false;
            // 
            // lblPoints
            // 
            lblPoints.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPoints.AutoSize = true;
            lblPoints.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPoints.ForeColor = Color.FromArgb(255, 128, 0);
            lblPoints.Location = new Point(431, 12);
            lblPoints.Margin = new Padding(3, 12, 3, 0);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(65, 28);
            lblPoints.TabIndex = 2;
            lblPoints.Text = "Score:";
            // 
            // lblPt
            // 
            lblPt.AutoSize = true;
            lblPt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPt.ForeColor = Color.FromArgb(255, 128, 0);
            lblPt.Location = new Point(502, 12);
            lblPt.Margin = new Padding(3, 12, 3, 0);
            lblPt.Name = "lblPt";
            lblPt.Size = new Size(0, 28);
            lblPt.TabIndex = 3;
            // 
            // lblTurns
            // 
            lblTurns.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTurns.AutoSize = true;
            lblTurns.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTurns.ForeColor = Color.FromArgb(255, 128, 0);
            lblTurns.Location = new Point(646, 12);
            lblTurns.Margin = new Padding(3, 12, 3, 0);
            lblTurns.Name = "lblTurns";
            lblTurns.Size = new Size(63, 28);
            lblTurns.TabIndex = 4;
            lblTurns.Text = "Turns:";
            // 
            // lblTurn
            // 
            lblTurn.AutoSize = true;
            lblTurn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTurn.ForeColor = Color.FromArgb(255, 128, 0);
            lblTurn.Location = new Point(715, 12);
            lblTurn.Margin = new Padding(3, 12, 3, 0);
            lblTurn.Name = "lblTurn";
            lblTurn.Size = new Size(0, 28);
            lblTurn.TabIndex = 5;
            // 
            // tblGame
            // 
            tblGame.ColumnCount = 1;
            tblGame.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblGame.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblGame.Controls.Add(lblNum, 0, 0);
            tblGame.Controls.Add(lblGuess, 0, 2);
            tblGame.Controls.Add(txtNum, 0, 1);
            tblGame.Controls.Add(txtGuess, 0, 3);
            tblGame.Dock = DockStyle.Fill;
            tblGame.Location = new Point(3, 59);
            tblGame.Name = "tblGame";
            tblGame.RowCount = 4;
            tblMain.SetRowSpan(tblGame, 2);
            tblGame.RowStyles.Add(new RowStyle(SizeType.Percent, 22.25F));
            tblGame.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5F));
            tblGame.RowStyles.Add(new RowStyle(SizeType.Percent, 9.763313F));
            tblGame.RowStyles.Add(new RowStyle(SizeType.Percent, 39.64497F));
            tblGame.Size = new Size(377, 338);
            tblGame.TabIndex = 1;
            // 
            // lblNum
            // 
            lblNum.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNum.AutoSize = true;
            lblNum.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNum.Location = new Point(60, 50);
            lblNum.Margin = new Padding(60, 5, 3, 0);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(122, 25);
            lblNum.TabIndex = 0;
            lblNum.Text = "President No.:";
            // 
            // lblGuess
            // 
            lblGuess.AutoSize = true;
            lblGuess.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblGuess.Location = new Point(60, 176);
            lblGuess.Margin = new Padding(60, 5, 3, 0);
            lblGuess.Name = "lblGuess";
            lblGuess.Size = new Size(103, 25);
            lblGuess.TabIndex = 1;
            lblGuess.Text = "Your Guess:";
            // 
            // txtNum
            // 
            txtNum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtNum.BackColor = Color.Silver;
            txtNum.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNum.ForeColor = Color.FromArgb(192, 255, 192);
            txtNum.Location = new Point(60, 85);
            txtNum.Margin = new Padding(60, 10, 3, 3);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(125, 43);
            txtNum.TabIndex = 0;
            // 
            // txtGuess
            // 
            txtGuess.BackColor = Color.Silver;
            txtGuess.Dock = DockStyle.Fill;
            txtGuess.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtGuess.ForeColor = Color.FromArgb(255, 192, 192);
            txtGuess.Location = new Point(60, 206);
            txtGuess.Margin = new Padding(60, 3, 20, 3);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(297, 38);
            txtGuess.TabIndex = 1;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnswer.Location = new Point(433, 86);
            lblAnswer.Margin = new Padding(50, 30, 3, 0);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(0, 38);
            lblAnswer.TabIndex = 2;
            // 
            // Guess_the_President
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "Guess_the_President";
            Text = "Guess_the_Presidentcs";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblToolbar.ResumeLayout(false);
            tblToolbar.PerformLayout();
            tblGame.ResumeLayout(false);
            tblGame.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblToolbar;
        private Button btnStart;
        private Button btnAnswer;
        private Label lblPoints;
        private Label lblPt;
        private Label lblTurns;
        private Label lblTurn;
        private TableLayoutPanel tblGame;
        private Label lblNum;
        private Label lblGuess;
        private TextBox txtNum;
        private TextBox txtGuess;
        private Label lblAnswer;
    }
}