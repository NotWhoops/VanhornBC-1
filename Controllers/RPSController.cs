using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VanhornBC1.Services;

namespace VanhornBC1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RPSController : ControllerBase
    {
        private readonly RPSServices _rpsServices;

            public RPSController(RPSServices rpsServices)
            {
                _rpsServices = rpsServices;
            }
            [HttpGet]
            [Route("RPSServices")]
            public string RPSServices()
            {
                return _rpsServices.RPS();
            }
    }
}