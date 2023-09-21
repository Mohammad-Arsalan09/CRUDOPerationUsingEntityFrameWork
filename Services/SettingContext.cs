using Microsoft.EntityFrameworkCore;
using MohaliAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MohaliAssignment.Services
{
    public class SettingContext:DbContext
    {
        public SettingContext(DbContextOptions<SettingContext> options) : base(options)
        {

        }
        public DbSet<Settings> Setting { get; set; }
    }
}
