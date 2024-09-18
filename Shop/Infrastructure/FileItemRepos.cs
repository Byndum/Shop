using Shop.Domain;
using Shop.InterfaceAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructur
{
    class FileItemRepos : IItemsRepos
    {
        private readonly string _filePath;
        public FileItemRepos(string filePath) 
        {
            _filePath = filePath;
        }

        public List<Item> LoadItems()
        {
            List<Item> items = new List<Item>();
            var lines = File.ReadAllLines(_filePath);

            foreach (var line in lines)
            {
                if (lines[0] != line)
                {
                    var data = line.Split(',');
                    items.Add(new Item(data[0], data[1], Double.Parse(data[2])));
                }
            }
            return items;
        }
    }
}
