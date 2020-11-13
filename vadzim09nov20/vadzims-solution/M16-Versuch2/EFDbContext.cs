using M16_Demo_EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace M16_Versuch2
{
    class EFDbContext : DbContext
    {
        public DbSet<TransportmittelEF> DieTransportmittel { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=TransportDB.db");
        }

    }
}
