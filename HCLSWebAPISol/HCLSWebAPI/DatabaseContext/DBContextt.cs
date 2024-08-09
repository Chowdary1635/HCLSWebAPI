using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HCLSWebAPI.DatabaseContext
{
    public class DBContextt :DbContext
    {
        public DBContextt(DbContextOptions<DBContextt> options) : base(options) { }
      
        public DbSet<AdminType> AdminTypes { get; set; }

        public DbSet<Admin> Admins { get; set; }
    }
}
