using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerTown.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BurgerTown.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        /*// GET: api/Api
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/
        
        [HttpGet]
        [Route("GetBurgers")]
        public IActionResult GetBurgers()
        {
            var burger = new Burger(){Name= "burger test", Price = 34, Vegetarian = false, Ingredient ="Beef, cheez, tomato"};

            return Json(burger);
        }
        /*// GET: api/Api/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Api
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Api/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Api/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
