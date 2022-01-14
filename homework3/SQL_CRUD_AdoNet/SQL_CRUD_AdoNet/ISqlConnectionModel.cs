using System;



namespace SQL_CRUD_AdoNet
{
    interface ISqlConnectionModel
    {
        void Add();
        void Edit(int id);
        void Delete(int id);
    }
}
