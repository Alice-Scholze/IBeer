using CoreDistributor1.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WebAPIDistributor1.Controllers
{
    public class PurchaseOrderController : ApiController
    {
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(new PurchaseOrder().GetPurchaseOrders());
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        // GET: api/PurchaseOrder/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(new PurchaseOrder().GetById(id));
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        // POST: api/PurchaseOrder
        public void Post([FromBody]PurchaseOrder purchase)
        {
            new PurchaseOrder().Insert(purchase);
        }

        // PUT: api/PurchaseOrder/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PurchaseOrder/5
        public void Delete(int id)
        {
        }
    }
}
