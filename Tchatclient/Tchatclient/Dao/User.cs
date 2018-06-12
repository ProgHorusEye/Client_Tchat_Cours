using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Net.Mail;


namespace Tchatclient.Dao
{
    class User
    {
        private const string SALT = "!¨$£%";

        private DateTime birthday;

        private string email;

        private char gender;

        private int group_id;

        private string login;

        private string passwd;

        private DateTime registered;

        private Group user_group;

        //var temp;

        private string security_token;

        public DateTime Birthday
        {
            get { return birthday; }


            
            set
            {
                int age = DateTime.Now.Year - value.Year;

                if (
                    (DateTime.Now.Month < value.Month) ||
                    ((DateTime.Now.Month == value.Month) && (DateTime.Now.Day < value.Day))
                )
                {
                    age--;
                }

                if (age >= 18)
                {
                    birthday = value;
                }
            }
        }

        public string Email
        {
            get {return email; }

            set

            {
                //if (
                //    (value.Length<255) 
                //    && Regex.IsMatch(value, @"^[^\W][a - zA - Z0 - 9_] + (\.[a - zA - Z0 - 9_] +) *\@[a-zA-Z0-9_]+(\.[a-zA-Z0-9_]+)*\.[a-zA-Z]{2,4}$/ ")
                //    && 
                //    )
                //{
                // email = value;
                //}

                try
 
                {
                    MailAddress temp = new MailAddress(value);
                    email = temp.Address;
                }

                catch
                {
                    email = null;
                }
            }


        }


        public char Gender
        {
            get { return gender; }

            set
            {
                value = Char.ToUpper(value);
                //if ((value == 'M') || (value == 'F'))
                //{
                //    gender = value;
                //}

                gender = (value == 'M') || (value == 'F') ? value : 'M';

            }
        }

        public int Group_id { get => group_id; set => group_id = value; }

        public string Login
        {

            get { return login; }

            set
            {
                value = value.Replace(@"\s", "_");

                if (
                        value.Length >= 3
                    && value.Length <= 16
                    && !Regex.IsMatch(value, @"[^a-zA-Z0-9_]")
                    )

                {
                    login = value;
                }

                else
                {
                    login = null;
                }
            }
            
        }




        public string Passwd
        {

            get { return passwd; }
            set
            {

                if ((value.Length >= 8) 
                    //&& (Regex.IsMatch(value, @"^.^(?=.{7,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).*$/"))
                    && (Regex.IsMatch(value, @"[0-9]"))
                    && (Regex.IsMatch(value, @"[A-Z]"))
                    && (Regex.IsMatch(value, @"[a-z]"))

                    )

                {
                    StringBuilder sb = new StringBuilder();
                    SHA512 _hash = System.Security.Cryptography.SHA512Managed.Create();
                    byte[] inputTmp = _hash.ComputeHash(Encoding.UTF8.GetBytes(SALT + value + SALT));

                    foreach (byte b in inputTmp)
                    {
                        sb.Append(b.ToString("x2"));
                    }

                    passwd = sb.ToString();
                }
            }
        }

        public DateTime Registered { get => registered; }

        internal Group User_group { get => user_group; set => user_group = value; }


        public User()
        {

        }

        public bool isValid()
        {
            return ((login != null));

        }

        
    }
}
