
using ASP_HomeWork_3.Models;
using ASP_HomeWork_3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;

namespace ASP_HomeWork_3.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductServices _services;



        public ProductController(IProductServices services)
        {
            _services = services;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {

            var vm = new ProductListViewModel
            {
                Products = await _services.GetAllAsync()
            };

            return View(vm);

        }
        [HttpGet]

        public IActionResult Add() {


            var vm = new ProductViewModel
            {
                Product = new Entities.Product()
        };
            

            return View(vm);
        }
        
        [HttpPost]

        public async Task<IActionResult> Add(ProductViewModel vm) {

            await _services.AddAsync(vm.Product);


            return RedirectToAction(nameof(Index));
        
        }

        [HttpGet] 

        public async Task<IActionResult> Modify(int id)
        {

            var vm = new ProductViewModel
            {
                Product = await _services.GetByIdAsync(id)
            };


            return View(vm);

        }

        [HttpPost]

        public async Task<IActionResult> Modify(ProductViewModel vm, int id)
        {
            vm.Product.Id = id;
            await _services.ModifyAsync(vm.Product);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]

        public async Task<IActionResult> Delete(int id)
        {
            await _services.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }



    }
}
