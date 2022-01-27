using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WypozyczalniaSprzetuKomputerowego.Models;

namespace WypozyczalniaSprzetuKomputerowego.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WypozyczalniaSprzetuKomputerowego.Models.Comment> Comment { get; set; }
        public DbSet<WypozyczalniaSprzetuKomputerowego.Models.Equipment> Equipment { get; set; }
        public DbSet<WypozyczalniaSprzetuKomputerowego.Models.Rent> Rent { get; set; }
    }
}
