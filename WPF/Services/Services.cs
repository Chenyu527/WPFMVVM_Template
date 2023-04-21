using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Models;

namespace WPF
{
    public interface IGenerateRoom
    {
        RoomModel GenerateRoomModel();
    }
    public class MyServices : IGenerateRoom
    {
        public RoomModel GenerateRoomModel()
        {
            return new RoomModel()
            {
                Height = 5,
                Width = 5
            };
        }
    }
}
