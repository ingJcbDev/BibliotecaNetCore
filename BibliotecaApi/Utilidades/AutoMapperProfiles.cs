using AutoMapper;
using BibliotecaApi.DTOs;
using BibliotecaApi.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaApi.Utilidades
{
    public class AutoMapperProfiles :Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Categoria, CategoriaDTO>().ReverseMap();
            // Startup.cs y agregamos el AddAutoMapper
        }

    }
}
