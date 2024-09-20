using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Entities
{
    abstract class Decorator : IItem
    {
        protected IItem _item;

        public Decorator(IItem item) 
        {
            this._item = item;
        }

        public virtual string getDesc()
        {
            return _item.getDesc();
        }

        public virtual double getPrice()
        {
            return _item.getPrice();
        }
    }
}
