using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpendingScrooge.Models
{
    public class Expense
    {
        public DateTime ExpenseDate { get; set; }
        public string ExpenseCategory { get; set; }
        public decimal ExpenseAmount { get; set; }
        public string ExpenseDescription { get; set; }
    }
}
