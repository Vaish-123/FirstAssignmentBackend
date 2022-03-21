using FirstAssignment.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FirstAssignment.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class WebApiController
    {
        DbHandle obj = new DbHandle();
        [HttpGet]
        public string GetC()
        {
            List<Customer> clist = obj.GetCustomer();
            return JsonConvert.SerializeObject(clist);
        }

        [HttpGet]
        [Route("getproduct")]
        public string GetP(int id)
        {
            List<Product> plist = obj.GetProduct(id);
            return JsonConvert.SerializeObject(plist);
        }

        [HttpGet]
        [Route("getproductbyid")]
        public string GetProductById(int id)
        {
            Product plist = obj.GetProductById(id);
            return JsonConvert.SerializeObject(plist);
        }

        [HttpPost]
        [Route("postcustomer")]
        public void PostC(Customer c)
        { 
            obj.AddCustomer(c);
        }

        [HttpPost]
        [Route("postproduct")]
        public void PostP(Product p)
        {
            obj.AddProduct(p);
        }

        [HttpDelete]
        [Route("deletecustomer")]
        public void DeleteC(int id)
        { 
            obj.DeleteCustomer(id);
        }

        [HttpDelete]
        [Route("deleteproduct")]
        public void DeleteP(int id)
        {
            obj.DeleteProduct(id);
        }

        [HttpPut]
        [Route("updateproduct")]
        public void UpdateP(Product p)
        {
            obj.UpdateProduct(p);
        }
    }
}
