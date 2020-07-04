using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IncomeWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ThingsController : ControllerBase
    {
        private static List<string> thingsList = new List<string> { "Banana", "Computer", "Mouse", "Mug" };

        [HttpGet]
        public List<string> GetThings()
        {
            return thingsList;
        }

        [HttpGet("{id}")]
        public string GetThingById([FromRoute] int id)
        {
            return thingsList[id - 1];
        }

        [HttpPost]
        public IActionResult AddThing([FromBody]string thing)
        {
            thingsList.Add(thing);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateThing([FromRoute] int id,[FromBody]string thing)
        {
            thingsList[id - 1] = thing;
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteThing([FromRoute] int id)
        {
            thingsList.RemoveAt(id - 1);
            return Ok();
        }
    }
}
