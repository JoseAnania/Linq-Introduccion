using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroduccionLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I Love Cats!!";
            string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Nina", "Loki", "Janis" };
            int[] numbers = { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };

            Console.WriteLine("1) Obtener todos los números:");
            
            var getTheNumbers = from x in numbers
                                select x;
            
            Console.WriteLine(string.Join(", ", getTheNumbers));
            Console.WriteLine("-----------------");

            Console.WriteLine("2) Obtener los números menores que 5:");

            var getOlderThan5 = from x in numbers
                                where x < 5
                                select x;

            Console.WriteLine(string.Join(", ", getOlderThan5));
            Console.WriteLine("-----------------");

            Console.WriteLine("3) Obtener los mayores que 5 usando List<>");

            List<int> otherWay = new List<int>();
            foreach (var x in numbers)
            {
                if (x < 5)
                {
                    otherWay.Add(x);
                }
            }
            Console.WriteLine(string.Join(", ", otherWay));
            Console.WriteLine("-----------------");

            Console.WriteLine("4) Mostrar el mensaje inicial");

            var simpleLinq = from x in sentence
                             select x;
            Console.WriteLine(string.Join(" ", simpleLinq));
            Console.WriteLine("-----------------");

            Console.WriteLine("5) Mostrar los nombres de gatos que contengan A");

            var catsWithA = from x in catNames
                            where x.Contains("a")
                            select x;
            Console.WriteLine(string.Join(", ", catsWithA));
            Console.WriteLine("-----------------");

            Console.WriteLine("6) Mostrar los nombres de gatos que contengan A y tenga menos de 5 caracteres");

            var catsWithAand5 = from x in catNames
                            where (x.Contains("a")) && (x.Length < 5)
                            select x;
            Console.WriteLine(string.Join(", ", catsWithAand5));
            Console.WriteLine("-----------------");

            Console.WriteLine("7) Mostrar los números entre 5 y 10 ordenados");

            var numbersBetween5and10 = from x in numbers
                                       where (x >= 5) && (x <= 10)
                                       orderby x
                                       select x;
            Console.WriteLine(string.Join(", ", numbersBetween5and10));
            Console.WriteLine("-----------------");
        }
    }
}
