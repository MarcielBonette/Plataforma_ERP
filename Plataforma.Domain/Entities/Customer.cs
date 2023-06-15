using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma.Domain.Entities
{
    public class Customer
    {
        public string NameComplete { get; set; }
        public int RG { get; set; }
        public int CPF { get; set; }
        public int DateOfBirth { get; set; }
        public int Telephone { get; set; }
        public string Adress { get; set; }
        public string Password { get; set; }

    }
}
