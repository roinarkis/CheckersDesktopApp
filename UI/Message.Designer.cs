namespace UI
{
    partial class Message
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelIsAnotherTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(138, 334);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(150, 46);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(12, 120);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(78, 32);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "label1";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(349, 334);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 46);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelIsAnotherTurn
            // 
            this.labelIsAnotherTurn.AutoSize = true;
            this.labelIsAnotherTurn.Location = new System.Drawing.Point(12, 230);
            this.labelIsAnotherTurn.Name = "labelIsAnotherTurn";
            this.labelIsAnotherTurn.Size = new System.Drawing.Size(237, 32);
            this.labelIsAnotherTurn.TabIndex = 3;
            this.labelIsAnotherTurn.Text = "want another round?";
            this.labelIsAnotherTurn.Visible = false;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 452);
            this.Controls.Add(this.labelIsAnotherTurn);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Message";
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonOk;
        private Label labelMessage;
        private Button buttonCancel;
        private Label labelIsAnotherTurn;
    }
}