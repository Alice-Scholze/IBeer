using CoreDistributor1.Entities;
using System.Collections.Generic;
using System.Web.Http;

namespace WebAPIDistributor1.Controllers
{
    public class PurchaseOrderController : ApiController
    {
        // GET: api/PurchaseOrder
        public List<PurchaseOrder> Get()
        {
            return new PurchaseOrder().GetPurchaseOrders();
        }

        // GET: api/PurchaseOrder/5
        public PurchaseOrder Get(int id)
        {
            return new PurchaseOrder().GetById(id);
        }

        // POST: api/PurchaseOrder
        public void Post([FromBody]PurchaseOrder purchase)
        {
            //oi
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
