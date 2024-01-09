﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace VTL_Web.Infrastructure.Authentication
{
    public interface ICustomPrincipal : IPrincipal
    {
        int Id { get; set; }
        int? RoleId { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }

    }
}
