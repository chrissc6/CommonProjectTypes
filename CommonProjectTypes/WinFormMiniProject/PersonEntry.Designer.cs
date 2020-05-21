namespace WinFormMiniProject
{
    partial class PersonEntry
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.isActiveLabel = new System.Windows.Forms.Label();
            this.addressesListBox = new System.Windows.Forms.ListBox();
            this.addressesLabel = new System.Windows.Forms.Label();
            this.addAddressBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.personEntryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(15, 68);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(137, 29);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(158, 65);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(295, 35);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(15, 109);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(134, 29);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(158, 106);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(295, 35);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(158, 157);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isActiveCheckBox.TabIndex = 3;
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // isActiveLabel
            // 
            this.isActiveLabel.AutoSize = true;
            this.isActiveLabel.Location = new System.Drawing.Point(15, 149);
            this.isActiveLabel.Name = "isActiveLabel";
            this.isActiveLabel.Size = new System.Drawing.Size(83, 29);
            this.isActiveLabel.TabIndex = 0;
            this.isActiveLabel.Text = "Active:";
            // 
            // addressesListBox
            // 
            this.addressesListBox.FormattingEnabled = true;
            this.addressesListBox.ItemHeight = 29;
            this.addressesListBox.Location = new System.Drawing.Point(20, 230);
            this.addressesListBox.Name = "addressesListBox";
            this.addressesListBox.Size = new System.Drawing.Size(433, 207);
            this.addressesListBox.TabIndex = 4;
            this.addressesListBox.TabStop = false;
            // 
            // addressesLabel
            // 
            this.addressesLabel.AutoSize = true;
            this.addressesLabel.Location = new System.Drawing.Point(15, 198);
            this.addressesLabel.Name = "addressesLabel";
            this.addressesLabel.Size = new System.Drawing.Size(134, 29);
            this.addressesLabel.TabIndex = 0;
            this.addressesLabel.Text = "Addresses:";
            // 
            // addAddressBtn
            // 
            this.addAddressBtn.Location = new System.Drawing.Point(380, 195);
            this.addAddressBtn.Name = "addAddressBtn";
            this.addAddressBtn.Size = new System.Drawing.Size(73, 34);
            this.addAddressBtn.TabIndex = 4;
            this.addAddressBtn.Text = "Add";
            this.addAddressBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(181, 458);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(90, 36);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // personEntryLabel
            // 
            this.personEntryLabel.AutoSize = true;
            this.personEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personEntryLabel.Location = new System.Drawing.Point(20, 13);
            this.personEntryLabel.Name = "personEntryLabel";
            this.personEntryLabel.Size = new System.Drawing.Size(213, 37);
            this.personEntryLabel.TabIndex = 7;
            this.personEntryLabel.Text = "Person Entry";
            // 
            // PersonEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 504);
            this.Controls.Add(this.personEntryLabel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.addAddressBtn);
            this.Controls.Add(this.addressesListBox);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.isActiveLabel);
            this.Controls.Add(this.addressesLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "PersonEntry";
            this.Text = "Person Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.Label isActiveLabel;
        private System.Windows.Forms.ListBox addressesListBox;
        private System.Windows.Forms.Label addressesLabel;
        private System.Windows.Forms.Button addAddressBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label personEntryLabel;
    }
}

