using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DataBaseMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Mobile> Students { get; set; }
    }
    public class Mobile
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public byte Ram { get; set; }
        [StringLength(15)]
        public string Battery { get; set; }
        public bool ChargerInBox { get; set; }
        public DateTime? LaunchOn { get; set; }
    }
}
//Add-Migration MobileTable -context ApplicationDbContext -outputdir Data/Migrationsb

//Update - Database - context ApplicationDbContext