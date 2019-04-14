using CoreDistributor1.Entities;
using System.Collections.Generic;
using System.Web.Http;

namespace WebAPIDistributor1.Controllers
{
    public class DrinksController : ApiController
    {
        // GET: api/Drinks
        public List<Drinks> Get()
        {
            return new Drinks().GetDrinks();
        }

        // GET: api/Drinks/5
        public IHttpActionResult Get(int id)
        {
            Drinks drink = new Drinks().GetDrinksById(id);
            if (drink == null)
                return NotFound();
            return Ok(drink);
        }

        // GET: api/Drinks/Coca Cola
        public Drinks Get(string name)
        {
            return new Drinks().GetDrinksByName(name);
        }

        // POST: api/Drinks
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Drinks/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Drinks/5
        public void Delete(int id)
        {
        }
    }
}
