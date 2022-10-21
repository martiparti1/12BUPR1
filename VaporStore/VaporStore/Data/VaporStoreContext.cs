﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaporStore.Data.Models;

namespace VaporStore.Data
{
    class VaporStoreContext : DbContext
    {
        public VaporStoreContext() { }

        public VaporStoreContext(DbContextOptions options) : base(options) { }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Game> Games { get; set; }

        public DbSet<GameTag> GameTags{ get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameTag>().HasKey(x => new { x.GameID, x.TagID});
        }
    }
}
