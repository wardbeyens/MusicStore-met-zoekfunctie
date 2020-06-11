﻿using MusicStore.Models;
using Microsoft.EntityFrameworkCore;

namespace MusicStore.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }

        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<Artist>().ToTable("Artist");
            modelBuilder.Entity<Album>().ToTable("Album");

            modelBuilder.Entity<CartItem>().ToTable("CartItem");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderItem>().ToTable("OrderItem");
        }
    }
}
