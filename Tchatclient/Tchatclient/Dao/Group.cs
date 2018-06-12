using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tchatclient.Dao
{
    class Group
    {

        /// <summary>
        /// Accesseur en read-only
        /// </summary>
        public int Group_id

        {
            get;
            protected set;
        }

        private uint group_level;
        protected string group_name;
        
        

        public Group()
        {

        }

        public string Group_name

        {

            get { return group_name; }

            set
            {
                group_name = (value.Length <=16) ? value : "guest";
            }
        }

        public uint Group_level

        {

            get
            {
                return group_level;
            }

            set

            {
                group_level = value;
            }
        }

    }
}
