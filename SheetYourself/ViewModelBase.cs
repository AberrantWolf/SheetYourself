﻿using Nito.Mvvm.CalculatedProperties;
using System.ComponentModel;

namespace SheetYourself
{
    internal class ViewModelBase : INotifyPropertyChanged
    {
        protected readonly PropertyHelper Properties;

        protected ViewModelBase()
        {
            Properties = new PropertyHelper(RaisePropertyChanged);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged(PropertyChangedEventArgs args)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, args);
            }
        }
    }
}
