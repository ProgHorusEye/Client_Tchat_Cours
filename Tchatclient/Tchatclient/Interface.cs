using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleChatClient;
using SimpleChatFrameManager;
using System.Net;
using Tchatclient.Dao;

namespace Tchatclient
{
    public partial class Interface : Form
    {
        IPAddress ipadde;//création d'une variable d'adresse ip

        public Interface()
        {
            InitializeComponent();
        }

        //string _date;
        //string _time;
        //string _pseudo;
        //string _message;
        int taillemaxw = 995;
        int tailleminw = 796;
        //int taillemaxh = 460;
        //int tailleminh = 1000;

        ChatConnect demarre = new ChatConnect();

        string serveur = string.Empty;
        string based = string.Empty;
        string id = string.Empty;
        string mdp = string.Empty;
        


        //Tchatclient.Dao.DBConnection lance = new Tchatclient.Dao.DBConnection("CRM-UC-3616\\sqlexpress", "dlcdi_chat", "chatServer", "Cdi1234");

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            IPText.Enabled = true;
            PortcomText.Enabled = true;
            Login.Enabled = true;
            password.Enabled = true;
            messageenvoi.Enabled = false;
            listemess.BackColor = Color.Crimson;
            ipadde = IPAddress.Parse(IPText.Text.ToString());//récupération de l'adresse ip du serveur
            

            Interface.ActiveForm.Size = new System.Drawing.Size(796, 460);
            Interface.ActiveForm.Width = tailleminw;
            Interface.ActiveForm.Height = tailleminw;
            
        }

        /// <summary>
        /// Lancement au clique du bouton de connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 




        
        private void Connectbut_Click(object sender, EventArgs e)
        {

            string login = Login.Text;
            string port = PortcomText.Text;
            string pass = password.Text;
            IPAddress ip = ipadde;
            demarre.Connect(login,pass,port,ip);
            
            if (SimpleChatClient.Client.connectionState)//si l'état de la connection renvoi true
            {
                timerecieve.Start();//je lance le timer de réception
                IPText.Enabled = false;
                PortcomText.Enabled = false;
                Login.Enabled = false;
                password.Enabled = false;
                messageenvoi.Enabled = true;
                messageenvoi.Focus();
                listemess.BackColor = Color.DarkSeaGreen;
            }


            serveur = adresse.Text;
            based = basebox.Text;
            id = Idbox.Text;
            mdp = passbox.Text;
            
            Tchatclient.Dao.DBConnection lance = new Tchatclient.Dao.DBConnection(serveur, based, id, mdp);
            //Tchatclient.Dao.DBConnection lance = new Tchatclient.Dao.DBConnection("CRM-UC-3616\\sqlexpress", "dlcdi_chat", "chatServer", "Cdi1234");

            lance.Open();
            

        }

        /// <summary>
        /// Envoi d'un message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Envoibutton_Click(object sender, EventArgs e)
        {
            
            if (messageenvoi.Text.ToString()!=String.Empty)//si le champs n'est pas vide            
            {

                if (messageenvoi.Text != "/users")
                {
                    demarre.Send(messageenvoi.Text);
                    messageenvoi.Focus();
                    
                }

                else
                {
                    ListeUser AfficheListe = new ListeUser();
                    AfficheListe.Show();
                    
                }
            }

            messageenvoi.Text = string.Empty;//Vide le champs de saisie
        }

        
        /// <summary>
        /// Récupération des messages en attente et colorisation du texte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Recup(object sender, EventArgs e)
        {

            byte frametest = OutilsMess.GetMessage(out string date, out string time, out string pseudo, out string message, out Dictionary<string, byte> users);
            
                
                
            


            if (frametest!=200)//s'il y a une frame à traiter
            {
                
                

                switch (frametest)
                {
                    case 10 : //message tchat

                        {



                            //FrameManager.GetFrameType(frame);
                            //FrameManager.UnwrapFrame10(frame, out _date, out _time, out _pseudo, out _message);//je traite la frame

                            //_pseudo = _pseudo.Replace("\0", "");//enlève les \0 du frame
                            //_message = _message.Replace("\0", "");//enlève les \0 du frame


                            if (pseudo != Login.Text)//si ce n'est pas mon pseudo
                            {
                                listemess.SelectionStart = listemess.TextLength;//je vais à la fin du texte présent
                                listemess.SelectionLength = date.Length;//Je récupére la longueur du texte
                                listemess.SelectionColor = Color.Black;//Je choisis la couleur d'écriture
                                listemess.AppendText(date);//j'écris la date
                                listemess.AppendText(" ");//je rajoute un espace

                                listemess.SelectionStart = listemess.TextLength;//Je repare à la fin du texte
                                listemess.SelectionLength = time.Length;
                                listemess.SelectionColor = Color.Black;
                                listemess.AppendText(time);
                                listemess.AppendText(" ");

                                listemess.SelectionStart = listemess.TextLength;
                                listemess.SelectionLength = pseudo.Length;
                                listemess.SelectionColor = Color.Red;
                                listemess.AppendText(pseudo);
                                listemess.AppendText(" : ");

                                listemess.SelectionStart = listemess.TextLength;
                                listemess.SelectionLength = message.Length;
                                listemess.SelectionColor = Color.DarkOrchid;
                                listemess.AppendText(message);
                                listemess.AppendText(" ");

                                listemess.AppendText(Environment.NewLine);
                            }


                            else

                            {
                                listemess.SelectionStart = listemess.TextLength;
                                listemess.SelectionLength = date.Length;
                                listemess.SelectionColor = Color.Black;
                                listemess.AppendText(date);
                                listemess.AppendText(" ");

                                listemess.SelectionStart = listemess.TextLength;
                                listemess.SelectionLength = time.Length;
                                listemess.SelectionColor = Color.Black;
                                listemess.AppendText(time);
                                listemess.AppendText(" ");

                                listemess.SelectionStart = listemess.TextLength;
                                listemess.SelectionLength = pseudo.Length;
                                listemess.SelectionColor = Color.Sienna;
                                listemess.AppendText(pseudo);
                                listemess.AppendText(" : ");

                                listemess.SelectionStart = listemess.TextLength;
                                listemess.SelectionLength = message.Length;
                                listemess.SelectionColor = Color.Firebrick;
                                listemess.AppendText(message);
                                listemess.AppendText(" ");

                                listemess.AppendText(Environment.NewLine);
                            }
                            //listemess.Text += sentence; 

                            listemess.SelectionStart = listemess.Text.Length;
                            listemess.ScrollToCaret();
                            break;

                        }

                    case 3://liste des utilisateurs

                        //Dictionary<string, byte> _users;



                        //FrameManager.UnwrapFrame3(frame, out _users);
                        ListUsers.Items.Clear();

                        foreach (KeyValuePair<string, byte> item in users)
                        {
                            ListUsers.Items.Add(item.Key);
                        }

                        StringBuilder box = new StringBuilder();
                        box.Append("Users Online (");
                        box.Append(ListUsers.Items.Count.ToString());
                        box.Append(") ");

                        boxtext.Text = box.ToString();

                        break;


                    default:
                        break;
                }


                


            }
        }

      




        private void Messageenvoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           
        }

        /// <summary>
        /// fermeture de la connection et de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Discobut_Click(object sender, EventArgs e)
        {
            demarre.Disconnect();

            serveur = adresse.Text;
            based = basebox.Text;
            id = Idbox.Text;
            mdp = passbox.Text;
            Tchatclient.Dao.DBConnection lance = new Tchatclient.Dao.DBConnection(serveur, based, id, mdp);
            //Tchatclient.Dao.DBConnection lance = new Tchatclient.Dao.DBConnection("CRM-UC-3616\\sqlexpress", "dlcdi_chat", "chatServer", "Cdi1234");
            lance.Close();

            listemess.BackColor = Color.Crimson;//je remet le rouge de fon de fenêtre
            connectbut.Enabled = true;
            timerecieve.Stop();//je lance le timer de réception
            IPText.Enabled = true;
            PortcomText.Enabled = true;
            Login.Enabled = true;
            password.Enabled = true;

            this.Close();//je ferme la fenêtre
        }



        private void Taillebut_Click(object sender, EventArgs e)
        {
            int largeur = Interface.ActiveForm.Width;
            //int hauteur = Interface.ActiveForm.Height;

            if (Interface.ActiveForm.Width == tailleminw)
            {
                Interface.ActiveForm.Width = taillemaxw;
                //Interface.ActiveForm.Height = taillemaxh;
            }

            else
            {
                Interface.ActiveForm.Width = tailleminw;
                //Interface.ActiveForm.Height = tailleminh;
            }

            
        }

        private void Messageenvoi_TextChanged(object sender, EventArgs e)
        {
            StringBuilder carac = new StringBuilder();
            carac.Append(messageenvoi.TextLength.ToString());
            carac.Append("/256");
            Labeltaille.Text = carac.ToString();

            if (messageenvoi.TextLength > 255)
            {
                MessageBox.Show("Le message est assez bien assez long", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Dbconnectbutton_Click(object sender, EventArgs e)
        {
            
            //lance.Open();//lance la methode open
            
        }

        private void Requetebutton_Click(object sender, EventArgs e)
        {
            //lance.Essaisql();
        }
    }
}
