using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CatApp.Models;

namespace CatApp.BL.Interfaces
{
    public interface ICatDataProvider
    {
        Task<List<CatDataModel>> GetCatData();
    }
}
