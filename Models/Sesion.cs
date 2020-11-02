using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiEspinal.Models
{
    public class Sesion
    {
        public int Idusuario { get; set; }
        public string NombreDispositivo { get; set; }
        public string IpDispositivo { get; set; }
        public int Idterminal { get; set; }
    }
}