using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using CatApp.Adapters;
using CatApp.Models.Enums;
using CatApp.UWP.Adapters;
using CatApp.UWP.Pages;
using GalaSoft.MvvmLight.Ioc;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CatApp.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private NavigationManager _navigationManager;

        public MainPage()
        {
            _navigationManager = SimpleIoc.Default.GetInstance<INavigationManger>() as NavigationManager;
            _navigationManager.NavigationRequested += NavigationManagerOnNavigationRequested;
            _navigationManager.GoBackRequested += NavigationManagerOnGoBackRequested;
            this.InitializeComponent();

            _navigationManager.Navigate(PageIndex.IndexPage,null);
        }

        private void NavigationManagerOnGoBackRequested(object sender, EventArgs eventArgs)
        {
            RootFrame.GoBack();
        }

        private void NavigationManagerOnNavigationRequested(object sender, Tuple<PageIndex,object> arg)
        {
            switch (arg.Item1)
            {
                case PageIndex.IndexPage:
                    RootFrame.Navigate(typeof(CatIndexPage),arg.Item2);
                    break;
                case PageIndex.DetailsPage:
                    RootFrame.Navigate(typeof(CatDetailsPage),arg.Item2);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(arg), arg, null);
            }
        }

    }
}
