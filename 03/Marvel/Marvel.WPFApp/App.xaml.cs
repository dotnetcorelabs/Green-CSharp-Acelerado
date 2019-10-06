using Marvel.Domain.Services;
using Marvel.WPFApp.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Windows;
using Marvel.WPFApp.Helpers;
using Marvel.WPFApp.ViewModels;

namespace Marvel.WPFApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        internal static readonly string MARVEL_PUBLIC_KEY = "";

        internal static readonly string MARVEL_PRIVATE_KEY = "";

        internal static readonly IServiceProvider ServiceProvider;

        static App()
        {
            MARVEL_PUBLIC_KEY = ConfigurationManager.AppSettings["MarvelPublicKey"];
            MARVEL_PRIVATE_KEY = ConfigurationManager.AppSettings["MarvelPrivateKey"];

            ServiceCollection services = new ServiceCollection();

            services.AddLogging(opts =>
            {
                opts.AddDebug();
            });

            services.AddHttpClient<MarvelHttpService>();
            services.AddTransient<MainViewModel>();

            if (DesignHelper.IsDesign)
                services.AddTransient<IPersonagemRepositorio, MockPersonagemRepositorio>();
            else
                services.AddTransient<IPersonagemRepositorio>(ctx => ctx.GetRequiredService<MarvelHttpService>());

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
