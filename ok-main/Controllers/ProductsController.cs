using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NotUseAuto.Data;
using NotUseAuto.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using X.PagedList;

namespace NotUseAuto.Controllers
{


    public class ProductsController : Controller
    {

        private readonly ApplicationDbContext context;


        public ProductsController(ApplicationDbContext dbContext)
        {
            context = dbContext;

        }
        protected UserManager<ApplicationUser> UserManager { get; set; }



        [Authorize(Roles = "Owner")]
        public IActionResult Index(int ?page)
        {
			int pageSize = 8;
			int pageNumber = page == null || page <= 0 ? 1 : page.Value;
			var lstProduct = context.Product.AsNoTracking().OrderBy(x => x.Id);
			PagedList<Product> prolst = new PagedList<Product>(lstProduct, pageNumber, pageSize);
			//var products = context.Product.ToList();
   //         var categories = context.Category.ToList();
   //         ViewBag.Categories = categories;
            return View(prolst);
      
		}

        [Authorize(Roles = "Owner")]
        [HttpGet]

        public IActionResult Create()
        {
            var categories = context.Category.ToList();
            ViewBag.Categories = categories;
            return View();
        }
        [Authorize(Roles = "Owner")]
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                TempData["Message"] = "Create product successfully";
                context.Product.Add(product);
                context.SaveChanges();
                return Redirect("/products");
            }
            return View();
        }
        [Authorize(Roles = "Owner")]
        [HttpGet]
        public IActionResult Details(int? id)
        {
            var products = context.Product.ToList();
            var item = products.Find(p => p.Id == id);
            return View(item);
        }
        [Authorize(Roles = "Owner")]
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var products = context.Product.ToList();
            var item = products.Find(p => p.Id == id);
            var categories = context.Category.ToList();
            ViewBag.Categories = categories;
            return View(item);
        }
        [Authorize(Roles = "Owner")]
        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                TempData["Message"] = "Update product successfully";
                context.Product.Update(product);
                context.SaveChanges();
                return Redirect("/products");

            }
            return View();
        }
        [Authorize(Roles = "Owner")]
        [HttpGet]
        public IActionResult Confirm(int? id)
        {
            var products = context.Product.ToList();
            var item = products.Find(p => p.Id == id);
            return View(item);
        }
        [Authorize(Roles = "Owner")]
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            TempData["Message"] = "Delete product successfully";
            context.Product.Remove(product);
            context.SaveChanges();
            return Redirect("/products");
        }

        public IActionResult UserView()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ApplicationUser currentUser = (ApplicationUser)context.Users.FirstOrDefault(x => x.Id == userId);
            if (currentUser == null)
            {
                ViewBag.Message = "Have not Log in";
            }
            ViewBag.Img = currentUser.Image;
            ViewBag.Id = currentUser.Id;
            ViewBag.Email = currentUser.Email;
            ViewBag.UserName = currentUser.UserName;
            ViewBag.Fullname = currentUser.FullName;
            ViewBag.Address = currentUser.Address;
            ViewBag.Dob = currentUser.DoB;
            return View(currentUser);
        }

        
        public IActionResult Search(string search,int ?page)
        {
            var products = context.Product.Where(p => p.Name.Contains(search)).ToList();
            int pageSize = 8;
            int pageNumber = page == null || page <= 0 ? 1 : page.Value;
            PagedList<Product> prolst = new PagedList<Product>(products, pageNumber, pageSize);
            //var categories = context.Category.ToList();
            //ViewBag.Categories = categories;
            TempData["search"] = search;
            ViewBag.Search = search;
            return View(prolst);
        }
        public IActionResult SortDESC(int ?page)
        {
            var products = context.Product.OrderByDescending(p => p.Price).ToList();
            int pageSize = 8;
            int pageNumber = page == null || page <= 0 ? 1 : page.Value;
            PagedList<Product> prolst = new PagedList<Product>(products, pageNumber, pageSize);
            //var categories = context.Category.ToList();
            //ViewBag.Categories = categories;
            //return View("Index", products);
            return View(prolst);
        }
        public IActionResult SortASC(int ? page)
        {
            var products = context.Product.OrderBy(p => p.Price).ToList();
            int pageSize = 8;
            int pageNumber = page == null || page <= 0 ? 1 : page.Value;
            PagedList<Product> prolst = new PagedList<Product>(products, pageNumber, pageSize);
            //var categories = context.Category.ToList();
            //ViewBag.Categories = categories;
            //return View("Index", products);
            return View(prolst);
        }
    }


}
