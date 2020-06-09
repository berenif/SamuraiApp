using System;
using System.Linq;
using SamuraiApp.Data;
using SamuraiApp.Domain;

namespace ConsoleApp
{
    class Program
    {
        private static SamuraiContext context = new SamuraiContext();

        static void Main(string[] args)
        {

            context.Database.EnsureDeleted();

            context.Database.EnsureCreated();

            Console.WriteLine("Hello World!");

            GetSamurais();
            AddSamurai();
            GetSamurais();
        }

        static void AddSamurai()
        {
            var samurai = new Samurai { Name = "Jean" };

            context.Add(samurai);
            context.SaveChanges();
        }

        static void GetSamurais()
        {
            var samurais = context.Samurais.ToList();

            System.Console.WriteLine($"There is currently {samurais.Count}");

            foreach (var item in samurais)
            {
                System.Console.WriteLine(item.Name);
            }
        }
    }
}
