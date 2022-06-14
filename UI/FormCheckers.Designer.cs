namespace UI
{
    partial class FormCheckers
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
            this.labelFirstPlayerName = new System.Windows.Forms.Label();
            this.labelSecondPlayerName = new System.Windows.Forms.Label();
            this.labelFirstPlayerPoints = new System.Windows.Forms.Label();
            this.labelSecondPlayerPoints = new System.Windows.Forms.Label();
            this.panelBoard = new System.Windows.Forms.Panel();
            this.labelWhosPlayerTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFirstPlayerName
            // 
            this.labelFirstPlayerName.AutoSize = true;
            this.labelFirstPlayerName.Location = new System.Drawing.Point(2, 9);
            this.labelFirstPlayerName.Name = "labelFirstPlayerName";
            this.labelFirstPlayerName.Size = new System.Drawing.Size(155, 32);
            this.labelFirstPlayerName.TabIndex = 0;
            this.labelFirstPlayerName.Text = "Player1Name";
            // 
            // labelSecondPlayerName
            // 
            this.labelSecondPlayerName.AutoSize = true;
            this.labelSecondPlayerName.Location = new System.Drawing.Point(100, 9);
            this.labelSecondPlayerName.Name = "labelSecondPlayerName";
            this.labelSecondPlayerName.Size = new System.Drawing.Size(155, 32);
            this.labelSecondPlayerName.TabIndex = 1;
            this.labelSecondPlayerName.Text = "Player2Name";
            // 
            // labelFirstPlayerPoints
            // 
            this.labelFirstPlayerPoints.AutoSize = true;
            this.labelFirstPlayerPoints.Location = new System.Drawing.Point(79, 9);
            this.labelFirstPlayerPoints.Name = "labelFirstPlayerPoints";
            this.labelFirstPlayerPoints.Size = new System.Drawing.Size(78, 32);
            this.labelFirstPlayerPoints.TabIndex = 2;
            this.labelFirstPlayerPoints.Text = "label3";
            // 
            // labelSecondPlayerPoints
            // 
            this.labelSecondPlayerPoints.AutoSize = true;
            this.labelSecondPlayerPoints.Location = new System.Drawing.Point(195, 9);
            this.labelSecondPlayerPoints.Name = "labelSecondPlayerPoints";
            this.labelSecondPlayerPoints.Size = new System.Drawing.Size(78, 32);
            this.labelSecondPlayerPoints.TabIndex = 3;
            this.labelSecondPlayerPoints.Text = "label4";
            // 
            // panelBoard
            // 
            this.panelBoard.Location = new System.Drawing.Point(2, 28);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(371, 346);
            this.panelBoard.TabIndex = 4;
            // 
            // labelWhosPlayerTurn
            // 
            this.labelWhosPlayerTurn.AutoSize = true;
            this.labelWhosPlayerTurn.Location = new System.Drawing.Point(511, 145);
            this.labelWhosPlayerTurn.Name = "labelWhosPlayerTurn";
            this.labelWhosPlayerTurn.Size = new System.Drawing.Size(199, 32);
            this.labelWhosPlayerTurn.TabIndex = 5;
            this.labelWhosPlayerTurn.Text = "WhichPLayerTurn";
            // 
            // FormCheckers
            // 
            this.ClientSize = new System.Drawing.Size(714, 529);
            this.Controls.Add(this.labelWhosPlayerTurn);
            this.Controls.Add(this.panelBoard);
            this.Controls.Add(this.labelSecondPlayerPoints);
            this.Controls.Add(this.labelFirstPlayerPoints);
            this.Controls.Add(this.labelFirstPlayerName);
            this.Controls.Add(this.labelSecondPlayerName);
            this.Name = "FormCheckers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private MessageBox messageBoxWrongMove;
        private Label labelFirstPlayerName;
        private Label labelSecondPlayerName;
        private Label labelFirstPlayerPoints;
        private Label labelSecondPlayerPoints;
        private Panel panelBoard;
        private Label labelWhosPlayerTurn;
    }
}