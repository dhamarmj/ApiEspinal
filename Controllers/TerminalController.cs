using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiEspinal.DbManager;
using ApiEspinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiEspinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerminalController : ControllerBase
    {
        private readonly ILogger<TerminalController> _logger;

        public TerminalController(ILogger<TerminalController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public DataJson Post()
        {
            int Id = 1;
            try
            {
                DataJson val = null;
                TerminalbdManager configdb = new TerminalbdManager();
                val = configdb.Get(Id);
                return val;
            }
            catch
            {
                throw;
            }
        }

    }
}
