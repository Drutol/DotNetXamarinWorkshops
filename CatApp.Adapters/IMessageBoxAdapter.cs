using System;
using System.Collections.Generic;
using System.Text;

namespace CatApp.Adapters
{
    public interface IMessageBoxAdapter
    {
        void ShowMessageDialog(string title, string content);
    }
}
