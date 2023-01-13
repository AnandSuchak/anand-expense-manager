using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace anand_expense_manager.Models
{
    public class totalDBContext : ItotalDBContext
    {
        public virtual DbSet<Amount> Amount { get; set; }

        public override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\expanse.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }
    }
}
