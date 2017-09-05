using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Marbles.Models;


namespace Marbles.Controllers
{
    [Route("api/Random")] //should have work,but didn't... (has the URL when add color, but nothing is showing)
    public class RandomController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        // GET api/values
        [HttpGet("/api/random")] //now works in URL. Strange... 
        public MarblesModel Get()
        
        { 
            var Ran = new MarblesModel(); // just one marble 
            var Random = new Random();
            List<MarblesModel> AllMarbles = MarblesModel.MarblesList;

            Ran = AllMarbles[Random.Next(1, AllMarbles.Count())]; //
            return Ran;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost] 
        public IActionResult Post([FromForm] string color)
        {
            var newMarble = new MarblesModel();   
            newMarble.Color = color;

            // this inside of Marble list (Controller)
            MarblesModel.MarblesList.Add(newMarble);
            return RedirectToAction(nameof(Index));          
        }                         //nameof is something the pc knows and then it redirects to Index

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
