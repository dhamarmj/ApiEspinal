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
    public class HorariodbManager
    {
        public DataJson GetHorario(int id)
        {
            DataJson data = new DataJson();
            dbConection objConn = new dbConection();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();
            try
            {
              //  Horario[] obj = null;

                if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

                SqlCommand objCommand = new SqlCommand("select horario_turno, descripcion from tratblhorario_detalle where idhorario =  " + id , Conn);

                SqlDataReader _Reader = objCommand.ExecuteReader();
                var list = new List<Horario>();
                while (_Reader.Read())
                {
                        list.Add(new Horario {
                            Id = Convert.ToInt32(_Reader["horario_turno"]),
                            Descripcion= _Reader["descripcion"].ToString()
                        });
                    //obj = list.ToArray();
                }

                data.value = list;
                return data;
            }
            catch
            {
                data.code = 404;
                data.Msg = "NOPE";
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