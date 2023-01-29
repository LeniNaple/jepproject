using jepproject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jepproject.System
{
    internal class Contact : IContact
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Adress { get; set; } = null!;

        public string Number { get; set; } = null!;

        string FullName => $"{FirstName} +  {LastName}";

    }
}
