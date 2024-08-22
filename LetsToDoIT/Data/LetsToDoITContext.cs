using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LetsToDoIT.Models.Notes;

namespace LetsToDoIT.Data
{
    public class LetsToDoITContext : DbContext
    {
        public LetsToDoITContext (DbContextOptions<LetsToDoITContext> options)
            : base(options)
        {
        }

        public DbSet<LetsToDoIT.Models.Notes.Note> Note { get; set; } = default!;
    }
}
