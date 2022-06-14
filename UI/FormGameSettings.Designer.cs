namespace UI
{
    partial class FormGameSettings
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
        internal FormGameSettings()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelBoardSize = new System.Windows.Forms.Label();
            this.rbBoardSize6 = new System.Windows.Forms.RadioButton();
            this.rbBoardSize8 = new System.Windows.Forms.RadioButton();
            this.rbBoardSize10 = new System.Windows.Forms.RadioButton();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.tbPlayer1Name = new System.Windows.Forms.TextBox();
            this.cbPlayer2 = new System.Windows.Forms.CheckBox();
            this.tbPlayer2Name = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBoardSize
            // 
            this.labelBoardSize.AutoSize = true;
            this.labelBoardSize.Location = new System.Drawing.Point(47, 36);
            this.labelBoardSize.Name = "labelBoardSize";
            this.labelBoardSize.Size = new System.Drawing.Size(138, 32);
            this.labelBoardSize.TabIndex = 0;
            this.labelBoardSize.Text = "Board Size :";
            // 
            // rbBoardSize6
            // 
            this.rbBoardSize6.AutoSize = true;
            this.rbBoardSize6.Location = new System.Drawing.Point(53, 88);
            this.rbBoardSize6.Name = "rbBoardSize6";
            this.rbBoardSize6.Size = new System.Drawing.Size(95, 36);
            this.rbBoardSize6.TabIndex = 1;
            this.rbBoardSize6.TabStop = true;
            this.rbBoardSize6.Text = "6 * 6";
            this.rbBoardSize6.UseVisualStyleBackColor = true;
            this.rbBoardSize6.CheckedChanged += new System.EventHandler(this.rbBoardSize6_CheckedChanged);
            // 
            // rbBoardSize8
            // 
            this.rbBoardSize8.AutoSize = true;
            this.rbBoardSize8.Location = new System.Drawing.Point(154, 88);
            this.rbBoardSize8.Name = "rbBoardSize8";
            this.rbBoardSize8.Size = new System.Drawing.Size(95, 36);
            this.rbBoardSize8.TabIndex = 2;
            this.rbBoardSize8.TabStop = true;
            this.rbBoardSize8.Text = "8 * 8";
            this.rbBoardSize8.UseVisualStyleBackColor = true;
            this.rbBoardSize8.CheckedChanged += new System.EventHandler(this.rbBoardSize8_CheckedChanged);
            // 
            // rbBoardSize10
            // 
            this.rbBoardSize10.AutoSize = true;
            this.rbBoardSize10.Location = new System.Drawing.Point(255, 88);
            this.rbBoardSize10.Name = "rbBoardSize10";
            this.rbBoardSize10.Size = new System.Drawing.Size(121, 36);
            this.rbBoardSize10.TabIndex = 3;
            this.rbBoardSize10.TabStop = true;
            this.rbBoardSize10.Text = "10 * 10";
            this.rbBoardSize10.UseVisualStyleBackColor = true;
            this.rbBoardSize10.CheckedChanged += new System.EventHandler(this.rbBoardSize10_CheckedChanged);
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Location = new System.Drawing.Point(47, 142);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(100, 32);
            this.labelPlayers.TabIndex = 4;
            this.labelPlayers.Text = "Players :";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(64, 205);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(103, 32);
            this.labelPlayer1.TabIndex = 5;
            this.labelPlayer1.Text = "Player 1:";
            // 
            // tbPlayer1Name
            // 
            this.tbPlayer1Name.Location = new System.Drawing.Point(246, 202);
            this.tbPlayer1Name.Name = "tbPlayer1Name";
            this.tbPlayer1Name.Size = new System.Drawing.Size(200, 39);
            this.tbPlayer1Name.TabIndex = 6;
            // 
            // cbPlayer2
            // 
            this.cbPlayer2.AutoSize = true;
            this.cbPlayer2.Location = new System.Drawing.Point(64, 261);
            this.cbPlayer2.Name = "cbPlayer2";
            this.cbPlayer2.Size = new System.Drawing.Size(142, 36);
            this.cbPlayer2.TabIndex = 7;
            this.cbPlayer2.Text = "Player 2 :";
            this.cbPlayer2.UseVisualStyleBackColor = true;
            this.cbPlayer2.CheckedChanged += new System.EventHandler(this.cbPlayer2_CheckedChanged);
            // 
            // tbPlayer2Name
            // 
            this.tbPlayer2Name.Enabled = false;
            this.tbPlayer2Name.Location = new System.Drawing.Point(246, 261);
            this.tbPlayer2Name.Name = "tbPlayer2Name";
            this.tbPlayer2Name.Size = new System.Drawing.Size(200, 39);
            this.tbPlayer2Name.TabIndex = 8;
            this.tbPlayer2Name.Text = "[Computer]";
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(296, 340);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(150, 46);
            this.buttonDone.TabIndex = 9;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            // 
            // FormGameSettings
            // 
            this.ClientSize = new System.Drawing.Size(589, 460);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.tbPlayer2Name);
            this.Controls.Add(this.cbPlayer2);
            this.Controls.Add(this.tbPlayer1Name);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.labelPlayers);
            this.Controls.Add(this.rbBoardSize10);
            this.Controls.Add(this.rbBoardSize8);
            this.Controls.Add(this.rbBoardSize6);
            this.Controls.Add(this.labelBoardSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGameSettings";
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.FormGameSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private RadioButton rbBoardSize6;
        private RadioButton rbBoardSize8;
        private RadioButton rbBoardSize10;
        private Label labelPlayers;
        private Label labelPlayer1;
        private TextBox tbPlayer1Name;
        private CheckBox cbPlayer2;
        private TextBox tbPlayer2Name;
        private Button buttonDone;
        private Label labelBoardSize;
        private int m_BoardSize = 6;
    

    }
}
