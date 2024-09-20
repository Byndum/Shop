using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Entities
{
    public interface IItem
    {
        public abstract string getDesc();
        public abstract double getPrice();
    }
}
