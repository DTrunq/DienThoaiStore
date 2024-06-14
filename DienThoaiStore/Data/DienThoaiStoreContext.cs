using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DienThoaiStore.Models;
using DienThoaiStore.Data;

namespace DienThoaiStore.Data
{
    public class DienThoaiStoreContext : DbContext
    {
        public DienThoaiStoreContext (DbContextOptions<DienThoaiStoreContext> options)
            : base(options)
        {
        }

        public DbSet<DienThoaiStore.Models.Phone> Phone { get; set; } = default!;
        public DbSet<DienThoaiStore.Models.Staff> Staff { get; set; } = default!;
        public DbSet<DienThoaiStore.Models.Order> Order { get; set; } = default!;
    }
}
