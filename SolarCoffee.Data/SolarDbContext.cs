//using System;
//using System.Collections.Generic;
//using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SolarCoffee.Data.Models;

namespace SolarCoffee.Data
{
    class SolarDbContext : IdentityDbContext
    {
        public SolarDbContext() { } //paramless constructor

        public SolarDbContext(DbContextOptions options) : base(options) { }
        
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddress { get; set; }
    }
}
