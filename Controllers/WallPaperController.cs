using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WallPaperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WallPaperController : ControllerBase
    {
        public string[] getData()
        {
            return new string[] { "welcome", "Good morning","Good day","good evening" };
        }
        [HttpGet("getProd")]
        public async Task<ActionResult<List<Product>>> getAllData()
        {
            List<Product> product = Product.getProducts();
            return Ok(product);
        }

        public List<Product> getProds()
        {
            List<Product> products = Product.getProducts();
            return products;
        }
        // [Route("getProd/{id}")]
        [HttpGet("getProd/{id}")]
        public async Task<ActionResult<Product>> getProdDetail(string id)
        {
            Product product = Product.getProducts().Find(p=>p.PID==id);
            return Ok(product);
        }
    }
}
