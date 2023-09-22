using BoBedre.RoomSpecifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Rooms
{
    internal abstract class Livingroom : IDoor, IFloor, IWindow
    {
        //make variables for floor, door and window
        protected string floor;
        protected string door;
        protected string window;

        //create the object "Livingroom"
        protected Livingroom(string floor, string door, string window)
        {
            this.floor = floor;
            this.door = door;
            this.window = window;
        }

        //get floor from the interface IFloor
        public string FloorName()
        {
            return floor;
        }

        //get door from the interface IDoor
        public string DoorName()
        {
            return door;
        }

        //get window from the interface IWindow
        public string WindowName()
        {
            return window;
        }
    }
}
