using System.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SQL_EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context db = new Context())
            {
                //вставка
                string htc = "htc";
                int numberOfRowInserted = db.Database.ExecuteSqlInterpolated($"INSERT INTO Companies (Name,CountryId) VALUES ({htc},{2})");///для інтерпольованих строк

                //// обновление  
                string nokia = "Nokia";
                int id = 9;
                int numberOfRowUpdated = db.Database.ExecuteSqlRaw("UPDATE Companies SET Name={0} WHERE Id={1}", nokia, id);

                //// удаление
                int numberOfRowDeleted = db.Database.ExecuteSqlRaw("DELETE FROM Companies WHERE Id={0}", id);////  для форматованих строк

                Console.ReadKey();
            }
        }
    }
}
