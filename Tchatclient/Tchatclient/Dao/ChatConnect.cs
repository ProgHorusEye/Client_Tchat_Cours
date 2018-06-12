using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleChatClient;
using SimpleChatFrameManager;
using System.Net;
using Tchatclient.Dao;

namespace Tchatclient.Dao
{
    public class ChatConnect
    {
        
        public void Connect(string _login, string _password, string _port, IPAddress _ipadresse)

        {
            Client.Init(600, 256);//longueur de trame et taille max de la pile
            string Login = _login;
            string password = _password;
            string PortCom = _port;
            IPAddress ipadde = _ipadresse;//création d'une variable d'adresse ip

            Client.EstablishConnection(ipadde, int.Parse(PortCom));//etablissement de la connexion
            byte[] frame = FrameManager.WrapFrame100(Login, password);//création d'un tableau de byte avec le login et le password
            Client.SendFrame(frame);//envoi de la frame

            string phrase = Login + " est dans la place !";//je récupére la phrase
            byte[] framewelcome = FrameManager.WrapFrame110(phrase);//je crée un tableau de byte avec ma phrase
            Client.SendFrame(framewelcome);//j'envoie la phrase au serveur
            
        }

        public void Disconnect()
        {
            Client.CloseConnection();//je ferme la connection
        }


        public void Send(string _messageenvoi)
        {
            string messageenvoi = _messageenvoi;
            string phrase = messageenvoi;//je récupére la phrase
            byte[] frame = FrameManager.WrapFrame110(phrase);//je crée un tableau de byte avec ma phrase
            Client.SendFrame(frame);//j'envoie la phrase au serveur
            
        }


        
    }
}


