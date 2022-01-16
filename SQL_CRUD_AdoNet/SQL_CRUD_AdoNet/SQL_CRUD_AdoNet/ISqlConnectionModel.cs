using System;

namespace SQL_CRUD_AdoNet
{
    interface ISqlConnectionModel
    {
        public int Add(string name, bool isFruit, string color, int colories);
        public int Edit(string name, bool isFruit, string color, int colories, int id);
        public int Delete(int id);
    }
}
