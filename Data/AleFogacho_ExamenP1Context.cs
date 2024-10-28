using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AleFogacho_ExamenP1.Models;

    public class AleFogacho_ExamenP1Context : DbContext
    {
        public AleFogacho_ExamenP1Context (DbContextOptions<AleFogacho_ExamenP1Context> options)
            : base(options)
        {
        }

        public DbSet<AleFogacho_ExamenP1.Models.AF_Cita> AF_Cita { get; set; } = default!;
    }
