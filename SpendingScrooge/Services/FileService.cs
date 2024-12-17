using SpendingScrooge.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpendingScrooge.Services
{
    public class FileService
    {
        public static void ExportToCsv(List<Expense> expenses, string filePath)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Date,Category,Amount,Description");
            foreach (var expense in expenses)
            {
                sb.AppendLine($"{expense.ExpenseDate},{expense.ExpenseCategory},{expense.ExpenseAmount},{expense.ExpenseDescription}");
            }
            File.WriteAllText(filePath, sb.ToString());
        }

        public static List<Expense> ImportFromCsv(string filePath)
        {
            var expenses = new List<Expense>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines.Skip(1)) // Skip header when importing data
            {
                var values = line.Split(',');
                expenses.Add(new Expense
                {
                    ExpenseDate = DateTime.Parse(values[0]),
                    ExpenseCategory = values[1],
                    ExpenseAmount = decimal.Parse(values[2]),
                    ExpenseDescription = values[3]
                });
            }
            return expenses;
        }
    }

}
