using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NTHuongMVC.Models;

namespace NTHuongMVC.Data
{
    public class NTHuongMVCContext : DbContext
    {
        public NTHuongMVCContext (DbContextOptions<NTHuongMVCContext> options)
            : base(options)
        {
        }

        public DbSet<NTHuongMVC.Models.Movie> Movie { get; set; }

        public DbSet<NTHuongMVC.Models.TheLoai> TheLoai { get; set; }
    }
}
