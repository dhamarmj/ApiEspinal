using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiEspinal.Models
{
    public class Terminal
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Idficha { get; set; }
        public int Idturno { get; set; }
        public double Precio { get; set; }
        public int Horario_turno { get; set; }
        public DateTime Hora_cuadre_1 { get; set; }
        public DateTime Hora_cuadre_2 { get; set; }
        public int Idruta { get; set; }
        public int IdterminalDestino { get; set; }
    }
}