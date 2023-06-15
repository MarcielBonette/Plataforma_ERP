using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma.Service.Contracts.Services
{
    public interface ILoginService
    {
        Task<string> Entrar(string cpf, string senha);

        bool ValidaCpf(string cpf);

        bool ValidaSenha(string senha);
    }
}
