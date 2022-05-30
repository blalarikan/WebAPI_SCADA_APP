using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AYEDASWEBAPP_REV0;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalogController : ControllerBase
    {
        [HttpGet("getall")]
        public ActionResult<List<AnalogValue>> GetAll()
        {
            List<string> Pathx = new List<string>()
            {
                "/ Net - E /..TestData / Sub Accum SCADA / _T1 01min Export absolute / P2",
                "/ Net - E /..TestData / Sub Accum SCADA / _T1 01min Export absolute / P1"
            };

            Analog analog = new Analog();
            return analog.Analogs(Pathx);
        }
    }
}