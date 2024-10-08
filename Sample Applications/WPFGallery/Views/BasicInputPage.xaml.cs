﻿using System.Windows.Documents;
using System.Windows.Navigation;
using System.Windows.Shapes;

using WPFGallery.ViewModels;
namespace WPFGallery.Views
{
    /// <summary>
    /// Interaction logic for BasicInputPage.xaml
    /// </summary>
    public partial class BasicInputPage : Page
    {
        public BasicInputPageViewModel ViewModel { get; } 
		public BasicInputPage(BasicInputPageViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
            DataContext = this;
        }
    }
}
