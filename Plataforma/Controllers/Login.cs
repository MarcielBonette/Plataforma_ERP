using Microsoft.AspNetCore.Mvc;
using Plataforma.Service.Contracts.Services;

namespace Plataforma.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Login : ControllerBase
    {
        private readonly ILoginService _loginService;

        public Login(ILoginService loginService)
        {
            _loginService = loginService;
        }

        
        [HttpPost(Name = "Entrar")]
        public async Task<IActionResult> Entrar(string cpf, string senha)
        {
            
            try
            {
                await _loginService.Entrar(cpf, senha);
                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
    }
}