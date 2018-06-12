using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace Tchatclient.Dao
{
    class DBConnection
    {
        protected SqlConnection connection;

        protected SqlConnectionStringBuilder connectionString;

        protected SqlCommand command;

        protected SqlCommandBuilder commandBuilder;

        SqlConnection oConnection;

        string strConnection;



        public DBConnection()

        {
            strConnection = "Data Source = CRM-UC-3620\\sqlexpress; " + "Initial Catalog = dlcdi_chat; " + "User ID=chatClient; " + "Password=Cdi1234 ;";
        }

        public DBConnection(string _source,string _initcat,string _userId,string _password)

        {
            connectionString = new SqlConnectionStringBuilder();
            connectionString.DataSource = _source;
            connectionString.InitialCatalog = _initcat;
            connectionString.IntegratedSecurity = false;
            connectionString.UserID=_userId;
            connectionString.Password = _password;
        }

        public ConnectionState Open()

        {
            
            try
            {
                if (connection == null)
                {
                    connection = new SqlConnection();
                    connection.ConnectionString = connectionString.ConnectionString;
                   


                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                }
                
            }

            catch (Exception e)
            {
                MessageBox.Show("L'erreur suivante a été rencontrée :" + e.Message,"Erreur de connection à la base",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
            return connection.State;
          

        }

        public ConnectionState Close()
        {
            

            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    {
                        connection.Close();
                       
                    }
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("L'erreur suivante a été rencontrée :" + e.Message, "Erreur de connection à la base", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ConnectionState.Closed;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_query"></param>
        /// <returns></returns>
        public SqlDataReader Query(string _query)

        {
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_table"></param>
        /// <returns></returns>
        public SqlDataReader FetchAll(string _table)

        {
            return null;
        }

        public void Essaisql()
        {
            
            string strrequete = "SELECT * FROM users;";
            command = new SqlCommand(strrequete);
            command.Connection = connection;
            SqlDataReader oReader = command.ExecuteReader();
            MessageBox.Show(oReader.GetName(0).ToString());
            oReader.Close();
           

        }

    }

    
}
