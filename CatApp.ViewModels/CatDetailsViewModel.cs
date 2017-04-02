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

        public CatDetailsViewModel()
        {
        }

        private CatDataModel _currentCat;



        public void NavigatedTo(CatDetailsPageNavArgs args)
        {

        }

        public ICommand GoBackCommand   {get;}

        public ICommand ShowFactCommand { get; }
    }
}
