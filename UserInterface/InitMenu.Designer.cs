namespace UserInterface
{
    public partial class InitMenu
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
            this.player1Label = new System.Windows.Forms.Label();
            this.isHuman = new System.Windows.Forms.CheckBox();
            this.player1name = new System.Windows.Forms.TextBox();
            this.player2Name = new System.Windows.Forms.TextBox();
            this.PlayersLabel = new System.Windows.Forms.Label();
            this.boardSizeLabel = new System.Windows.Forms.Label();
            this.RowsUpAndDown = new System.Windows.Forms.NumericUpDown();
            this.rosLabel = new System.Windows.Forms.Label();
            this.colsLabel = new System.Windows.Forms.Label();
            this.ColsUpAndDown = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RowsUpAndDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColsUpAndDown)).BeginInit();
            this.SuspendLayout();
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(34, 49);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(64, 17);
            this.player1Label.TabIndex = 3;
            this.player1Label.Text = "Player 1:";
            this.player1Label.Click += new System.EventHandler(this.labelPlayerOne_Click);
            // 
            // isHuman
            // 
            this.isHuman.AccessibleName = "isHumanCheckBox";
            this.isHuman.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.isHuman.AutoSize = true;
            this.isHuman.Location = new System.Drawing.Point(39, 78);
            this.isHuman.Name = "isHuman";
            this.isHuman.Size = new System.Drawing.Size(86, 21);
            this.isHuman.TabIndex = 3;
            this.isHuman.Text = "Player 2:";
            this.isHuman.UseVisualStyleBackColor = true;
            this.isHuman.CheckedChanged += new System.EventHandler(this.checkBoxIsHuman_CheckedChanged);
            // 
            // player1name
            // 
            this.player1name.Location = new System.Drawing.Point(129, 46);
            this.player1name.MaxLength = 10;
            this.player1name.Name = "player1name";
            this.player1name.Size = new System.Drawing.Size(100, 22);
            this.player1name.TabIndex = 0;
            this.player1name.TextChanged += new System.EventHandler(this.textBoxPlayerOneName_TextChanged);
            // 
            // player2Name
            // 
            this.player2Name.Enabled = false;
            this.player2Name.Location = new System.Drawing.Point(129, 78);
            this.player2Name.MaxLength = 10;
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(100, 22);
            this.player2Name.TabIndex = 1;
            this.player2Name.Text = "[Computer]";
            this.player2Name.TextChanged += new System.EventHandler(this.textBoxPlayerTwoName_TextChanged);
            // 
            // PlayersLabel
            // 
            this.PlayersLabel.AutoSize = true;
            this.PlayersLabel.Location = new System.Drawing.Point(23, 19);
            this.PlayersLabel.Name = "PlayersLabel";
            this.PlayersLabel.Size = new System.Drawing.Size(59, 17);
            this.PlayersLabel.TabIndex = 1;
            this.PlayersLabel.Text = "Players:";
            this.PlayersLabel.Click += new System.EventHandler(this.labelPlayersHeadLine_Click_1);
            // 
            // boardSizeLabel
            // 
            this.boardSizeLabel.AutoSize = true;
            this.boardSizeLabel.Location = new System.Drawing.Point(34, 121);
            this.boardSizeLabel.Name = "boardSizeLabel";
            this.boardSizeLabel.Size = new System.Drawing.Size(81, 17);
            this.boardSizeLabel.TabIndex = 4;
            this.boardSizeLabel.Text = "Board Size:";
            // 
            // RowsUpAndDown
            // 
            this.RowsUpAndDown.Location = new System.Drawing.Point(86, 163);
            this.RowsUpAndDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.RowsUpAndDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.RowsUpAndDown.Name = "RowsUpAndDown";
            this.RowsUpAndDown.Size = new System.Drawing.Size(50, 22);
            this.RowsUpAndDown.TabIndex = 5;
            this.RowsUpAndDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.RowsUpAndDown.ValueChanged += new System.EventHandler(this.numericUpDownRow_ValueChanged);
            // 
            // rosLabel
            // 
            this.rosLabel.AutoSize = true;
            this.rosLabel.Location = new System.Drawing.Point(34, 165);
            this.rosLabel.Name = "rosLabel";
            this.rosLabel.Size = new System.Drawing.Size(46, 17);
            this.rosLabel.TabIndex = 6;
            this.rosLabel.Text = "Rows:";
            // 
            // colsLabel
            // 
            this.colsLabel.AutoSize = true;
            this.colsLabel.Location = new System.Drawing.Point(166, 165);
            this.colsLabel.Name = "colsLabel";
            this.colsLabel.Size = new System.Drawing.Size(39, 17);
            this.colsLabel.TabIndex = 7;
            this.colsLabel.Text = "Cols:";
            this.colsLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // ColsUpAndDown
            // 
            this.ColsUpAndDown.Location = new System.Drawing.Point(211, 163);
            this.ColsUpAndDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.ColsUpAndDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ColsUpAndDown.Name = "ColsUpAndDown";
            this.ColsUpAndDown.Size = new System.Drawing.Size(50, 22);
            this.ColsUpAndDown.TabIndex = 8;
            this.ColsUpAndDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ColsUpAndDown.ValueChanged += new System.EventHandler(this.numericUpDownCol_ValueChanged);
            // 
            // startButton
            // 
            this.startButton.AccessibleDescription = string.Empty;
            this.startButton.AccessibleName = string.Empty;
            this.startButton.Location = new System.Drawing.Point(52, 207);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(187, 26);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // InitMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(292, 261);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.ColsUpAndDown);
            this.Controls.Add(this.colsLabel);
            this.Controls.Add(this.rosLabel);
            this.Controls.Add(this.RowsUpAndDown);
            this.Controls.Add(this.boardSizeLabel);
            this.Controls.Add(this.PlayersLabel);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.player1name);
            this.Controls.Add(this.isHuman);
            this.Controls.Add(this.player1Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InitMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.InitMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RowsUpAndDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColsUpAndDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.CheckBox isHuman;
        private System.Windows.Forms.TextBox player1name;
        private System.Windows.Forms.TextBox player2Name;
        private System.Windows.Forms.Label PlayersLabel;
        private System.Windows.Forms.Label boardSizeLabel;
        private System.Windows.Forms.NumericUpDown RowsUpAndDown;
        private System.Windows.Forms.Label rosLabel;
        private System.Windows.Forms.Label colsLabel;
        private System.Windows.Forms.NumericUpDown ColsUpAndDown;
        private System.Windows.Forms.Button startButton;
    }
}