﻿using NotUseAuto.Models;
using NotUseAuto.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using System.Security.Claims;
using System;
using X.PagedList;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNet.Identity;
using PasswordVerificationResult = Microsoft.AspNetCore.Identity.PasswordVerificationResult;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace NotUseAuto.Controllers
{


    public class CustomerController : Controller
    {

        public const string CARTKEY = "cart";
        private readonly ApplicationDbContext context;
        private readonly IWebHostEnvironment _env;
        List<CartItem> GetCartItems()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }

        // Xóa cart khỏi session
        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
        }

        // Lưu Cart (Danh sách CartItem) vào session
        void SaveCartSession(List<CartItem> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }
        public CustomerController(ApplicationDbContext dbContext, IWebHostEnvironment env)
        {
            context = dbContext;
            _env = env;
        }
        [Route("/Customer/")]
        [Route("/")]
        public IActionResult Index(int ? page)
        {
            
            int pageSize = 8;
            int pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var lstProduct = context.Product.AsNoTracking().OrderBy(x => x.Id);
            PagedList<Product> lst = new PagedList<Product>(lstProduct, pageNumber, pageSize);
            //var products = context.Product.ToList();
            //var categories = context.Category.ToList();
            //ViewBag.Categories = categories;
            return View(lst);
        }


        public IActionResult Index2(int? id,int?page)
        {
            //var products = context.Product.ToList();
            //var categories = context.Category.ToList();
            //ViewBag.Categories = categories;
            //var productSearch = context.Category.Include(c => c.Products).FirstOrDefault(c => c.Id == id);
            //return View(productSearch);
            int pageSize = 8;
            int pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var lstProduct = context.Product.AsNoTracking().Where(x=>x.CategoryId==id).OrderBy(x => x.Id);
            PagedList<Product> lst = new PagedList<Product>(lstProduct, pageNumber, pageSize);
            ViewBag.NowCategoriesID=id;
            return View(lst);
        }
        public IActionResult Search(string search,int ?page)
        {
            var products = context.Product.Where(p => p.Name.Contains(search)).ToList();
            //var categories = context.Category.ToList();
            int pageSize = 8;
            int pageNumber = page == null || page <= 0 ? 1 : page.Value;
            PagedList<Product> lst = new PagedList<Product>(products, pageNumber, pageSize);
            //ViewBag.Categories = categories;
            ViewBag.Search = search;
            TempData["search"] = search;
            return View(lst);
        }
        public IActionResult Details(int? id)
        {
            var products = context.Product.ToList();
            var item = products.FirstOrDefault(c => c.Id == id);
            //var categories = context.Category.ToList();
            //ViewBag.Categories = categories;
            return View(item);
        }

        [Authorize(Roles = "Customer,Administrator")]
        public IActionResult AddtoCart(int? id)
        {
            var product = context.Product
        .Where(p => p.Id == id)
        .FirstOrDefault();
            if (product == null)
                return NotFound("Không có sản phẩm");

            // Xử lý đưa vào Cart ...
            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.product.Id == id);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cartitem.Quantity++;
            }
            else
            {
                //  Thêm mới
                cart.Add(new CartItem() { Quantity = 1, product = product });
            }

            // Lưu cart vào Session
            SaveCartSession(cart);
            // Chuyển đến trang hiện thị Cart
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ViewCart()
        {
            var categories = context.Category.ToList();
            ViewBag.Categories = categories;
            return View(GetCartItems());
        }

        [Route("/updatecart", Name = "updatecart")]
        
        public IActionResult UpdateCart(int productid, int quantity)
        {
            // Cập nhật Cart thay đổi số lượng quantity ...
            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.product.Id == productid);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cartitem.Quantity = quantity;
            }
            SaveCartSession(cart);
            // Trả về mã thành công (không có nội dung gì - chỉ để Ajax gọi)
            return Ok();
            //return View("Index");
        }
        [Route("/removecart/{productid:int}", Name = "removecart")]
        public IActionResult RemoveCart([FromRoute] int productid)
        {
            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.product.Id == productid);
            if (cartitem != null)
            {
                // Bỏ ra khỏi cart
                cart.Remove(cartitem);
            }

            SaveCartSession(cart);
            return RedirectToAction(nameof(ViewCart));
        }
        public IActionResult UserView()
        {
            //var categories = context.Category.ToList();
            //ViewBag.Categories = categories;
            //var claimIdentity = (ClaimsIdentity)User.Identity;

            //var claims = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            //string currentUserId = claims.Value;
            //ApplicationUser currentUser = (ApplicationUser)context.Users.FirstOrDefault(x => x.Id == currentUserId);
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
        public IActionResult Checkout()
        {
            //var claimIdentity = (ClaimsIdentity)User.Identity;
            //var claims = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            //string currentUserId = claims.Value;

            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // caculate total price
            var cart = GetCartItems();
            double total = 0;
            foreach (var item in cart)
            {
                total += (double)(item.product.Price * item.Quantity);
            }

            for (int i = 0; i < cart.Count; i++)
            {
                var order = new Order()
                {
                    UserId = currentUserId,
                    ProductId = cart[i].product.Id,
                    ProductName = cart[i].product.Name,
                    image = cart[i].product.Image1,
                    Price = (int) cart[i].product.Price,
                    Quantity = cart[i].Quantity,
                    TotalPrice = total,

                };
                context.Product.FirstOrDefault(x => x.Id == cart[i].product.Id).Quantity -= cart[i].Quantity;
                context.Order.Add(order);
                
                context.SaveChanges();
            }
            ClearCart();
            return RedirectToAction(nameof(Index));

        }
        public  IActionResult ViewOrder()
        {
            //var categories = context.Category.ToList();
            //ViewBag.Categories = categories;
            //var claimIdentity = (ClaimsIdentity)User.Identity;
            //var claims = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            //string currentUserId = claims.Value;
            //Console.WriteLine(currentUserId);
            //int UsrID = Int32.Parse(currentUserId);
            //var orders = context.Order.ToList();
            //var FindOrder = context.Order.Where(p => p.UserId.Contains(currentUserId)).ToList();
            //return View( FindOrder);
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var orders = context.Order.Include(o => o.cartItems)
                .Where(o => o.UserId == userId)
                .ToList();
            if (orders.Count == 0)
            {
                ViewBag.Message = "You don't have any orders yet.";
            }
            return View(orders);

        }
        [Route("SuaAccount")]
        [HttpGet]
        public IActionResult SuaAccount(string ID)
        {
            var user = context.Users.Find(ID);
            return View(user);
        }

        [Route("SuaAccount")]
        [HttpPost]
        public IActionResult SuaAccount(ApplicationUser newUser)
        {
            
            ApplicationUser user = context.Users.Find(newUser.Id) as ApplicationUser;
            if (ModelState.IsValid)
            {
                var imageFile = Request.Form.Files.FirstOrDefault();
                if (imageFile != null && imageFile.Length > 0)
                {
                    var imagePath = Path.Combine(_env.WebRootPath, "images", imageFile.FileName);
                    using (var stream = new FileStream(imagePath, FileMode.Create))
                    {
                        imageFile.CopyTo(stream);
                    }
                    
                    // Lưu đường dẫn của file ảnh vào thuộc tính Image của đối tượng user
                    user.Image = "/images/" + imageFile.FileName;
                }
                context.Entry(user).State = EntityState.Modified;
                //change infor
                user.PhoneNumber = newUser.PhoneNumber;
                user.FullName = newUser.FullName;
                //user.Image = newUser.Image;
                user.Address = newUser.Address;
                user.Email = newUser.Email;
                user.DoB = newUser.DoB;
                
               
                context.SaveChanges();
            }
            return View("UserView", user);
            ////try
            //{
            //    // Refresh user object from the database
            //    //context.Entry(user).Reload();

            //    // Compare original values with current values
            //    if (ModelState.IsValid)
            //    {
            //        // Update user object and save changes
            //        context.Entry(user).State = EntityState.Modified;
            //        context.Users.Update(user);
            //        context.SaveChanges();

            //        return View("UserView", user);

            //    }
            //    else
            //    {
            //        Console.WriteLine("Trọng ngu");

            //        // Handle concurrency conflict
            //        // You can throw a custom exception or show an error message to the user
            //    }
            //}
            ////catch (DbUpdateConcurrencyException ex)
            ////{
            ////    Console.WriteLine(ex.Message);
            ////    // Handle DbUpdateConcurrencyException
            ////    // You can throw a custom exception or show an error message to the user
            ////}

            //return View("UserView",user);

        }
    }
    
}
