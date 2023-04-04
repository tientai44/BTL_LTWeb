using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotUseAuto.Data;
using NotUseAuto.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace NotUseAuto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsAPIController : ControllerBase
    {
        readonly ApplicationDbContext context;

        public ProductsAPIController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            Console.WriteLine("GetAll");
            var products = context.Product.ToList();
            return products;
        }
        [HttpGet("search={search}")]
        public IEnumerable<Product> GetAllProductsBySearch(string search)
        {
            Console.WriteLine(search);
            var products = context.Product.Where(p => p.Name.Contains(search)).ToList();
            return products;
        }

        [HttpGet("categoryId={categoryId}")]
        public IEnumerable<Product> GetAllProductsByCategory(int categoryId)
        {
            Console.WriteLine(categoryId);
            var products = context.Product.Where(p => p.CategoryId==categoryId).ToList();
            return products;
        }
    }
}
