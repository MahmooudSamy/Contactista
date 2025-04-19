using Contactista.DataAccess.Extentions;
using Contactista.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactista.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
           new User { Id = 1, Username = "user1", Password = "user1".ToHashText() },
           new User { Id = 2, Username = "user2", Password = "user2".ToHashText() });

            modelBuilder.Entity<Contact>().HasData(
          new Contact { ContactId = 1, FullName = "Mahmoud Samy",  PhoneNumber = "01024236263",
          Address="Alexandria"},
          new Contact
          {
              ContactId = 2,
              FullName = "Ahmed Ali",
              PhoneNumber = "01100000000",
              Address = "Cairo"
          }, new Contact
          {
              ContactId = 3,
              FullName = "Hazem Ahmed",
              PhoneNumber = "01200000000",
              Address = "Cairo"
          },
          new Contact
          {
              ContactId = 4,
              FullName = "Omar Marzok",
              PhoneNumber = "01500000000",
              Address = "Cairo"
          },
          new Contact
          {
              ContactId = 5,
              FullName = "Reda Tantawey",
              PhoneNumber = "01000000000",
              Address = "Cairo"
          });
            base.OnModelCreating(modelBuilder);
        }
    }


}
