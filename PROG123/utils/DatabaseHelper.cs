using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PROG123.utils
{
    public class DatabaseHelper
    {
        public IConfiguration _configuration { get; }
        public DatabaseHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Helper method just to check if the connection string and the DB connection opens properly
        /// </summary>
        /// <returns>the statud of the connection </returns>
        public ConnStatusModel GetConnectionStringAndConnectionStatus()
        {
            ConnStatusModel csm = new ConnStatusModel();
            string connectionString = null;
            //try to get the connection string and open the DB
            try
            {
                connectionString = _configuration.GetConnectionString("MyConnString");
                if( String.IsNullOrWhiteSpace(connectionString))
                {
                    csm.ConnStr = "I can't read the connection string from the appsettings.json";
                }
                else
                {
                    csm.ConnStr = connectionString;
                }

                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                csm.DBConnectionStatus = "Connection String is good. The connection to the DB is Open. ";
            }
            catch (Exception exp)
            {
                csm.Exception = exp.Message +" - "+ exp.ToString();
            }
            
            return csm;
        }
    }
}
