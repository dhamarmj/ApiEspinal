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
    [Route("api/Cliente")]
    public class ClienteController : ControllerBase
    {
        [HttpPost]
        public DataJson Get([FromBody] string Parameter)
        {
            try
            {
                DataJson val;
                ClientedbManager configdb = new ClientedbManager();
                val = configdb.Get(Parameter);
                return val;
            }
            catch
            {
                throw;
            }
        }


    }
}
