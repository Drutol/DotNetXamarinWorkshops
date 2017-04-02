﻿using CatApp.BL.Classes;
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


        }

        public static CatIndexViewModel CatIndex => SimpleIoc.Default.GetInstance<CatIndexViewModel>();
        public static CatDetailsViewModel CatDetails=> SimpleIoc.Default.GetInstance<CatDetailsViewModel>();
    }
}
