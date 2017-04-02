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

        public CatIndexViewModel(ICatDataProvider catDataProvider,INavigationManger navigationManger)
        {
            _catDataProvider = catDataProvider;
            _navigationManger = navigationManger;
        }

        private bool _loading;
        private ObservableCollection<CatDataModel> _cats;

        public async void NavigatedTo()
        {
            if (Cats == null)
            {
                Loading = true;
                Cats = new ObservableCollection<CatDataModel>(await _catDataProvider.GetCatData());
                Loading = false;
            }
        }

        public bool Loading
        {
            get { return _loading; }
            set
            {
                _loading = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<CatDataModel> Cats
        {
            get { return _cats; }
            set
            {
                _cats = value;
                RaisePropertyChanged();
            }
        }

        public ICommand NavigateDetailsCommand
            =>
                new RelayCommand<CatDataModel>(
                    model =>
                        _navigationManger.Navigate(PageIndex.DetailsPage, new CatDetailsPageNavArgs {Model = model}));
    }
}
