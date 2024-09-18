using Shop.Domain;
using Shop.InterfaceAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application
{
    public class LoadItemsUseCase
    {
        private readonly IItemsRepos _itemRepos;
        public LoadItemsUseCase(IItemsRepos itemsRepos) 
        {
            _itemRepos = itemsRepos;
        }

        public List<Item> Execute() 
        {
            return _itemRepos.LoadItems();
        }
    }
}
