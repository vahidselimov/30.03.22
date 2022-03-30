using System;
using System.Collections;

namespace _30._03._22.task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList Planguage = new SortedList();
            Planguage.Add(1998, "C");
            Planguage.Add(2000, "C#");
            Planguage.Add(1984, "Matlab");
            Planguage.Add(1990, "Python");
            Planguage.Add(1982, "C++");
            Console.WriteLine("Illere Gore:");
            foreach (DictionaryEntry item in Planguage)
            {
                Console.WriteLine(item.Key + " - " + item.Value);

            }
            Console.WriteLine("\n....\n");
            SortedList Planguage1 = new SortedList();
            Planguage1.Add(1998, "C");
            Planguage1.Add(2000, "C#");
            Planguage1.Add(1984, "Matlab");
            Planguage1.Add(1990, "Python");
            Planguage1.Add(1982, "C++");
            Console.WriteLine("Adlara gore");
            foreach  (DictionaryEntry  item in Planguage1)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
            

            




        }
    }
}
