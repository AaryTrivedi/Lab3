using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class ContactContext : DbContext
    {

        public ContactContext(DbContextOptions<ContactContext> options) 
            : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Other" }
            );

            modelBuilder.Entity<Contact>().HasData(
                new Contact { 
                    ContactId = 1,
                    FirstName = "Aary",
                    LastName = "Trivedi",
                    Phone = "437-985-8058",
                    Email = "aarytrivedi@gmail.com",
                    CategoryId = 1,
                    DateAdded = DateTime.Now
                },
                new Contact
                {
                    ContactId = 2,
                    FirstName = "Test1",
                    LastName = "Test2",
                    Phone = "123-123-1231",
                    Email = "test1@s.com",
                    CategoryId = 2,
                    DateAdded = DateTime.Now
                },
                new Contact
                {
                    ContactId = 3,
                    FirstName = "Test3",
                    LastName = "Test4",
                    Phone = "123-123-1231",
                    Email = "test3@gmail.com",
                    CategoryId = 3,
                    DateAdded = DateTime.Now
                }
            );

        }

    }
}
