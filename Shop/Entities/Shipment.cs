using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Entities
{
    internal class Shipment : Decorator
    {
        public Shipment(IItem item) : base(item)
        {
        }
        public override string getDesc()
        {
            return base.getDesc() + ", getting shipped to your home address";
        }
        public override double getPrice()
        {
            return base.getPrice() + 20.00;
        }
    }
}
