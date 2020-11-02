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
    public class BoletodbManager
    {

        public DataJson GetBoleto(long? id)
        {
            DataJson returnVal = new DataJson();
            dbConection objConn = new dbConection();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();
            try
            {
                Boleto bol = new Boleto();

                if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

                SqlCommand objCommand = new SqlCommand("pa_tra_ticket_impresion", Conn);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Parameters.AddWithValue("@idticket", id);
                SqlDataReader _Reader = objCommand.ExecuteReader();

                while (_Reader.Read())
                {
                    bol.Numero_Boleto = _Reader["boleto"].ToString();
                    bol.Fecha = _Reader["fecha"].ToString();
                    bol.Idcliente = Convert.ToInt32(_Reader["idcliente"].ToString());
                    bol.Idorigen = Convert.ToInt32(_Reader["idorigen"].ToString());
                    bol.Iddestino = Convert.ToInt32(_Reader["iddestino"].ToString());
                    bol.Total = Convert.ToDouble(_Reader["total"].ToString());
                    bol.Efectivo = Convert.ToDouble(_Reader["efectivo"].ToString());
                }

                returnVal.value = bol;
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

        public DataJson SaveBoleto(Boleto boleto)
        {
            DataJson data = new DataJson();
            dbConection objConn = new dbConection();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();
            try
            {
                long idboleto = -1;

                if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

                SqlCommand objCommand = new SqlCommand("pa_tra_ticket", Conn);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Parameters.AddWithValue("@cFecha", DateTime.Now.ToString("yyyyMMdd"));
                objCommand.Parameters.AddWithValue("@nIdcliente", boleto.Idcliente);
                objCommand.Parameters.AddWithValue("@nIdficha", boleto.Idficha);
                objCommand.Parameters.AddWithValue("@nIdchofer", boleto.Idchofer);
                objCommand.Parameters.AddWithValue("@nIdorigen", boleto.Idorigen);
                objCommand.Parameters.AddWithValue("@nIddestino", boleto.Iddestino);
                objCommand.Parameters.AddWithValue("@nIdusuario", boleto.Idusuario);
                objCommand.Parameters.AddWithValue("@nIdcaja", boleto.Idcaja);
                objCommand.Parameters.AddWithValue("@ncantidad_tickets", 1);
                objCommand.Parameters.AddWithValue("@nTotal", boleto.Total);
                objCommand.Parameters.AddWithValue("@nEfectivo", boleto.Efectivo);
                objCommand.Parameters.AddWithValue("@nCheque", boleto.Cheque);
                objCommand.Parameters.AddWithValue("@nTarjeta", boleto.Tarjeta);
                objCommand.Parameters.AddWithValue("@nTransferencia", boleto.Transferencia);
                objCommand.Parameters.AddWithValue("@nDepositos", boleto.Deposito);
                objCommand.Parameters.AddWithValue("@nMonto_devolver", boleto.Monto_devolver);
                objCommand.Parameters.AddWithValue("@nMilla", boleto.Milla);
                objCommand.Parameters.AddWithValue("@cTipoNCF", boleto.TipoNcf);
                objCommand.Parameters.AddWithValue("@nidsesion", boleto.Idsesion);
                objCommand.Parameters.AddWithValue("@cprograma", "API_ESPINAL");
                objCommand.Parameters.AddWithValue("@crnc", boleto.Rnc);
                objCommand.Parameters.AddWithValue("@cnombre_rnc", boleto.Nombre_rnc);
                objCommand.Parameters.AddWithValue("@cOpcion", "TICKET");
                objCommand.Parameters.AddWithValue("@ntradicional", "0");

                SqlDataReader _Reader = objCommand.ExecuteReader();

                while (_Reader.Read())
                {
                    idboleto = Convert.ToInt64(_Reader["Retorno"].ToString());
                }
                if (idboleto > -1)
                    return GetBoleto(idboleto);
                else
                    return null;
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