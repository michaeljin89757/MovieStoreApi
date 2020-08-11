using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using MusicStoreApi.Services.ServiceInterfaces;
using System.Text.Json;
using MusicStoreApi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingersController : ControllerBase
    {
        protected private ISingerServices _singerServices;
        public SingersController(ISingerServices singerServices)
        {
            _singerServices = singerServices;
        }

        // GET: api/<SingersController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Music>>> Get()
        {
            return Ok(await _singerServices.ListAllSingers());
        }

        // GET api/<SingersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SingersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SingersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SingersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
