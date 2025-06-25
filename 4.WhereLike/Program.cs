using System.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SQL_EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                Console.WriteLine("--- String Interpolation ---");
                Console.ReadKey();

                var name = "%Galaxy%";
                var price = 30000;
                var phones = db.Phones.FromSql($"SELECT * FROM Phones WHERE Name LIKE {name} AND Price > {price}").ToList();
                foreach (var phone in phones)
                {
                    Console.WriteLine(phone.Name);
                }

                Console.ReadKey();
            }
        }
    }
}
