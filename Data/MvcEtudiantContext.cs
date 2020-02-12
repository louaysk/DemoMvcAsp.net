using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcEtudiant.Models;

namespace MvcEtudiant.Data
{
    public class MvcEtudiantContext : DbContext
    {
        public MvcEtudiantContext (DbContextOptions<MvcEtudiantContext> options)
            : base(options)
        {
        }

        public DbSet<MvcEtudiant.Models.Etudiant> Etudiant { get; set; }
    }
}
