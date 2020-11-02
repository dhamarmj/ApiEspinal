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
    public class TerminalbdManager
    {
        public DataJson Get(int id)
        {
            //DataJson data = new DataJson();
            //dbConection objConn = new dbConection();
            ////SqlConnection Conn = objConn.GetConnection;
            ////Conn.Open();
            //try
            //{
            //    Terminal obj = null;

            //  //  if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

            //  //  SqlCommand objCommand = new SqlCommand("select idterminal, descripcion, horario_turno, idvehiculo, precio, hora_cuadre_turno_1, hora_cuadre_turno_2, idruta, idterminalDestino,  [dbo].[fun_tra_turno] () as idturno from tratblterminal where nulo =0 and idterminal = " + id, Conn);

            //  //  SqlDataReader _Reader = objCommand.ExecuteReader();
            //    while (_Reader.Read())
            //    {
            //        obj = new Terminal();
            //        obj.Id = Convert.ToInt32(_Reader["idterminal"].ToString());
            //        obj.Descripcion = _Reader["descripcion"].ToString();
            //        obj.Idficha = Convert.ToInt32(_Reader["idvehiculo"].ToString());
            //        obj.Idturno = Convert.ToInt32(_Reader["idturno"].ToString());
            //        obj.Precio = Convert.ToDouble(_Reader["precio"].ToString());
            //        obj.Horario_turno = Convert.ToInt32(_Reader["horario_turno"].ToString());
            //        obj.Hora_cuadre_1 = Convert.ToDateTime(_Reader["hora_cuadre_turno_1"].ToString());
            //        obj.Hora_cuadre_2 = Convert.ToDateTime(_Reader["hora_cuadre_turno_2"].ToString());
            //        obj.Idruta = Convert.ToInt32(_Reader["idruta"].ToString());
            //        obj.IdterminalDestino = Convert.ToInt32(_Reader["idterminalDestino"].ToString());
            //    }

            //    data.value = obj;

            //    return data;
            //}
            //catch
            //{
            //    data.code = 404;
            //    data.Msg = "NOPE";
            //    throw;
            //}
            //finally
            //{
            //    if (Conn != null)
            //    {
            //        if (Conn.State == ConnectionState.Open)
            //        {
            //            Conn.Close();
            //            Conn.Dispose();
            //        }
            //    }
            //}


            return null;
        }

        public DataJson Get()
        {
            //DataJson data = new DataJson();
            //dbConection objConn = new dbConection();
            //SqlConnection Conn = objConn.GetConnection;
            //Conn.Open();
            //try
            //{
            //    Terminal[] obj = null;

            //    if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

            //    SqlCommand objCommand = new SqlCommand("select idterminal, descripcion, horario_turno, idvehiculo, precio, hora_cuadre_turno_1, hora_cuadre_turno_2, idruta, idterminalDestino,  [dbo].[fun_tra_turno] () as idturno from tratblterminal where nulo =0 ", Conn);
            //    var list = new List<Terminal>();
            //    SqlDataReader _Reader = objCommand.ExecuteReader();
            //    while (_Reader.Read())
            //    {
            //        list.Add(new Terminal
            //        {
            //            Id = Convert.ToInt32(_Reader["idterminal"].ToString()),
            //            Descripcion = _Reader["descripcion"].ToString(),
            //            Idficha = Convert.ToInt32(_Reader["idvehiculo"].ToString()),
            //            Idturno = Convert.ToInt32(_Reader["idturno"].ToString()),
            //            Precio = Convert.ToDouble(_Reader["precio"].ToString()),
            //            Horario_turno = Convert.ToInt32(_Reader["horario_turno"].ToString()),
            //            Hora_cuadre_1 = Convert.ToDateTime(_Reader["hora_cuadre_turno_1"].ToString()),
            //            Hora_cuadre_2 = Convert.ToDateTime(_Reader["hora_cuadre_turno_2"].ToString()),
            //            Idruta = Convert.ToInt32(_Reader["idruta"].ToString()),
            //            IdterminalDestino = Convert.ToInt32(_Reader["idterminalDestino"].ToString())
            //        });
            //       // obj = list.ToArray();
            //    }


            //    data.value = list;
            //    return data;
            //   // return obj;
            //}
            //catch
            //{
            //    data.code = 404;
            //    data.Msg = "NOPE";
            //    throw;
            //}
            //finally
            //{
            //    if (Conn != null)
            //    {
            //        if (Conn.State == ConnectionState.Open)
            //        {
            //            Conn.Close();
            //            Conn.Dispose();
            //        }
            //    }
            //}

            return null;
        }
    }
}