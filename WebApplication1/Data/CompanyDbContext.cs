﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext (DbContextOptions<CompanyDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.Employee> Employee { get; set; }

        public DbSet<WebApplication1.Models.Manager> Manager { get; set; }
    }
}
