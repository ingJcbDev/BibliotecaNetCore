using BibliotecaApi.DTOs;
using BibliotecaApi.Entidades;
using BibliotecaApi.Utilidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaApi.Controllers
{
    [ApiController]
    [Route("/api/categorias")]
    public class CategoriasController :Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public CategoriasController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        //para esto se crea la carpeta (DTOs)
        //En la Carpeta Utilidades se crea el archivo AutoMapperProfiles.cs
        public async Task<ActionResult<List<CategoriaDTO>>> Get()
        {
            var categorias = await applicationDbContext.Categorias.ToListAsync();
            return categorias.Select(c => new CategoriaDTO
            {
                Id = c.Id,
                Nombre = c.Nombre,
            }).ToList();
        }
    }
}
