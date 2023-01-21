using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class PersonelKontrolSistemiDbContext : DbContext
    {
        public PersonelKontrolSistemiDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Firma> Firmalar { get; set;}
        public DbSet<Sube> Subeler { get; set;}
        public DbSet<Personel> Personeller { get; set;}
        public DbSet<PersonelHareketleri> PersonelHareketleri { get; set;}


    }
}
