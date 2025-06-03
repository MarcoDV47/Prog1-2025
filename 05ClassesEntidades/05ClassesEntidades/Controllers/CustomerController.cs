using Modelo; // Não é a melhor alternativa, mas para poupar tepo, utilizaremos esta
using Repository;
using Microsoft.AspNetCore.Mvc;

namespace _05ClassesEntidades.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IWebHostEnvironment environment;

        private CustomerRepository _customerRepository;

        public CustomerController(IWebHostEnvironment environment)
        {
            _customerRepository = new CustomerRepository();
            this.environment = environment;
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

        [HttpGet]
        public IActionResult ExportDelimitatedFile()
        {
            string fileContent = string.Empty;
            foreach (Customer c in CustomerData.Customers)
            {
                fileContent +=
                    @$"{c.Id};
                       {c.Name};
                       {c.HomeAddress!.Id};
                       {c.HomeAddress.City};
                       {c.HomeAddress.StateOrProvince};
                       {c.HomeAddress.Country};
                       {c.HomeAddress.StreetLine1};
                       {c.HomeAddress.StreetLine2};
                       {c.HomeAddress.PostalCode};
                       {c.HomeAddress.AddressType};
                       \n
                    ";
            }

            var path = Path.Combine(
                environment.WebRootPath,
                "TextFiles"
            );

            if (!System.IO.Directory.Exists(path))
                System.IO.Directory.CreateDirectory(path);

            var filepath = Path.Combine(
                path,
                "Delimitado.txt"
            );

            using StreamWriter sw = System.IO.File.CreateText(filepath);
            sw.Write(fileContent);

            return View();
        }
    }
}
