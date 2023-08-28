using Microsoft.AspNetCore.Mvc;
using Week_2_Day_2.Interfaces;
using Week_2_Day_2.Models;
using Week_2_Day_2.ViewModels;

namespace Week_2_Day_2.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Product> products = _productRepository.GetAllProducts();
            return View(products);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Product product = _productRepository.GetProductById(id);
            ProductDetailsViewModel viewModel = new ProductDetailsViewModel
            {
                Product = product,
                DisplayMessage = "Product details retrieved successfully."
            };
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.AddProduct(product);
                TempData["success"] = $"Product {product.Name} Added Successfully";
                return RedirectToAction("Index");
            }

            return View(product);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product product = _productRepository.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.UpdateProduct(product);
                TempData["success"] = "Category Updated Successfully";
                return RedirectToAction("Index");
            }

            return View(product);
        }

        public bool Delete(int id)
        {
            bool isDeleted = _productRepository.DeleteProduct(id);
            if(isDeleted)
            {
                return true;
            }
            return false;
        }
    }
}
