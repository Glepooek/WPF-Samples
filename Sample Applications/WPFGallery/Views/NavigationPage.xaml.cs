﻿using System.Windows.Documents;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFGallery.ViewModels;

namespace WPFGallery.Views
{
    /// <summary>
    /// Interaction logic for NavigationPage.xaml
    /// </summary>
    public partial class NavigationPage : Page
    {
        public NavigationPageViewModel ViewModel { get; } 
		public NavigationPage(NavigationPageViewModel viewModel)
        {
            InitializeComponent();
             ViewModel = viewModel;
            DataContext = this;
       }
    }
}
