using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiEspinal.Models
{
    public class Cliente
    {
        public long IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nombre_Completo { get; set; }
        public string Rnc { get; set; }
        public string Telefono { get; set; }
        public string IdNcf { get; set; }
        public string PlatinumCard { get; set; }
        public int Millas_Acumuladas { get; set; }
    }
}