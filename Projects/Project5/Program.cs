using System;
using System.Collections.Generic;

namespace Project5
{
    class Program
    {   // Aula sobre listas. 
        static void Main(string[] args)
        {

            List<string> list2 = new List<string> { "Maria", "Alex" };

            list2.Add("Anna");
            list2.Insert(2, "Pedro");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine($"-------------------------------------");
            Console.WriteLine($"A quantidade de elementos na lista é: {list2.Count}");

            string s1 = list2.Find(x => x[0] == 'A');
            string s2 = list2.FindLast(x => x[0] == 'A');

            Console.WriteLine($"O primeiro elemento na lista que inicia com a letra 'A' é: {s1}");
            Console.WriteLine($"O último elemento na lista que inicia com a letra 'A' é: {s2}");

            int pos1 = list2.FindIndex(x => x[0] == 'A');
            int pos2 = list2.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"A primeira posição em que tem um elemento na lista que inicia com a letra 'A' é: {pos1}");
            Console.WriteLine($"A última posição em que tem um elemento na lista que inicia com a letra 'A' é: {pos2}");

            List<string> list3 = list2.FindAll(x => x.Length == 5);
            Console.WriteLine($"--------------------------------");
            foreach (string obj in list3)
            {
                Console.WriteLine(obj);
            }

            list2.Remove("x");
            list2.RemoveAll(x => x[0] == 'M');
            list2.RemoveAt(2);
            list2.RemoveRange(2, 2);
        }
    }
}
