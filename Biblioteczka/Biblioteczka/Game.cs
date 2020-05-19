using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteczka
{
    public class Game : LibraryObject
    {
        public int _ageLimit;
        public string _title;

        public Game(string title, int ageLimit, decimal price, string description) :base(price, description)
        {
            _title = title;
            _ageLimit = ageLimit;
        }

        public override string ToString()
        {
            return _title;
        }

        public void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Latandu\Documents\biblioteka.txt", true))
            {
                sw.WriteLine("{0}|{1}|{2}|{3}", _title, _ageLimit, _price, _description);
            }
        }
    }
}
