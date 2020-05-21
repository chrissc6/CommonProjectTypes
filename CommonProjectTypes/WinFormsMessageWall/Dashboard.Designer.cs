namespace WinFormsMessageWall
{
    partial class Dashboard
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.messageListBoxLabel = new System.Windows.Forms.Label();
            this.addMessageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(16, 14);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(112, 29);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Message";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(134, 11);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(328, 35);
            this.messageTextBox.TabIndex = 1;
            // 
            // messageListBox
            // 
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 29;
            this.messageListBox.Location = new System.Drawing.Point(21, 113);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(441, 381);
            this.messageListBox.TabIndex = 2;
            // 
            // messageListBoxLabel
            // 
            this.messageListBoxLabel.AutoSize = true;
            this.messageListBoxLabel.Location = new System.Drawing.Point(16, 81);
            this.messageListBoxLabel.Name = "messageListBoxLabel";
            this.messageListBoxLabel.Size = new System.Drawing.Size(124, 29);
            this.messageListBoxLabel.TabIndex = 0;
            this.messageListBoxLabel.Text = "Messages";
            // 
            // addMessageBtn
            // 
            this.addMessageBtn.Location = new System.Drawing.Point(485, 11);
            this.addMessageBtn.Name = "addMessageBtn";
            this.addMessageBtn.Size = new System.Drawing.Size(68, 35);
            this.addMessageBtn.TabIndex = 3;
            this.addMessageBtn.Text = "Add";
            this.addMessageBtn.UseVisualStyleBackColor = true;
            this.addMessageBtn.Click += new System.EventHandler(this.addMessageBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(573, 507);
            this.Controls.Add(this.addMessageBtn);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messageListBoxLabel);
            this.Controls.Add(this.messageLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.Label messageListBoxLabel;
        private System.Windows.Forms.Button addMessageBtn;
    }
}

