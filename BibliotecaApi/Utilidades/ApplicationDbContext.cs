using BibliotecaApi.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaApi.Utilidades
{
    // Esta clase nos ayuda a gestionar directamente la base de datos
    // trabaja directamnete con migracion
    public class ApplicationDbContext : DbContext // se importa Microsoft.EntityFrameworkCore
    {
        //Se crea constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions)
            :base(dbContextOptions)
        {
        }

        // una vez declarado podemos migrar categoria
        public DbSet<Categoria> Categorias { get; set; }
    }
}