using CatApp.BL.Classes;
using CatApp.BL.Interfaces;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace CatApp.ViewModels
{
    public class ViewModelLocator
    {
        public static void RegisterDependencies()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<CatDetailsViewModel>();
            SimpleIoc.Default.Register<CatIndexViewModel>();

            SimpleIoc.Default.Register<ICatDataProvider,CatDataProvider>();
        }

        public static CatIndexViewModel CatIndex => SimpleIoc.Default.GetInstance<CatIndexViewModel>();
        public static CatDetailsViewModel CatDetails=> SimpleIoc.Default.GetInstance<CatDetailsViewModel>();
    }
}
