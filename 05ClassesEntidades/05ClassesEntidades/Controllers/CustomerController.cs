using Modelo; // Não é a melhor alternativa, mas para poupar tepo, utilizaremos esta
using Repository;
using Microsoft.AspNetCore.Mvc;

namespace _05ClassesEntidades.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerRepository _customerRepository;

        public CustomerController()
        {
            _customerRepository = new CustomerRepository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Customer> customers = _customerRepository.RetrieveAll();
            return View(customers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer c)
        {
            _customerRepository.Save(c);

            List<Customer> customers = _customerRepository.RetrieveAll();

            return View("Index", customers);

            // return View();
            // Se nenhum valor for especificado, ele voltará para o método que o chamou (Create)
        }
    }
}
