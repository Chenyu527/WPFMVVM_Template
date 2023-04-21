using CommunityToolkit.Mvvm.DependencyInjection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using WPF.Models;
using WPF.ViewModels;

namespace WPF
{
    /// <summary>
    /// Interaction logic for Buildings.xaml
    /// </summary>
    public partial class RoomView : Page
    {
        public RoomView()
        {
            InitializeComponent();
            this.DataContext = Ioc.Default.GetService<RoomViewModel>();
        }
    }
}
