using Microsoft.AspNetCore.Mvc;
using Plataforma.Domain.Entities;
using Plataforma.Service.Contracts.Services;

namespace Plataforma.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService_)
        {
            _userService = userService_;
        }

        public string Login([FromBody]User user)
        {
            return _userService.Login(user);
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Get()
        {
            return View();
        }
    }
}
