using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF.Models;

namespace WPF.ViewModels
{
    public partial class RoomViewModel : ObservableObject
    {
        public RoomViewModel()
        {
            room = Ioc.Default.GetService<IGenerateRoom>().GenerateRoomModel();
        }

        /// 参数
        [ObservableProperty]
        private RoomModel room;

        /// 命令
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(MyCommandCommand))] //通知修改command的CanExecute变为可执行
        private bool isEnable;

        [RelayCommand(CanExecute = nameof(CanButtonClick))] // 指定可执行属性
        private async Task MyCommand()
        {
            await Task.Run(() =>
            {
                MessageBox.Show("successful");
            });
        }
        private bool CanButtonClick() => IsEnable;
    }   
}
