﻿using Microsoft.EntityFrameworkCore;
using TreinoSAEP.Models;

namespace TreinoSAEP.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }
        public DbSet<Perfis> Perfis { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Equipamentos> Equipamentos { get; set; }
        public DbSet<Comentarios> Comentarios { get; set; }

    }
}
