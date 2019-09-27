using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CashMoney.Models;

namespace CashMoney.ViewModels
{

    class AccountModelView : INotifyPropertyChanged
    {
       private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public decimal _TotalAmount;
        public decimal TotalAmount
        {
            get
            {
                return _TotalAmount;
            }
            set
            {
                this._TotalAmount = value;
                OnPropertyChanged(nameof(TotalAmount));
            }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
