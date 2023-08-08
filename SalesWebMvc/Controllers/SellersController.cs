using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using SalesWebMvc.Models.ViewModels;
using System.Collections.Generic;
using SalesWebMvc.Services.Exceptions;

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

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = SellerService.FindByID(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = SellerService.FindByID(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        public IActionResult Edit(int? id) // ? -> used to check at execution time
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = SellerService.FindByID(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            List<Department> departments = DepartmentService.FindAll();
            SellerFormViewModel viewModel = new SellerFormViewModel { Seller = obj, Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            SellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            SellerService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Seller seller)
        {
            if (id != seller.Id)
            {
                return BadRequest();
            }
            try
            {
                SellerService.Update(seller);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }
        }
    }
}
