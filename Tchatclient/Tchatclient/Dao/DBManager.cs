using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Tchatclient.Dao
{
    abstract class DBManager
    {
        protected DBConnection db;
        protected List<object> data;
        protected string tableName;
        protected string tablePK;

        
        public DBManager ()
            
        {

        }

        public DBManager(DBConnection _db)
        {
            db = _db;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_record"></param>
        /// <returns></returns>
        protected abstract object Map (IDataRecord _record);
        
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_reader"></param>
        /// <returns></returns>
        protected List<T> Execute <T> (SqlDataReader _reader)
        {
        return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> FetchAll <T>()
        {

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_query"></param>
        /// <returns></returns>
        public List<T> Query <T> (string _query)
        {
            return null;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_searchPattern"></param>
        /// <returns></returns>
        public List<T> Find <T> (string _searchPattern)
        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_searchColumn"></param>
        /// <param name="_searchPattern"></param>
        /// <returns></returns>
        public List<T> Findall <T> (string _searchColumn, string _searchPattern)
        {
            return null;
        }
    }
}
