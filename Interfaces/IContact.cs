using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jepproject.Interfaces;

internal interface IContact
{
    Guid Id { get; set; }

    string FirstName { get; set; }

    string LastName { get; set; }

    string Email { get; set; }

    string Adress { get; set; }

    string Number { get; set; }

}
