namespace InnoVision.V0.Data
{
    using InnoVision.V0.Models;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    public class ShoppingContext : DbContext
    {
        public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
