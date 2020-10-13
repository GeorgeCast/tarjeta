using BakcEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakcEnd.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
        }

        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
    }
}
