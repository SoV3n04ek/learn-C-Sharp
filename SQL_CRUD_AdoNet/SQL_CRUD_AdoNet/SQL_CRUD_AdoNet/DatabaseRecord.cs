using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_CRUD_AdoNet
{
    internal class DatabaseRecord
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool isFruit { get; set; }
        public string color { get; set; }
        public int calories { get; set; }

        public DatabaseRecord(string _name, bool _isFruit, string _color, int _calories, int _id = 0)
        {
            name = _name;
            isFruit = _isFruit;
            color = _color;
            calories = _calories;
        }
    }
}
