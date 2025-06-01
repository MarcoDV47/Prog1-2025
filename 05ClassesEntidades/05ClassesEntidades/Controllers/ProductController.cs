using Modelo; // Não é a melhor alternativa, mas para poupar tepo, utilizaremos esta
using Repository;
using Microsoft.AspNetCore.Mvc;

namespace _05ClassesEntidades.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository _productRepository;

        public ProductController()
        {
            _productRepository = new ProductRepository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Product> products = _productRepository.RetrieveAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product p)
        {
            _productRepository.Save(p);

            List<Product> products = _productRepository.RetrieveAll();

            return View("Index", products);

            // return View();
            // Se nenhum valor for especificado, ele voltará para o método que o chamou (Create)
        }
    }
}
