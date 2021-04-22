using ApiPost.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPost.Data
{
    public class LigasContext : DbContext
    {
        public LigasContext(DbContextOptions<LigasContext> options) : base(options)
        {

        }

        public DbSet<Ligas> Ligas { get; set; }
    
    }
}
