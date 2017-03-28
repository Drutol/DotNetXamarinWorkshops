using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace MvvmStarter.ViewModel
{
    public class ViewModelLocator
    {
        public static void RegisterDependencies()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
        }

        public static MainViewModel MainViewModel => SimpleIoc.Default.GetInstance<MainViewModel>();
    }
}
