using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiEspinal.Models
{
    public class DataJson
    {
        public int code { get; set; } = 100;
        public string Msg { get; set; } = "OK";
        public dynamic value = new List<TipoNcf>();
    }
}