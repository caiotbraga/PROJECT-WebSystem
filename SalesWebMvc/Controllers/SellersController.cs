using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private SellerService SellerService;

        public SellersController(SellerService ss)
        {
            SellerService = ss;
        }
        public IActionResult Index()
        {
            var list = SellerService.FindAll();
            return View(list);
        }
    }
}
