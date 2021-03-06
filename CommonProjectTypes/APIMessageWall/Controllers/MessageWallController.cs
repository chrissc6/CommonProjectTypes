﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIMessageWall.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIMessageWall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageWallController : ControllerBase
    {
        //private ILogger<MessageWallController> _logger;
        private ILogger _logger;

        public MessageWallController(ILogger<MessageWallController> logger)
        {
            _logger = logger;
        }

        // GET: api/MessageWall?message=test&id=1
        [HttpGet]
        public IEnumerable<string> Get(string message = "", int id = 0)
        {
            List<string> output = new List<string>
            {
                "Hello World",
                "Another String"
            };

            if (string.IsNullOrWhiteSpace(message) == false)
            {
                output.Add(message);
            }

            return output;
        }

        // GET api/<MessageWallController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MessageWallController>
        [HttpPost]
        public void Post([FromBody] MessageModel msg)
        {
            _logger.LogInformation($"Message was {msg.Message}");
        }

        // PUT api/<MessageWallController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MessageWallController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
