using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace LoginAppMVVM_0._2.ViewModels
{
    class MainViewModel
    {
        private string _displayName = "Main page";

        private readonly IWindowManager _windowManager;

        [ImportingConstructor]
        public MainViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;
        }

        public string DisplayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        }
    }
}
