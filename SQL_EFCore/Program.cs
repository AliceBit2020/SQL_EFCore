using System;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace SQL_EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                Console.WriteLine("--- FromSql: #1 ---");
                Console.ReadKey();

                var companies = db.Companies.FromSqlRaw("SELECT * FROM Companies ").ToList();
                foreach (var company in companies)
                {
                    Console.WriteLine(company.Name);
                }

                Console.WriteLine("--- FromSql: #2 ---");
                Console.ReadKey();
                var companies2 = db.Companies.FromSqlRaw("SELECT * FROM Companies ").OrderBy(x => x.Name).ToList();
                foreach (var company in companies2)
                {
                    Console.WriteLine(company.Name);
                }

                Console.WriteLine("--- Finish ---");
                Console.ReadKey();
            }
        }
    }
}
