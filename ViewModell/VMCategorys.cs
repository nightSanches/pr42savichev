﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace pr42savichev.ViewModell
{
    public class VMCategorys : INotifyPropertyChanged
    {
        public ObservableCollection<Context.CategorysContext> Categorys { get; set; }

        public VMCategorys() => 
            Categorys = Context.CategorysContext.AllCategorys();

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
