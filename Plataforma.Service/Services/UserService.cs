using Plataforma.Domain.Entities;
using Plataforma.Service.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma.Service.Services
{
    public class UserService : IUserService
    {
        public UserService()
        {

        }

        public string Login(User user)
        {
            string MessageBox = "";

            if(user != null)
            {
                MessageBox = "Usuário logado com sucesso!";
            }
            else
            {
                MessageBox = "Usuário Negado!";
            }
            return MessageBox;
        }

    }
}
