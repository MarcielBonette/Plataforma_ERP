using Plataforma.Domain.Entities;
using Plataforma.Service.Contracts.Services;

namespace Plataforma.Service
{
    public class CustomerService : ICustomerService
    {
        public CustomerService()
        {

        }

        public string Insert(Customer costumer)
        {
            string MessageBox = "";

            if (costumer != null)
            {
                MessageBox = "Cliente cadastrado com sucesso!";
            }
            else
            {
                MessageBox = "Cliente não cadastrado!";
            }

            return MessageBox;
        }



    }
}
