using Microsoft.EntityFrameworkCore;
using SimpleSignalR.Models;

namespace SimpleSignalR
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }


        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>().HasData
            (
                new Message {Id = 1, Content = "Cool", Owner = "Negev"},
                new Message {Id = 2, Content = "Badio", Owner = "Adawg"}
            );
        }
    }
}