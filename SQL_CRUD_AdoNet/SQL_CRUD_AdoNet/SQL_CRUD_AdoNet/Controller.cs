using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_CRUD_AdoNet
{
    internal class Controller
    {
        public static int GetMenuAnswer()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static DatabaseRecord GetDatabaseRecordFromUser()
        {
            string name = "test", color = "test";
            bool isFruit = false;
            int calories = 100;

            Console.WriteLine("Enter name of fruit/vegatable: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter color of fruit/vegatable: ");
            color = Console.ReadLine();

            Console.WriteLine("Enter count carories in fruit/vegatable: ");
            calories = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter true - if it fruit or false - if it vegetable: ");
            isFruit = Convert.ToBoolean(Console.ReadLine());

            return new DatabaseRecord(name, isFruit, color, calories);
        }

        public static int GetIdFromUser()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
