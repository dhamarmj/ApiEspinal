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
    public class ClientedbManager
    {

        public DataJson Get(string parametro)
        {
            DataJson data = new DataJson();
            dbConection objConn = new dbConection();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();
            try
            {
                //Cliente bol = new Cliente();

                if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();


                string cmd = "select idcliente, TRIM(nombre) as nombre, TRIM(apellido) as apellido, rtrim(nombre)+' '+rtrim(apellido) as nombre_completo, rnc, telefono, idncf, platinum_card, iif(platinum_card = '', 0, dbo.fun_tra_calcular_puntos_millas (idcliente) ) as millas from tratblcliente  ";
                if (long.TryParse(parametro, out long n))
                {
                    if (parametro.Trim().Length == 10)
                        cmd += "where idcliente>1 and telefono = '" + parametro.Trim() + "'";
                    else if (parametro.Trim().Length == 8)
                        cmd += "where idcliente>1 and platinum_card = '" + parametro.Trim() + "'";
                    else if (parametro.Trim().Length == 9 || parametro.Trim().Length == 11)
                        cmd += "where idcliente>1 and rnc = '" + parametro.Trim() + "'";
                }
                else
                    cmd += "where idcliente>1 and rtrim(nombre) +' '+ RTRIM(apellido) like  ('%" + parametro.Trim() + "%')";

                SqlCommand objCommand = new SqlCommand(cmd, Conn);

                SqlDataReader _Reader = objCommand.ExecuteReader();
                var list = new List<Cliente>();
                while (_Reader.Read())
                {
                    list.Add(new Cliente
                    {
                        IdCliente = Convert.ToInt64(_Reader["idcliente"].ToString()),
                        Nombre = _Reader["nombre"].ToString(),
                        Apellido = _Reader["apellido"].ToString(),
                        Nombre_Completo = _Reader["nombre_completo"].ToString(),
                        Rnc = _Reader["rnc"].ToString(),
                        Telefono = _Reader["telefono"].ToString(),
                        IdNcf = _Reader["idncf"].ToString(),
                        PlatinumCard = _Reader["platinum_card"].ToString().Trim(),
                        Millas_Acumuladas = Convert.ToInt32(_Reader["millas"].ToString())
                    });
                }
                data.value = list;
                if (list.Count == 0)
                {
                    data.code = 404;
                    data.Msg = "NOTHING HERE";
                }
                
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