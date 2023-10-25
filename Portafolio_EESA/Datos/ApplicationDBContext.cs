using Microsoft.EntityFrameworkCore;
using Portafolio_EESA.Models;
using System;

namespace Portafolio_EESA.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Perfil> perfil { get; set; }
    }

}
