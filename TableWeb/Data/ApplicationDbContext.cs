using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection.Emit;
using TableWeb.Models;
namespace TableWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        
        }
        public DbSet<TableWeb.Models.WordsData> dataWords { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.WordsData>().HasData(
                new Models.WordsData { Id=1, Name="Солнце",Description="Большое круглое днем на небе весит"},
                new Models.WordsData { Id = 2, Name = "Луна", Description = "Большое не всегда круглое ночью на небе иногда висит" },
                new Models.WordsData { Id = 3, Name = "Книга", Description = "Паралелепипед с буквами и бумагой" });
        }
    }
}
