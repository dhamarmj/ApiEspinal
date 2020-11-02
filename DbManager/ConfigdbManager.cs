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
    public class ConfigdbManager
    {
        public DataJson AbrirSesion(int idusuario, string nombreDispositivo, string ipDispositivo, int idterminal)
        {
            DataJson data = new DataJson();
            dbConection objConn = new dbConection();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();
            try
            {
                long bol = 0;

                if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

                SqlCommand objCommand = new SqlCommand("pa_gen_sesion", Conn);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Parameters.AddWithValue("@nIdsesion", 0);
                objCommand.Parameters.AddWithValue("@nIdusuario", idusuario);
                objCommand.Parameters.AddWithValue("@cNombre_pc", nombreDispositivo);
                objCommand.Parameters.AddWithValue("@cNombre_database", "TEspinal");
                objCommand.Parameters.AddWithValue("@cIp_pc", ipDispositivo);
                objCommand.Parameters.AddWithValue("@nIdsucursal", idterminal);
                objCommand.Parameters.AddWithValue("@cProceso", "INSERTAR");
                objCommand.Parameters.AddWithValue("@cprograma", "DesdeTABLET");
                SqlDataReader _Reader = objCommand.ExecuteReader();

                while (_Reader.Read())
                {
                    bol = Convert.ToInt64(_Reader["Retorno"].ToString());
                }

                data.value = bol;
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

        public DataJson CerrarSesion(long idsesion)
        {
            DataJson data = new DataJson();
            dbConection objConn = new dbConection();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();
            try
            {
                long bol = 0;

                if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

                SqlCommand objCommand = new SqlCommand("pa_gen_sesion", Conn);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Parameters.AddWithValue("@nIdsesion", idsesion);
                objCommand.Parameters.AddWithValue("@nIdusuario", 0);
                objCommand.Parameters.AddWithValue("@cNombre_pc", "");
                objCommand.Parameters.AddWithValue("@cNombre_database", "TEspinal");
                objCommand.Parameters.AddWithValue("@cIp_pc", "");
                objCommand.Parameters.AddWithValue("@nIdsucursal", 0);
                objCommand.Parameters.AddWithValue("@cProceso", "MODIFICAR");
                objCommand.Parameters.AddWithValue("@cprograma", "DesdeTABLET");
                SqlDataReader _Reader = objCommand.ExecuteReader();

                while (_Reader.Read())
                {
                    bol = Convert.ToInt64(_Reader["Retorno"].ToString());
                }

                data.value = bol;
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

        public DataJson GetTurno()
        {
            DataJson data = new DataJson();
            dbConection objConn = new dbConection();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();
            try
            {
                int idturno = 0;

                if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

                SqlCommand objCommand = new SqlCommand("SELECT [dbo].[fun_tra_turno] () as idturno", Conn);

                SqlDataReader _Reader = objCommand.ExecuteReader();

                while (_Reader.Read())
                {
                    idturno = Convert.ToInt32(_Reader["idturno"].ToString());
                }
                data.value = idturno;
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