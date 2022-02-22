using Microsoft.EntityFrameworkCore;
using moment3_3.Models;

namespace moment3_3.Data;
    public class SongContext : DbContext
    {
        public SongContext(DbContextOptions<SongContext> options) : base(options)
        {

        }
        
        public DbSet<Song> Songs { get; set; }

    }
