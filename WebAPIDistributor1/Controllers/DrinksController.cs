using CoreDistributor1.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WebAPIDistributor1.Controllers
{
    public class DrinksController : ApiController
    {
        // GET: api/Drinks
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(new Drinks().GetDrinks());
            }
            catch(Exception e)
            {
                return NotFound();
            }
        }

        // GET: api/Drinks/5
        public IHttpActionResult Get(Int64 id)
        {
            try
            {
                Drinks drink = new Drinks().GetDrinksById(id);
                if (drink == null)
                    return NotFound();
                return Ok(drink);
            }
            catch (Exception e)
            {
                return NotFound();
            }
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
