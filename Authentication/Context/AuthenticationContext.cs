using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAuthentication.Models;


namespace UserAuthentication.Context
{
    public class AuthenticationContext: IdentityDbContext
    {
        public AuthenticationContext(DbContextOptions  options ):base(options)
        {

        }
        public Microsoft.EntityFrameworkCore.DbSet<ApplicationUser> applicationUser { get; set; }
    }
}
