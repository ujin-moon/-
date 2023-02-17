using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Проект
{
    class ConnectionClass
    {
        private SqlConnection SC;
        public SqlConnection ConnectBD()
        {
            string connectionString = Properties.Settings.Default.PolyclinicConnectionString;
            SC = new SqlConnection(connectionString);
            return SC;
        }
    }
}