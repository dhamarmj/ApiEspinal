using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiEspinal.Models

{
    public class Boleto
    {
        public long Idticket { get; set; }
        public string Numero_Boleto { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int Idcliente { get; set; }
        public int Idficha { get; set; }
        public int Idchofer { get; set; }
        public int Idorigen { get; set; }
        public int Iddestino { get; set; }
        public int Idasiento { get; set; }
        public int Idusuario { get; set; }
        public int Horario_turno { get; set; }
        public long Idsesion { get; set; }
        public long Referencia { get; set; }
        public string Ncf { get; set; }
        public double Total { get; set; }
        public double Efectivo { get; set; }
        public double Cheque { get; set; }
        public double Tarjeta { get; set; }
        public double Transferencia { get; set; }
        public double Deposito { get; set; }
        public double Monto_devolver { get; set; }
        public string Fecha_registro { get; set; }
        public int? Idcaja { get; set; }
        public int? Idturno { get; set; }
        public bool Nulo { get; set; }
        public string Rnc { get; set; }
        public string Nombre_rnc { get; set; }
        public double? Milla { get; set; }
        public bool? Abordado { get; set; }
        public string Qrcode { get; set; }
        public string Fecha_vencimiento_ncf { get; set; }
        public string TipoNcf { get; set; }

        //header.Idticket = Idticket;    header.Boleto = Boleto;    header.Fecha = Fecha;    header.Hora = Hora;    header.Idcliente = Idcliente;    header.Idficha = Idficha;    header.Idchofer = Idchofer;    header.Idorigen = Idorigen;    header.Iddestino = Iddestino;    header.Idasiento = Idasiento;    header.Idusuario = Idusuario;    header.Horario_turno = Horario_turno;    header.Idsesion = Idsesion;    header.Referencia = Referencia;    header.Ncf = Ncf;    header.Total = Total;    header.Efectivo = Efectivo;    header.Cheque = Cheque;    header.Tarjeta = Tarjeta;    header.Transferencia = Transferencia;    header.Deposito = Deposito;    header.Monto_devolver = Monto_devolver;    header.Fecha_registro = Fecha_registro;    header.Idcaja = Idcaja;    header.Idturno = Idturno;    header.Nulo = Nulo;    header.Rnc = Rnc;    header.Nombre_rnc = Nombre_rnc;    header.Milla = Milla;    header.Abordado = Abordado;    header.Qrcode = Qrcode;    header.Fecha_vencimiento_ncf = Fecha_vencimiento_ncf;   

    }
}