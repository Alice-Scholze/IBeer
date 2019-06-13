using CoreDistribuidor2.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WebAPIDistribuidor2.Controllers
{
    public class DrinkController : ApiController
    {
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(new Drink().GetDrink());
            }
            catch(Exception e)
            {
                return NotFound();
            }
        }

        // GET: api/Drink/5
        public IHttpActionResult Get(Int64 id)
        {
            try
            {
                Drink drink = new Drink().GetDrinkById(id);
                if (drink == null)
                    return NotFound();
                return Ok(drink);
            }
            catch (Exception e)
            {
                return NotFound();
            }
            
        }

        // POST: api/Drink
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Drink/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Drink/5
        public void Delete(int id)
        {
        }
    }
}
