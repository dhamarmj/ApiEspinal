using ApiEspinal.DbData;
using ApiEspinal.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ApiEspinal.DbManager
{
    public class TipoNcfdbManager
    {
        public DataJson Get()
        {
            DataJson returnVal = new DataJson();
            dbConection objConn = new dbConection();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();
            try
            {
                TipoNcf[] obj = null;

                if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

                SqlCommand objCommand = new SqlCommand("select idncf, tipo, descripcion from gentblncf where idncf = 1 or idncf = 6 or idncf = 8 or idncf = 9", Conn);

                SqlDataReader _Reader = objCommand.ExecuteReader();
                var list = new List<TipoNcf>();
                while (_Reader.Read())
                {
                    list.Add(new TipoNcf
                    {
                        Id = Convert.ToInt32(_Reader["idncf"]),
                        Tipo = _Reader["tipo"].ToString(),
                        Descripcion = _Reader["descripcion"].ToString()
                    });
                    //obj = list.ToList();
                }

                
                returnVal.value = list;
                return returnVal;
            }
            catch
            {
                returnVal.code = 404;
                returnVal.Msg = "NOPE";
                throw;
            }
            finally
            {
                if (Conn != null)
                {
                    if (Conn.State == ConnectionState.Open)
                    {
                        Conn.Close();
                        Conn.Dispose();
                    }
                }
            }
        }
    }
}