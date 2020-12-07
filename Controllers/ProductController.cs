using Annabakes.API.Context;
using Annabakes.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annabakes.API.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Route("products")]
        [HttpGet]
        public List<Product> GetAllProducts()
        {
            using var dbContext = new BakeryDbContext();
            return dbContext.Products.ToList();

        }
         
        [Route("products")]
        [HttpPost]
        public bool CreateProducts(Product products)
        {
            using var dbContext = new BakeryDbContext();

            dbContext.Products.Add(products);
            dbContext.SaveChanges();

            return true;
        }

        [Route("products")]
        [HttpDelete]
        public bool DeleteProducts(Product products)
        {
            using var dbContext = new BakeryDbContext();

            dbContext.Products.Remove(products);
            dbContext.SaveChanges();

            return true;
        }

        [Route("products")]
        [HttpPut]
        public bool UpdateProducts(Product products)
        {
            using var dbContext = new BakeryDbContext();

            dbContext.Products.Update(products);
            dbContext.SaveChanges();

            return true;
        }
    }
}
