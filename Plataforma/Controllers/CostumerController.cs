using Microsoft.AspNetCore.Mvc;
using Plataforma.Domain.Entities;
using Plataforma.Service.Contracts.Services;

namespace Plataforma.Controllers
{
    public class CostumerController : Controller
    {
        private readonly ICostumerService _costumerService;

        public CostumerController(ICostumerService costumerService_)
        {
            _costumerService = costumerService_;
        }

        public string Insert([FromBody] Costumer costumer)
        {
            return _costumerService.Insert(costumer);
        }

        public ActionResult Delete()
        {
            return View();
        }


        public ActionResult Update(int id)
        {
            return View();
        }


        public ActionResult Get(int id)
        {
            return View();
        }

    }
}
