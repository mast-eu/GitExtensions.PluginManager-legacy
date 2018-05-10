﻿using Neptuo;
using Neptuo.Observables;
using Neptuo.Observables.Collections;
using Neptuo.Observables.Commands;
using PackageManager.Models;
using PackageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PackageManager.ViewModels
{
    public class BrowserViewModel : ObservableObject
    {
        private string source;
        public string Source
        {
            get { return source; }
            set
            {
                if (source != value)
                {
                    source = value;
                    RaisePropertyChanged();
                }
            }
        }

        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                if (searchText != value)
                {
                    searchText = value;
                    RaisePropertyChanged();
                }
            }
        }

        public ObservableCollection<IPackage> Packages { get; }
        public ICommand Search { get; }

        public BrowserViewModel(ISearchService search)
        {
            Packages = new ObservableCollection<IPackage>();
            Search = new SearchCommand(this, search);
        }
    }
}
