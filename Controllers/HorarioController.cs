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
    [Route("api/Horario")]
    public class HorarioController : ControllerBase
    {
        [HttpPost]
        public DataJson Create(int id)
        {
            try
            {
                DataJson message = null;
                HorariodbManager boletodb = new HorariodbManager();
                message = boletodb.GetHorario(id);
                return message;
            }
            catch
            {
                throw;
            }
        }

    }
}
