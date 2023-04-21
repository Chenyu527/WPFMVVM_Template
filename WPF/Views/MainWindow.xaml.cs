using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using WPF.ViewModels;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            ConfigureServices();
            InitializeComponent();
            Main.Content = Ioc.Default.GetService<RoomView>();
        }

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services
                .AddSingleton<RoomViewModel>()
                .AddSingleton<RoomView>()
                .AddSingleton<IGenerateRoom, MyServices>();
            
            Ioc.Default.ConfigureServices(services.BuildServiceProvider());

        }
    }
}
