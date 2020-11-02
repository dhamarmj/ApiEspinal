using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiEspinal.DbManager;
using ApiEspinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EspinalAPI.Controllers
{
    [ApiController]
    [Route("api/Config")]
    public class ConfigController : ControllerBase
    {
        [HttpPost]
        [Route("/Config/Sesion")]
        public DataJson GetSesion([FromBody] Sesion sesion )
        {
            try
            {
                DataJson val;
                ConfigdbManager configdb = new ConfigdbManager();
                val = configdb.AbrirSesion(sesion.Idusuario, sesion.NombreDispositivo, sesion.IpDispositivo, sesion.Idterminal);
                return val;
            }
            catch
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Config/CerrarSesion")]
        public DataJson CerrarSesion([FromBody] long Id)
        {
            try
            {
                DataJson val;
                ConfigdbManager configdb = new ConfigdbManager();
                val = configdb.CerrarSesion(Id);
                return val;
            }
            catch
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Config/Turno")]
        public DataJson GetTurno()
        {
            try
            {
                DataJson val;
                ConfigdbManager configdb = new ConfigdbManager();
                val = configdb.GetTurno();
                return val;
            }
            catch
            {
                throw;
            }
        }

    }
}
