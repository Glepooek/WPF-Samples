using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentControlStyle
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private PersonViewModel viewModel;
        public PersonViewModel CurrentPersonVM
        {
            get => viewModel;
            set
            {
                viewModel = value;
                RaisePropertyChanged();
            }
        }

        public MainWindowViewModel() 
            => CurrentPersonVM = new StudentViewModel();
    }
}
