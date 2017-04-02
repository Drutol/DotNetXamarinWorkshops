using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using CatApp.Adapters;

namespace CatApp.UWP.Adapters
{
    public class MessageBoxAdapter : IMessageBoxAdapter
    {
        public async void ShowMessageDialog(string title, string content)
        {
            await new MessageDialog(content, title).ShowAsync();
        }
    }
}
