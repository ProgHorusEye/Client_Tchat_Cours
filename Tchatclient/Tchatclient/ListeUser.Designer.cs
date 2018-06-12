namespace Tchatclient
{
    partial class ListeUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeUser));
            this.DataGriedUsers = new System.Windows.Forms.DataGridView();
            this.nomLabel = new System.Windows.Forms.Label();
            this.nomText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.mdpLabel = new System.Windows.Forms.Label();
            this.courrielText = new System.Windows.Forms.TextBox();
            this.courrielLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.addUsers = new System.Windows.Forms.Button();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriedUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGriedUsers
            // 
            this.DataGriedUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriedUsers.Location = new System.Drawing.Point(12, 12);
            this.DataGriedUsers.Name = "DataGriedUsers";
            this.DataGriedUsers.Size = new System.Drawing.Size(479, 223);
            this.DataGriedUsers.TabIndex = 0;
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nomLabel.Location = new System.Drawing.Point(520, 12);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(45, 15);
            this.nomLabel.TabIndex = 1;
            this.nomLabel.Text = "Nom :";
            // 
            // nomText
            // 
            this.nomText.Location = new System.Drawing.Point(622, 11);
            this.nomText.Name = "nomText";
            this.nomText.Size = new System.Drawing.Size(200, 20);
            this.nomText.TabIndex = 2;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(622, 51);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(200, 20);
            this.passwordText.TabIndex = 4;
            // 
            // mdpLabel
            // 
            this.mdpLabel.AutoSize = true;
            this.mdpLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mdpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdpLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mdpLabel.Location = new System.Drawing.Point(520, 52);
            this.mdpLabel.Name = "mdpLabel";
            this.mdpLabel.Size = new System.Drawing.Size(77, 15);
            this.mdpLabel.TabIndex = 3;
            this.mdpLabel.Text = "Password :";
            // 
            // courrielText
            // 
            this.courrielText.Location = new System.Drawing.Point(622, 89);
            this.courrielText.Name = "courrielText";
            this.courrielText.Size = new System.Drawing.Size(200, 20);
            this.courrielText.TabIndex = 6;
            // 
            // courrielLabel
            // 
            this.courrielLabel.AutoSize = true;
            this.courrielLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.courrielLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courrielLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.courrielLabel.Location = new System.Drawing.Point(520, 90);
            this.courrielLabel.Name = "courrielLabel";
            this.courrielLabel.Size = new System.Drawing.Size(66, 15);
            this.courrielLabel.TabIndex = 5;
            this.courrielLabel.Text = "Courriel :";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.birthdayLabel.Location = new System.Drawing.Point(520, 130);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(67, 15);
            this.birthdayLabel.TabIndex = 7;
            this.birthdayLabel.Text = "Birthday :";
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Location = new System.Drawing.Point(622, 126);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(200, 20);
            this.birthdayPicker.TabIndex = 8;
            // 
            // addUsers
            // 
            this.addUsers.Location = new System.Drawing.Point(685, 212);
            this.addUsers.Name = "addUsers";
            this.addUsers.Size = new System.Drawing.Size(75, 23);
            this.addUsers.TabIndex = 9;
            this.addUsers.Text = "Ajouter";
            this.addUsers.UseVisualStyleBackColor = true;
            this.addUsers.Click += new System.EventHandler(this.addUsers_Click);
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.genreLabel.Location = new System.Drawing.Point(520, 166);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(54, 15);
            this.genreLabel.TabIndex = 10;
            this.genreLabel.Text = "Genre :";
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.genreComboBox.Location = new System.Drawing.Point(622, 160);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(50, 21);
            this.genreComboBox.TabIndex = 12;
            // 
            // ListeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(845, 248);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.addUsers);
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.courrielText);
            this.Controls.Add(this.courrielLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.mdpLabel);
            this.Controls.Add(this.nomText);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.DataGriedUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(861, 286);
            this.MinimumSize = new System.Drawing.Size(512, 286);
            this.Name = "ListeUser";
            this.Text = "Liste Users";
            this.Load += new System.EventHandler(this.ListeUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGriedUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGriedUsers;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.TextBox nomText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label mdpLabel;
        private System.Windows.Forms.TextBox courrielText;
        private System.Windows.Forms.Label courrielLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.Button addUsers;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
    }
}