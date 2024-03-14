using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Atividade_Avaliativa.Models
{
    public class Atividade_AvaliativaContext : DbContext
    {
        public Atividade_AvaliativaContext (DbContextOptions<Atividade_AvaliativaContext> options)
            : base(options)
        {
        }

        public DbSet<Atividade_Avaliativa.Models.Pessoa> Pessoa { get; set; }
    }
}
