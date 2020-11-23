using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinProj.Models;
using Microsoft.EntityFrameworkCore;

namespace FinProj.Controllers
{
    public class AppUserClass: DbContext
    {
        public AppUserClass(DbContextOptions<AppUserClass>options):base(options)
        {

        }

        public DbSet<UserClass> UserReg { get; set; }
    }
}
