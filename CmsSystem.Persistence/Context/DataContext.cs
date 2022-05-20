﻿using CmsSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CmsSystem.Persistence.Context
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }
        public DbSet<Product>Products { get; set; }
        public DbSet<Order>Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
