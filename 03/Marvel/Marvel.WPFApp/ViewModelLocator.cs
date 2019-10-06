using Marvel.WPFApp.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.WPFApp
{
    public class ViewModelLocator
    {
        public MainViewModel Main
        {
            get
            {
                return App.ServiceProvider.GetRequiredService<MainViewModel>();
            }
        }
    }
}
