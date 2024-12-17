using GalaSoft.MvvmLight.Command;
using SpendingScrooge.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SpendingScrooge.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Expense> _expenses;

        public ObservableCollection<Expense> Expenses
        {
            get { return _expenses; }
            set { _expenses = value; OnPropertyChanged(); }
        }

        public ICommand AddExpenseCommand { get; set; }

        public MainViewModel()
        {
            Expenses = new ObservableCollection<Expense>();
            // AddExpense...
        }

        /// <summary>
        /// Add an expense to the list
        /// </summary>
        /// <param name="parameter"></param>
        private void AddExpense(object parameter)
        {
            Expenses.Add(new Expense());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
