using Shop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.InterfaceAdapter
{
    public interface IItemsRepos
    {
        List<Item> LoadItems();
    }
}
