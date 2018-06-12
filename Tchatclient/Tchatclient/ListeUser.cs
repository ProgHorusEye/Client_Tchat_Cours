using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tchatclient
{
    public partial class ListeUser : Form
    {
        public ListeUser()
        {
            InitializeComponent();
        }

        private void ListeUser_Load(object sender, EventArgs e)
        {
            Tchatclient.Dao.DBConnection lance = new Tchatclient.Dao.DBConnection("CRM-UC-3616\\sqlexpress", "dlcdi_chat", "chatServer", "Cdi1234");
            //MessageBox.Show(" Connection en cours");
            //lance.Essaisql();
        }

        private void addUsers_Click(object sender, EventArgs e)
        {
            Dao.User nouveau = new Dao.User();




            
                nouveau.Login = nomText.Text;
                nouveau.Passwd = passwordText.Text;
                nouveau.Email = courrielText.Text;
                nouveau.Birthday = birthdayPicker.Value; if (nouveau.Birthday == new DateTime(0001,01,01)) { MessageBox.Show("birthday erroné"); }
                nouveau.Gender = (Char)genreComboBox.SelectedItem.ToString()[0];
                

                StringBuilder messageajout = new StringBuilder();
                messageajout.Append("Login : ");
                messageajout.AppendLine(nouveau.Login);
                messageajout.Append("Courriel : ");
                messageajout.AppendLine(nouveau.Email);
                messageajout.Append("Anniversaire : ");
                messageajout.AppendLine(nouveau.Birthday.ToLongDateString());
                messageajout.Append("Genre : ");
                messageajout.Append(nouveau.Gender);

                MessageBox.Show(messageajout.ToString());
            

            //catch

            //{
            //    MessageBox.Show("Erreur de saisie");
            //}
            //}

            //else
            //{
            //    MessageBox.Show("Veuillez remplir les champs");
            //}

        }
    }
}
