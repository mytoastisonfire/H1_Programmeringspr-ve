using BoBedre.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Apartments
{
    internal abstract class Apartment
    {
        //Gets a bathroom, bedroom, kitchen and livingroom to make an appartment
        protected Bathroom Bathroom { get; set; }
        protected Bedroom Bedroom { get; set; }
        protected Kitchen Kitchen { get; set; }
        protected Livingroom Livingroom { get; set; }


        //makes and appartment with the rooms
        internal Apartment(Bathroom bathroom, Bedroom bedroom, Kitchen kitchen, Livingroom livingroom)
        {
            this.Bathroom = bathroom;
            this.Bedroom = bedroom;
            this.Kitchen = kitchen;
            this.Livingroom = livingroom;
        }
    }
}
