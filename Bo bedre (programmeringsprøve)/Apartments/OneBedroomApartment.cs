using BoBedre.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Apartments
{
    internal class OneBedroomApartment : Apartment
    {
        private protected OneBedroomApartment(Bathroom bathroom, Bedroom bedroom, Kitchen kitchen, Livingroom livingroom) : base(bathroom, bedroom, kitchen, livingroom)
        {
            //1 bathroom, 0 bedroom, 1 kitchen, 1 livingroom
            Apartment OneBedroom = new OneBedroomApartmen
        }
    }
}
