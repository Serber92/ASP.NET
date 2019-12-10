using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductsCategories.Models;
using ContextNamespace.Models;
using AllProductsNamespace.Models;
using AllCategoriesNamespace.Models;
using Microsoft.EntityFrameworkCore;
using ProductCategoryWraperNamespace.Models;
using Microsoft.AspNetCore.Http;
using AssociationNamespace.Models;

namespace ProductsCategories.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Products()
        {
            AllProducts allProducts = new AllProducts();
            allProducts.Products = dbContext.Products.ToList();
            return View(allProducts);
        }
        public IActionResult AddProductProcess(AllProducts modelData)
        {
            if(ModelState.IsValid)
            {
                Product NewProduct = modelData.Product;
                dbContext.Add(NewProduct);
                dbContext.SaveChanges();
                return RedirectToAction("Products");
            }
            else
            {
                AllProducts allProducts = new AllProducts();
                allProducts.Products = dbContext.Products.ToList();
                return View("Products", allProducts);
            }
        }

        public IActionResult Categories()
        {
            AllCategories allCategories = new AllCategories();
            allCategories.Categories = dbContext.Categories.ToList();
            return View(allCategories);
        }
        public IActionResult AddCategoryProcess(AllCategories modelData)
        {
            if(ModelState.IsValid)
            {
                Category NewCategory = modelData.Category;
                dbContext.Add(NewCategory);
                dbContext.SaveChanges();
                return RedirectToAction("Categories");
            }
            else
            {
                AllCategories allCategories = new AllCategories();
                allCategories.Categories = dbContext.Categories.ToList();
                return View("Products", allCategories);
            }
        }
        public IActionResult AddCategoryToProduct(int CategoryId)
        {
            int? ProductId = HttpContext.Session.GetInt32("CurrentProductId");
            Association newAssociation = new Association()
            {
                ProductId = (int)ProductId,
                CategoryId = CategoryId
            };
            dbContext.Add(newAssociation);
            dbContext.SaveChanges();
            HttpContext.Session.Clear(); //just in case
            return Redirect("http://localhost:5000/ProductInfo/"+ProductId);
        }

        [HttpGet("ProductInfo/{ProductId}")]
        public IActionResult ProductInfo(int ProductId)
        {
            HttpContext.Session.SetInt32("CurrentProductId", ProductId);

            Product RetrievedProduct = dbContext.Products
            .Include(p => p.Category)
            .ThenInclude(sub => sub.Category)
            .FirstOrDefault(p => p.ProductId == ProductId);

            List<Category> AllCategories = dbContext.Categories
            .Where(c => !RetrievedProduct.Category.Any(a => a.CategoryId == c.CategoryId))
            .ToList();

            ProductCategoryWraper DataToPost = new ProductCategoryWraper()
            {
                Product = RetrievedProduct,
                Categories = AllCategories
            };
            return View(DataToPost);
        }

        [HttpGet("CategoryInfo/{CategoryId}")]
        public IActionResult CategoryInfo(int CategoryId)
        {
            HttpContext.Session.SetInt32("CurrentCategoryId", CategoryId);

            Category RetrievedCategory = dbContext.Categories
            .Include(p => p.Products)
            .ThenInclude(sub => sub.Product)
            .FirstOrDefault(p => p.CategoryId == CategoryId);

            List<Product> AllProducts = dbContext.Products
            .Where(c => !RetrievedCategory.Products.Any(a => a.ProductId == c.ProductId))
            .ToList();

            ProductCategoryWraper DataToPost = new ProductCategoryWraper()
            {
                Category = RetrievedCategory,
                Products = AllProducts
            };

            return View(DataToPost);
        }

        public IActionResult AddProductToCategory(int ProductId)
        {
            int? CategoryId = HttpContext.Session.GetInt32("CurrentCategoryId");
            Association newAssociation = new Association()
            {
                ProductId = ProductId,
                CategoryId = (int)CategoryId
            };
            dbContext.Add(newAssociation);
            dbContext.SaveChanges();
            HttpContext.Session.Clear(); //just in case
            return Redirect("http://localhost:5000/CategoryInfo/"+CategoryId);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
