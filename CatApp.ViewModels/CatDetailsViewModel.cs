using System.Windows.Input;
using CatApp.Adapters;
using CatApp.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace CatApp.ViewModels
{
    public class CatDetailsViewModel : ViewModelBase
    {
        private readonly INavigationManger _navigationManger;
        private readonly IMessageBoxAdapter _messageBoxAdapter;

        public CatDetailsViewModel(INavigationManger navigationManger,IMessageBoxAdapter messageBoxAdapter)
        {
            _navigationManger = navigationManger;
            _messageBoxAdapter = messageBoxAdapter;
        }

        private CatDataModel _currentCat;

        public CatDataModel CurrentCat
        {
            get { return _currentCat; }
            set
            {
                _currentCat = value;
                RaisePropertyChanged();
            }
        }

        public void NavigatedTo(CatDetailsPageNavArgs args)
        {
            CurrentCat = args.Model;
        }

        public ICommand GoBackCommand => new RelayCommand(() => _navigationManger.GoBack());

        public ICommand ShowFactCommand => new RelayCommand(() => _messageBoxAdapter.ShowMessageDialog("Fact",CurrentCat.Fact));
    }
}
