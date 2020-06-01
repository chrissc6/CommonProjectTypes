using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIMiniProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private ILogger<AddressController> _logger;

        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }

        // POST api/Address
        [HttpPost]
        public void Post([FromBody] AddressModel pm)
        {
            _logger.LogInformation($"Address logged {pm}");
        }
    }
}
