using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tchatclient.Dao
{
    class GroupManager : DBManager
    {

        protected List<Group> data;

        protected override object Map(IDataRecord _record)
        {
            return null;
        }
    

        public GroupManager()
        {

        }

        public GroupManager(DBConnection _db) : base(_db)
        {
            
        }


    }
}
