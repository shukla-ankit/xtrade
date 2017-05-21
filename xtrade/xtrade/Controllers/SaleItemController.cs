using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using xtrade.Models;

namespace xtrade.Controllers
{
    public class SaleItemController : ApiController
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/SaleItem
        public HttpResponseMessage Get()
        {
            List<Item> items = null;
            if (User.IsInRole("Admin"))
            {
                items = db.Items.ToList();
            }
            else
            {
                items = db.Items.ToList();
            }

            items.Sort((x, y) => x.Category.CategoryName.CompareTo(y.Category.CategoryName));

            items.Sort((x, y) => x.Seller.Substring(0, 1).CompareTo(y.Seller.Substring(0, 1)));

            string json = JsonConvert.SerializeObject(items, Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });

            var res = Request.CreateResponse(HttpStatusCode.OK);
            res.Content = new StringContent(json, Encoding.UTF8, "application/json");

            return res;
        }

        // GET: api/SaleItem/5
        public HttpResponseMessage Get(int id)
        {
            Item item = db.Items.Single(s => s.Id == id);
            //db.Entry(item).Collection(u => u.Images)
            //    .Query().Where(image => image.DoNotDisplay == false).Load();


            item.Images = db.Images.Where(s => s.ItemId == item.Id).ToList();

            List<Image> iss = new List<Image>();

            foreach (Image i in item.Images)
            {
                if (!i.DoNotDisplay)
                {
                    iss.Add(i);
                }
            }
            item.Images = iss;

            if (item == null)
            {
                return null;
            }

            string json = JsonConvert.SerializeObject(item, Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });

            var res = Request.CreateResponse(HttpStatusCode.OK);
            res.Content = new StringContent(json, Encoding.UTF8, "application/json");

            return res;
        }


        // POST: api/SaleItem
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SaleItem/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SaleItem/5
        public void Delete(int id)
        {
        }
    }
}
