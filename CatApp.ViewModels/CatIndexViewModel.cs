using System.Collections.ObjectModel;
using System.Windows.Input;
using CatApp.Adapters;
using CatApp.BL.Interfaces;
using CatApp.Models;
using CatApp.Models.Enums;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace CatApp.ViewModels
{
    public class CatIndexViewModel : ViewModelBase
    {
        private readonly ICatDataProvider _catDataProvider;
        private readonly INavigationManger _navigationManger;

        public CatIndexViewModel()
        {

        }

        private bool _loading;
        private ObservableCollection<CatDataModel> _cats;

        public async void NavigatedTo()
        {

        }





        public ICommand NavigateDetailsCommand { get; }
            
    }
}
