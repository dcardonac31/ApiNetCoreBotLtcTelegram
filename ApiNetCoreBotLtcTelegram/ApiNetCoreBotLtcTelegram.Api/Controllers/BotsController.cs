using ApiNetCoreBotLtcTelegram.Api.DataAccess;
using ApiNetCoreBotLtcTelegram.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiNetCoreBotLtcTelegram.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BotsController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public BotsController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        // GET: api/<BotsController>
        [HttpGet]
        public IEnumerable<Bots> Get()
        {
            return _dataAccessProvider.GetBots();
        }

        // GET api/<BotsController>/5
        [HttpGet("{id}")]
        public Bots Get(int idBot)
        {
            return _dataAccessProvider.GetBot(idBot);
        }

        // POST api/<BotsController>
        [HttpPost]
        public IActionResult Post([FromBody] Bots bot)
        {
            if(ModelState.IsValid)
            {
                _dataAccessProvider.AddBot(bot);
                return Ok();
            }
            return BadRequest();
        }

        // PUT api/<BotsController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody]Bots bot)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateBot(bot);
                return Ok();
            }
            return BadRequest();
        }

        // DELETE api/<BotsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int idBot)
        {
            var data = _dataAccessProvider.GetBot(idBot);
            if(data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteBot(idBot);
            return Ok();
        }
    }
}
