namespace Tchatclient
{
    partial class Interface
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.labellog = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.labelpass = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.connectbut = new System.Windows.Forms.Button();
            this.IpservLab = new System.Windows.Forms.Label();
            this.IPText = new System.Windows.Forms.TextBox();
            this.PortcomText = new System.Windows.Forms.TextBox();
            this.PortLab = new System.Windows.Forms.Label();
            this.messageenvoi = new System.Windows.Forms.TextBox();
            this.envoibutton = new System.Windows.Forms.Button();
            this.timerecieve = new System.Windows.Forms.Timer(this.components);
            this.listemess = new System.Windows.Forms.RichTextBox();
            this.discobut = new System.Windows.Forms.Button();
            this.taillebut = new System.Windows.Forms.Button();
            this.ListUsers = new System.Windows.Forms.ListBox();
            this.Labeltaille = new System.Windows.Forms.Label();
            this.boxtext = new System.Windows.Forms.GroupBox();
            this.chatLabel = new System.Windows.Forms.Label();
            this.SqlLabel = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.adresseLabel = new System.Windows.Forms.Label();
            this.basebox = new System.Windows.Forms.TextBox();
            this.BaseLabel = new System.Windows.Forms.Label();
            this.Idbox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.passbox = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.boxtext.SuspendLayout();
            this.SuspendLayout();
            // 
            // labellog
            // 
            this.labellog.AutoSize = true;
            this.labellog.BackColor = System.Drawing.Color.Black;
            this.labellog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labellog.Location = new System.Drawing.Point(9, 89);
            this.labellog.Name = "labellog";
            this.labellog.Size = new System.Drawing.Size(51, 15);
            this.labellog.TabIndex = 0;
            this.labellog.Text = "Login :";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(97, 88);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(116, 20);
            this.Login.TabIndex = 1;
            this.Login.Text = "Osiris";
            this.Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.BackColor = System.Drawing.Color.Black;
            this.labelpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelpass.Location = new System.Drawing.Point(9, 123);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(77, 15);
            this.labelpass.TabIndex = 2;
            this.labelpass.Text = "Password :";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(97, 122);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(116, 20);
            this.password.TabIndex = 3;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // connectbut
            // 
            this.connectbut.Location = new System.Drawing.Point(19, 280);
            this.connectbut.Name = "connectbut";
            this.connectbut.Size = new System.Drawing.Size(84, 23);
            this.connectbut.TabIndex = 4;
            this.connectbut.Text = "Connect";
            this.connectbut.UseVisualStyleBackColor = true;
            this.connectbut.Click += new System.EventHandler(this.Connectbut_Click);
            // 
            // IpservLab
            // 
            this.IpservLab.AutoSize = true;
            this.IpservLab.BackColor = System.Drawing.Color.Black;
            this.IpservLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IpservLab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IpservLab.Location = new System.Drawing.Point(19, 29);
            this.IpservLab.Name = "IpservLab";
            this.IpservLab.Size = new System.Drawing.Size(78, 15);
            this.IpservLab.TabIndex = 5;
            this.IpservLab.Text = "Ip serveur :";
            // 
            // IPText
            // 
            this.IPText.Location = new System.Drawing.Point(16, 57);
            this.IPText.Name = "IPText";
            this.IPText.Size = new System.Drawing.Size(105, 20);
            this.IPText.TabIndex = 6;
            this.IPText.Text = "192.168.221.5";
            this.IPText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PortcomText
            // 
            this.PortcomText.Location = new System.Drawing.Point(127, 57);
            this.PortcomText.Name = "PortcomText";
            this.PortcomText.Size = new System.Drawing.Size(75, 20);
            this.PortcomText.TabIndex = 8;
            this.PortcomText.Text = "9009";
            this.PortcomText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PortLab
            // 
            this.PortLab.AutoSize = true;
            this.PortLab.BackColor = System.Drawing.Color.Black;
            this.PortLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PortLab.Location = new System.Drawing.Point(141, 29);
            this.PortLab.Name = "PortLab";
            this.PortLab.Size = new System.Drawing.Size(41, 15);
            this.PortLab.TabIndex = 7;
            this.PortLab.Text = "Port :";
            // 
            // messageenvoi
            // 
            this.messageenvoi.Location = new System.Drawing.Point(19, 309);
            this.messageenvoi.Multiline = true;
            this.messageenvoi.Name = "messageenvoi";
            this.messageenvoi.Size = new System.Drawing.Size(756, 74);
            this.messageenvoi.TabIndex = 11;
            this.messageenvoi.TextChanged += new System.EventHandler(this.Messageenvoi_TextChanged);
            this.messageenvoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Messageenvoi_KeyPress);
            // 
            // envoibutton
            // 
            this.envoibutton.Location = new System.Drawing.Point(321, 389);
            this.envoibutton.Name = "envoibutton";
            this.envoibutton.Size = new System.Drawing.Size(117, 21);
            this.envoibutton.TabIndex = 12;
            this.envoibutton.Text = "Envoi";
            this.envoibutton.UseVisualStyleBackColor = true;
            this.envoibutton.Click += new System.EventHandler(this.Envoibutton_Click);
            // 
            // timerecieve
            // 
            this.timerecieve.Tick += new System.EventHandler(this.Recup);
            // 
            // listemess
            // 
            this.listemess.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listemess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listemess.Location = new System.Drawing.Point(220, 10);
            this.listemess.Name = "listemess";
            this.listemess.Size = new System.Drawing.Size(555, 293);
            this.listemess.TabIndex = 13;
            this.listemess.Text = "";
            // 
            // discobut
            // 
            this.discobut.Location = new System.Drawing.Point(131, 280);
            this.discobut.Name = "discobut";
            this.discobut.Size = new System.Drawing.Size(82, 23);
            this.discobut.TabIndex = 14;
            this.discobut.Text = "Disconnect";
            this.discobut.UseVisualStyleBackColor = true;
            this.discobut.Click += new System.EventHandler(this.Discobut_Click);
            // 
            // taillebut
            // 
            this.taillebut.Location = new System.Drawing.Point(751, 399);
            this.taillebut.Name = "taillebut";
            this.taillebut.Size = new System.Drawing.Size(23, 10);
            this.taillebut.TabIndex = 15;
            this.taillebut.Text = "button1";
            this.taillebut.UseVisualStyleBackColor = true;
            this.taillebut.Click += new System.EventHandler(this.Taillebut_Click);
            // 
            // ListUsers
            // 
            this.ListUsers.BackColor = System.Drawing.SystemColors.MenuText;
            this.ListUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListUsers.ForeColor = System.Drawing.SystemColors.Menu;
            this.ListUsers.FormattingEnabled = true;
            this.ListUsers.Location = new System.Drawing.Point(8, 17);
            this.ListUsers.Name = "ListUsers";
            this.ListUsers.Size = new System.Drawing.Size(178, 368);
            this.ListUsers.TabIndex = 16;
            // 
            // Labeltaille
            // 
            this.Labeltaille.AutoSize = true;
            this.Labeltaille.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Labeltaille.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Labeltaille.Location = new System.Drawing.Point(19, 396);
            this.Labeltaille.Name = "Labeltaille";
            this.Labeltaille.Size = new System.Drawing.Size(41, 13);
            this.Labeltaille.TabIndex = 17;
            this.Labeltaille.Text = "0/256";
            // 
            // boxtext
            // 
            this.boxtext.BackColor = System.Drawing.Color.Transparent;
            this.boxtext.Controls.Add(this.ListUsers);
            this.boxtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxtext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boxtext.Location = new System.Drawing.Point(781, 12);
            this.boxtext.Name = "boxtext";
            this.boxtext.Size = new System.Drawing.Size(192, 398);
            this.boxtext.TabIndex = 18;
            this.boxtext.TabStop = false;
            this.boxtext.Text = "Users Online";
            // 
            // chatLabel
            // 
            this.chatLabel.AutoSize = true;
            this.chatLabel.BackColor = System.Drawing.Color.Black;
            this.chatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chatLabel.Location = new System.Drawing.Point(75, 9);
            this.chatLabel.Name = "chatLabel";
            this.chatLabel.Size = new System.Drawing.Size(64, 15);
            this.chatLabel.TabIndex = 19;
            this.chatLabel.Text = "Info Chat";
            // 
            // SqlLabel
            // 
            this.SqlLabel.AutoSize = true;
            this.SqlLabel.BackColor = System.Drawing.Color.Black;
            this.SqlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqlLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SqlLabel.Location = new System.Drawing.Point(75, 155);
            this.SqlLabel.Name = "SqlLabel";
            this.SqlLabel.Size = new System.Drawing.Size(54, 15);
            this.SqlLabel.TabIndex = 20;
            this.SqlLabel.Text = "Info BD";
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(98, 173);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(116, 20);
            this.adresse.TabIndex = 22;
            this.adresse.Text = "CRM-UC-3616\\sqlexpress";
            this.adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.BackColor = System.Drawing.Color.Black;
            this.adresseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresseLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adresseLabel.Location = new System.Drawing.Point(10, 174);
            this.adresseLabel.Name = "adresseLabel";
            this.adresseLabel.Size = new System.Drawing.Size(70, 15);
            this.adresseLabel.TabIndex = 21;
            this.adresseLabel.Text = "Adresse : ";
            // 
            // basebox
            // 
            this.basebox.Location = new System.Drawing.Point(98, 199);
            this.basebox.Name = "basebox";
            this.basebox.Size = new System.Drawing.Size(116, 20);
            this.basebox.TabIndex = 24;
            this.basebox.Text = "dlcdi_chat";
            this.basebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BaseLabel
            // 
            this.BaseLabel.AutoSize = true;
            this.BaseLabel.BackColor = System.Drawing.Color.Black;
            this.BaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BaseLabel.Location = new System.Drawing.Point(10, 200);
            this.BaseLabel.Name = "BaseLabel";
            this.BaseLabel.Size = new System.Drawing.Size(51, 15);
            this.BaseLabel.TabIndex = 23;
            this.BaseLabel.Text = "Base : ";
            // 
            // Idbox
            // 
            this.Idbox.Location = new System.Drawing.Point(97, 225);
            this.Idbox.Name = "Idbox";
            this.Idbox.Size = new System.Drawing.Size(116, 20);
            this.Idbox.TabIndex = 26;
            this.Idbox.Text = "chatServer";
            this.Idbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.BackColor = System.Drawing.Color.Black;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IdLabel.Location = new System.Drawing.Point(9, 226);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(31, 15);
            this.IdLabel.TabIndex = 25;
            this.IdLabel.Text = "Id : ";
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(97, 251);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(116, 20);
            this.passbox.TabIndex = 28;
            this.passbox.Text = "Cdi1234";
            this.passbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.Color.Black;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pass.Location = new System.Drawing.Point(9, 252);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(76, 15);
            this.pass.TabIndex = 27;
            this.pass.Text = "password :";
            // 
            // Interface
            // 
            this.AcceptButton = this.envoibutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(780, 422);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.Idbox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.basebox);
            this.Controls.Add(this.BaseLabel);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.adresseLabel);
            this.Controls.Add(this.SqlLabel);
            this.Controls.Add(this.chatLabel);
            this.Controls.Add(this.boxtext);
            this.Controls.Add(this.Labeltaille);
            this.Controls.Add(this.taillebut);
            this.Controls.Add(this.discobut);
            this.Controls.Add(this.listemess);
            this.Controls.Add(this.envoibutton);
            this.Controls.Add(this.messageenvoi);
            this.Controls.Add(this.PortcomText);
            this.Controls.Add(this.PortLab);
            this.Controls.Add(this.IPText);
            this.Controls.Add(this.IpservLab);
            this.Controls.Add(this.connectbut);
            this.Controls.Add(this.password);
            this.Controls.Add(this.labelpass);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.labellog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1005, 460);
            this.MinimumSize = new System.Drawing.Size(796, 460);
            this.Name = "Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tchat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxtext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labellog;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button connectbut;
        private System.Windows.Forms.Label IpservLab;
        private System.Windows.Forms.TextBox IPText;
        private System.Windows.Forms.TextBox PortcomText;
        private System.Windows.Forms.Label PortLab;
        private System.Windows.Forms.TextBox messageenvoi;
        private System.Windows.Forms.Button envoibutton;
        private System.Windows.Forms.Timer timerecieve;
        private System.Windows.Forms.RichTextBox listemess;
        private System.Windows.Forms.Button discobut;
        private System.Windows.Forms.Button taillebut;
        private System.Windows.Forms.ListBox ListUsers;
        private System.Windows.Forms.Label Labeltaille;
        private System.Windows.Forms.GroupBox boxtext;
        private System.Windows.Forms.Label chatLabel;
        private System.Windows.Forms.Label SqlLabel;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label adresseLabel;
        private System.Windows.Forms.TextBox basebox;
        private System.Windows.Forms.Label BaseLabel;
        private System.Windows.Forms.TextBox Idbox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Label pass;
    }
}

