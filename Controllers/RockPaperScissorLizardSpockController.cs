using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Services;

namespace RockPaperScissors.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RockPaperScissorLizardSpockController : ControllerBase
    {
        private readonly RockPaperServices _rockPaperServices;
        public RockPaperScissorLizardSpockController(RockPaperServices rockPaperServices){
            _rockPaperServices = rockPaperServices;
        }
        [HttpGet]
        [Route("RockPapper")]
        public string CPUoutput(){
            return _rockPaperServices.RandomCPUChoice();
        }
        
    }
}