using Microsoft.EntityFrameworkCore;

namespace anand_expense_manager.Models
{
    public interface ItotalDBContext
    {
        DbSet<Amount> Amount { get; set; }

        void OnConfiguring(DbContextOptionsBuilder optionsBuilder);
    }
}