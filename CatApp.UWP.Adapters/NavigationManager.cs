using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatApp.Adapters;
using CatApp.Models.Enums;

namespace CatApp.UWP.Adapters
{
    public class NavigationManager : INavigationManger
    {
        public event EventHandler<Tuple<PageIndex,object>> NavigationRequested; 
        public event EventHandler GoBackRequested; 

        public void Navigate(PageIndex page,object args)
        {
            NavigationRequested?.Invoke(this,new Tuple<PageIndex, object>(page,args));
        }

        public void GoBack()
        {
            GoBackRequested?.Invoke(this,EventArgs.Empty);
        }
    }
}
