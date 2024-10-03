using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Entities
{
    public interface IPDFBuilder
    {
        void CreatePDF();
        void SetTitle(string str);
        void AddPage();
        void AddItem(string desc, double price);
    }
}
