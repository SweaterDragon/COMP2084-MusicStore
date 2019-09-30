using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace COMP2084_MusicStore.Models
{
    public class COMP2084_MusicStoreContext : DbContext
    {
        public COMP2084_MusicStoreContext (DbContextOptions<COMP2084_MusicStoreContext> options)
            : base(options)
        {
        }

        public DbSet<COMP2084_MusicStore.Models.Genre> Genre { get; set; }
    }
}
