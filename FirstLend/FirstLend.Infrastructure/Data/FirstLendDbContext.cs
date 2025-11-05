using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FraudGuard.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FirstLend.Infrastructure.Data
{
    public class FirstLendDbContext : IdentityDbContext<ApplicationUser>
    {
        public FirstLendDbContext(DbContextOptions<FirstLendDbContext> options) : base(options)
        {
        }

        // public DbSet<Transaction> Transactions { get; set; }
    }
}