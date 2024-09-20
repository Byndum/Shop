using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Entities
{
    internal class GiftWrapping : Decorator
    {
        public GiftWrapping(IItem item) : base(item)
        {
        }
        public override string getDesc()
        {
            return base.getDesc() + ", with Gift wrapping";
        }
        public override double getPrice()
        {
            return base.getPrice() + 5.00;
        }
    }
}
