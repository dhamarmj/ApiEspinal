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
    [Route("api/TipoNcf")]
    public class TipoNcfController : ControllerBase
    {

        [HttpPost]
        public DataJson Send()
        {
            try
            {
                DataJson message = null;
                TipoNcfdbManager boletodb = new TipoNcfdbManager();
                message = boletodb.Get();


                //returnVal val = new returnVal();
                //val.code = 100;
                //val.Msg = "AllGU";
                //val.tipoNcfs = message;

                //return val;
                return message;
            }
            catch
            {
                throw;
            }
        }

        //[HttpPost]
        //[ResponseType(typeof(TipoNcf[]))]
        //public TipoNcf[] Create()
        //{
        //    try
        //    {
        //        TipoNcf[] message = null;
        //        TipoNcfdbManager boletodb = new TipoNcfdbManager();
        //        message = boletodb.Get();
        //        return message;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
    }
}
