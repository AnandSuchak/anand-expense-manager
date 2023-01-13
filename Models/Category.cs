using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace anand_expense_manager.Models
{
    public class Category
    {
        [Key]
        public int ItemId { get; set; }
        [Required]
        public string ItemName { get; set; }

    }
}
