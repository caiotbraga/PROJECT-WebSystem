using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using SalesWebMvc.Models.ViewModels;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private SellerService SellerService;
        private DepartmentService DepartmentService;

        public SellersController(SellerService ss, DepartmentService ds)
        {
            SellerService = ss;
            DepartmentService = ds;
        }
        public IActionResult Index()
        {
            var list = SellerService.FindAll();
            return View(list);
        }

        
        public IActionResult Create()
        {
            var departments = DepartmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel);
        }

        [HttpPost] 
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            SellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
