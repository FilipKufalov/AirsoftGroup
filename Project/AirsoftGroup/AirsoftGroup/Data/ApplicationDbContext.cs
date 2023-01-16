using AirsoftGroup.Models;
using AirsoftGroup.Models.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static AirsoftGroup.Data.ApplicationDbContext;

namespace AirsoftGroup.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }      

        public DbSet<Chat> ChatBox { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Stats> Stats { get; set; }
    }
}