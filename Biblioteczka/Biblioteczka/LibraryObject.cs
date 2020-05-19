using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteczka
{
    
    public class LibraryObject
    {
        public decimal _price;
        public string _description;

        public LibraryObject(decimal price, string description)
        {
            _price = price;
            _description = description;
        }
    }
}
