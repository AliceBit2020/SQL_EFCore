using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SQL_EFCore

{
    class Program
    {
        
        static void Main(string[] args)
        {
            using (Context db = new Context())
            {
                Console.WriteLine("--- SqlParameter: #1 ---");
                Console.ReadKey();

                SqlParameter param = new SqlParameter("@name", "%Galaxy%");
                var phones1 = db.Phones.FromSqlRaw("SELECT * FROM Phones WHERE Name LIKE @name", param).ToList();
                foreach (var phone in phones1)
                {
                    Console.WriteLine(phone.Name);
                }

                Console.WriteLine("--- SqlParameter: #2 ---");
                Console.ReadKey();

                var name = "%Galaxy%";
                var phones2 = db.Phones.FromSqlRaw("SELECT * FROM Phones WHERE Name LIKE {0}", name).ToList();
                foreach (var phone in phones2)
                {
                    Console.WriteLine(phone.Name);
                }

                Console.WriteLine("--- SqlParameter: #3 ---");
                Console.ReadKey();

                var price = 30000;
                var phones3 = db.Phones.FromSqlRaw("SELECT * FROM Phones WHERE Price > {0}", price).ToList();
                foreach (var phone in phones3)
                {
                    Console.WriteLine(phone.Name);
                }

                Console.WriteLine("--- Finish ---");
                Console.ReadKey();
            }
        }
    }
}
