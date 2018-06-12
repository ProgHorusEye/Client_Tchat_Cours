using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Tchatclient.Dao
{
    class Event
    {
        private DateTime event_date;
        private int event_id;
        private string ip_adress;
        private string login;
        private string message;
        private string message_type;
        IPAddress address;
        
        public Event (){

        }

        public string Ip_adress
        {
            get { return ip_adress; }


            set
            {
                if
                    (IPAddress.TryParse(value, out address))
                {
                    ip_adress = address.ToString();
                }

                else
                {
                    ip_adress = null;
                }
                
            }
        }
    }
}
