﻿using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace CityTourist.Models
{
    public class TouristDbContext : DbContext
    {
        public TouristDbContext(DbContextOptions<TouristDbContext> options) : base(options)
        {
        }

        public DbSet<AdminModel> Admin { get; set; }

        public DbSet<City> City { get; set; }
        public DbSet<Place> Place { get; set; }

    }
}
