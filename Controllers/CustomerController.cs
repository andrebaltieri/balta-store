using Balta.Store.Models;
using Balta.Store.Repositories;
using Balta.Store.Repositories.Contracts;
using Balta.Store.Validations;
using Microsoft.AspNetCore.Mvc;

namespace Balta.Store.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _repository;

        public CustomerController(ICustomerRepository repository) => _repository = repository;

        [HttpPost]
        [Route("v1/customers")]
        //[ResponseCache(VaryByHeader = "User-Agent", Duration = 30)]
        public IActionResult Post([FromBody]Customer customer)
        {
            var res = new CustomerValidator().Validate(customer).Errors;
            if (res != null && res.Count > 0)
                return new BadRequestObjectResult(res);

            try
            {
                _repository.Save(customer);
                return new OkObjectResult(new { message = "Cliente cadastrado com sucesso!" });
            }
            catch
            {
                return new BadRequestObjectResult(new { message = "Falha ao cadastrar o cliente" });
            }
        }
    }
}