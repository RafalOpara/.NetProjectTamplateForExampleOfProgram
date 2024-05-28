using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Windows;
using WpfApp4.Database;
using WpfApp4.Domain.Interfaces;
using WpfApp4.Services;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);


            var servicesCollection = new ServiceCollection();

            servicesCollection.AddTransient<IDataStoreManager, DataStoreManager>();
            servicesCollection.AddTransient<ICalculatorManager, CalculatorManager>();
        }

      

    }

}
