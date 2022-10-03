using IdentityExample.Data;
using IdentityExample.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityExample.Controllers
{
    public class PanelController : Controller
    {
        ApplicationDbContext _db;
        public PanelController(ApplicationDbContext db)
        {
            _db=db;
        }
        [Authorize]
        public IActionResult Index()
        {
            return Content("Only authorized users access....");
        }
        [Authorize(Roles = "admin")]
        public IActionResult ProductListAdmin()
        {
            return View(_db.Products.ToList());
        }
        [Authorize(Roles = "admin,user")]
        public IActionResult ProductList()
        {
            List<ProductVM> products = new List<ProductVM>();
            foreach(Product product in _db.Products.ToList())
            {
                ProductVM productVM = new ProductVM();
                productVM.ProductId = product.ProductId;
                productVM.ProductName= product.ProductName;
                productVM.Category = product.Category;
                productVM.SellingPrice=product.SellingPrice;
                products.Add(productVM);
            }
            return View(products);
        }
    }
}
