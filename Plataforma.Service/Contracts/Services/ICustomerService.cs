using Plataforma.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma.Service.Contracts.Services
{
    public interface ICustomerService
    {
        string Insert(Customer customer);
    }
}
