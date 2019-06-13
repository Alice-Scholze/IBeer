using CoreDistribuidor2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDistribuidor2.Controllers
{
    public class PurchaseOrderController : ApiController
    {
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
