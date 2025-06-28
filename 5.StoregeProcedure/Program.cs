using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace SQL_EFCore
{
    class Foo
    {
        public Foo() { }
    }
    class Program
    {
        struct Str
        {
            public Str(string s) { }
        }
        static void Main(string[] args)
        {
            using (Context db = new Context())
            {
                Console.WriteLine("--- Stored Procedures ---");


                //SqlParameter param1 = new SqlParameter("@name", "Sumsung");
                //var phones = db.Phones.FromSqlRaw("GetPhonesByCompany @name", param1).ToList();
                //foreach (var p in phones)
                //{
                //    Console.WriteLine($"{p.Name} - {p.Price}");
                //}

                //Console.WriteLine("--- OUTPUT ---");
                //Console.ReadKey();

                //var param2 = new SqlParameter
                //{
                //    ParameterName = "@phoneName",
                //    SqlDbType = SqlDbType.VarChar,
                //    Direction = ParameterDirection.Output,
                //    Size = 50
                //};
                //db.Database.ExecuteSqlRaw("GetPhoneWithMaxPrice @phoneName OUT", param2);
                //Console.WriteLine(param2.Value);
            }
        }
    }
}




//CREATE PROCEDURE[dbo].[GetPhonesByCompany]
//@name nvarchar(50)
//AS
//SELECT* FROM Phones
//WHERE CompanyId=(SELECT Id FROM Companies WHERE Name=@name)
//GO