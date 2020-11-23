using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinProj.Models
{
    public class AppUserClass : DbContext
    {
        public AppUserClass(DbContextOptions<AppUserClass> options) : base(options)
        {

        }

        

    }
}
