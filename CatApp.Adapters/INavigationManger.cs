using System;
using System.Collections.Generic;
using System.Text;
using CatApp.Models.Enums;

namespace CatApp.Adapters
{
    public interface INavigationManger
    {
        void Navigate(PageIndex page,object args);
        void GoBack();
    }
}
