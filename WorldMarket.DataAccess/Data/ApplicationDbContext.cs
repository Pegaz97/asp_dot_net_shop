﻿using Microsoft.EntityFrameworkCore;
using WorldMarket.Models;

namespace WorldMarket.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base (options)
        {
        }
        public DbSet<Category> Categories { get; set; }
    }
}