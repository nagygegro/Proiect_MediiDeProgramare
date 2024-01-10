using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect.Models;

namespace Proiect.Data
{
    public class ProiectContext : DbContext
    {
        public ProiectContext (DbContextOptions<ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect.Models.Student> Student { get; set; } = default!;

        public DbSet<Proiect.Models.Parent>? Parent { get; set; }

        public DbSet<Proiect.Models.Grade>? Grade { get; set; }

        public DbSet<Proiect.Models.School>? School { get; set; }

        public DbSet<Proiect.Models.Subject>? Subject { get; set; }

    }
}
