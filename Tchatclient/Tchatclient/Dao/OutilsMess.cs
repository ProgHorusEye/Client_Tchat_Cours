using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleChatClient;
using SimpleChatFrameManager;
using System.Net;

namespace Tchatclient.Dao
{
    public class OutilsMess
    {
        static public byte GetMessage (out string _date, out string _time, out string _pseudo, out string _message, out Dictionary <string,byte> _users)

        {
            _date = string.Empty;
            _time = string.Empty;
            _pseudo = string.Empty;
            _message = string.Empty;
            _users = null;


            //byte[] frame;//variable du tableau de byte



                if (Client.GetFrame(out byte[] frame))//s'il y a une frame à traiter
                {
                    byte frametest = FrameManager.GetFrameType(frame);//récupère la type de frame

                    //Dictionary<string, byte> _users;
                    //ChatConnect.GetMessage(_date, _time, _pseudo, _message, _users);

                    switch (frametest)
                    {
                        case 10: //message tchat
                        
                                FrameManager.GetFrameType(frame);
                                FrameManager.UnwrapFrame10(frame, out _date, out _time, out _pseudo, out _message);//je traite la frame

                                _pseudo = _pseudo.Replace("\0", "");//enlève les \0 du frame
                                _message = _message.Replace("\0", "");//enlève les \0 du frame

                                return frametest;
                            

                        case 3://liste des utilisateurs
                        
                                FrameManager.UnwrapFrame3(frame, out _users);
                        

                                return frametest;


                    default:
                        return 200;
                }

                





            }
            return 200;
        }

    }
}
