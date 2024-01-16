﻿using book_worm_api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace book_worm_api.Data
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        //options return value is specified in Services Program.cs
        public ApplicationDbContext(DbContextOptions options) : base(options) { 
        }
        //The table in database doesn't change its name to ApplicationUser because EF knows that it extends the IdentityDbContext
        //EF will not create a new table because it knows that it inherits the IdentityDbContext
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //standart setup
            base.OnModelCreating(builder);
            //Entity we want to seed with info
            builder.Entity<MenuItem>().HasData(

                    new MenuItem
                    {
                        Id = 1,
                        Name = "Spring Roll",
                        Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                        Image = "~/images/Appetizer1.jpg",
                        Price = 7.99,
                        Category = "Appetizer",
                        SpecialTag = ""
                    }, new MenuItem
                    {
                        Id = 2,
                        Name = "Idli",
                        Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                        Image = "~/images/Appetizer2.jpg",
                        Price = 8.99,
                        Category = "Appetizer",
                        SpecialTag = ""
                    }, new MenuItem
                    {
                        Id = 3,
                        Name = "Panu Puri",
                        Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                        Image = "~/images/Appetizer3.jpg",
                        Price = 8.99,
                        Category = "Appetizer",
                        SpecialTag = "Best Seller"
                    }, new MenuItem
                    {
                        Id = 4,
                        Name = "Hakka Noodles",
                        Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                        Image = "~/images/Entrée1.jpg",
                        Price = 10.99,
                        Category = "Entrée",
                        SpecialTag = ""
                    }, new MenuItem
                    {
                        Id = 5,
                        Name = "Malai Kofta",
                        Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                        Image = "~/images/Entrée2.jpg",
                        Price = 12.99,
                        Category = "Entrée",
                        SpecialTag = "Top Rated"
                    }, new MenuItem
                    {
                        Id = 6,
                        Name = "Paneer Pizza",
                        Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                        Image = "~/images/Entrée3.jpg",
                        Price = 11.99,
                        Category = "Entrée",
                        SpecialTag = ""
                    }, new MenuItem
                    {
                        Id = 7,
                        Name = "Paneer Tikka",
                        Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                        Image = "~/images/Entrée4.jpg",
                        Price = 13.99,
                        Category = "Entrée",
                        SpecialTag = "Chef's Special"
                    }, new MenuItem
                    {
                        Id = 8,
                        Name = "Carrot Love",
                        Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                        Image = "~/images/Dessert1.jpg",
                        Price = 4.99,
                        Category = "Dessert",
                        SpecialTag = ""
                    }, new MenuItem
                    {
                        Id = 9,
                        Name = "Rasmalai",
                        Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                        Image = "~/images/Dessert2.jpg",
                        Price = 4.99,
                        Category = "Dessert",
                        SpecialTag = "Chef's Special"
                    }, new MenuItem
                    {
                        Id = 10,
                        Name = "Sweet Rolls",
                        Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                        Image = "~/images/Dessert3.jpg",
                        Price = 3.99,
                        Category = "Dessert",
                        SpecialTag = "Top Rated"
                    }
                );
        }
    }
}
