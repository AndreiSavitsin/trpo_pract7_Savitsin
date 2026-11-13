using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace trpo_pract7_Savitsin.Models
{
    public class Deposit : INotifyPropertyChanged
    {
        private string _clientName;
        public string ClientName
        {
            get => _clientName;
            set
            {
                if (_clientName != value)
                {
                    _clientName = value;
                    OnPropertyChanged();
                }
            }
        }
        private double _amount;
        public double Amount
        {
            get => _amount;
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Income));
                }
            }
        }
        private double _annualRate;
        public double AnnualRate
        {
            get => _annualRate;
            set
            {
                if (_annualRate != value)
                {
                    _annualRate = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Income));
                }
            }
        }
        private int _months;
        public int Months
        {
            get => _months;
            set
            {
                if (_months != value)
                {
                    _months = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Income));
                }
            }
        }
        public double Income
        {
            get
            {
                var _income = Amount * (AnnualRate / 100) * (Months / 12);
                return _income;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }    
}
