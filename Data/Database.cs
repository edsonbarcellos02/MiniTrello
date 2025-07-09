using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MiniTrello.Models;


namespace MiniTrello.Data
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options) { }

        public DbSet<User> User { get; init; }
        public DbSet<Board> Notice { get; init; }
        public DbSet<List> List { get; init; }
        public DbSet<Card> Card { get; init; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Board>().ToTable("Board");
            modelBuilder.Entity<List>().ToTable("List");
            modelBuilder.Entity<Card>().ToTable("Card");            
        }
    }
}
