using Anyar.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Anyar.DataAccesLayer
{
    public class AnyarContext : IdentityDbContext
    {
        public DbSet<Employees> Employees { get; set; }
        public AnyarContext(DbContextOptions options) : base(options)
        {

        }

    }
}
