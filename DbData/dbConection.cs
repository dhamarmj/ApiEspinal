using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ApiEspinal.DbData
{


    public class dbConection
    {

        private SqlConnection SqlConn = null;

        public SqlConnection GetConnection
        {
            get { return SqlConn; }
            set { SqlConn = value; }
        }

        public dbConection()
        {
            string ConnectionString = "Data Source=10.147.20.8\\Tespinal_pruebas;User ID=duke;Password=administrador;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                //Environment.GetEnvironmentVariable("DefaultConnection");
            SqlConn = new SqlConnection(ConnectionString);
        }

        //private static SqlConnection SqlConn = null;

        //public static SqlConnection GetConnection
        //{
        //    get
        //    {
        //        if (SqlConn == null)
        //            SqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);

        //        return SqlConn;
        //    }
        //    // set { SqlConn = value; }
        //}

        //public dbConection()
        //{

        //}

    }
}