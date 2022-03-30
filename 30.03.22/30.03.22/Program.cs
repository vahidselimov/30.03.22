using System;

namespace _30._03._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple<string> apple = new Apple<string>("B,C");
            Lemon<string> lemon = new Lemon<string>("A, VI, V2, Z, S,C,R");
            Pineapple<char> pineapple = new Pineapple<char>('B');
            Console.WriteLine("Meyvelerin Vitaminleri:");
            Console.WriteLine(apple);
            Console.WriteLine(pineapple);
            Console.WriteLine(lemon);
            Console.WriteLine("\n   \n");
            Basketlist<string> basket = new Basketlist<string>();
            {
                basket.Add("Apple");
                basket.Add("Pineapple");
                basket.Add("Lemon");
                basket.Add("Palm");
                basket.Add("Raspberry");
                basket.Add("Banana");
                basket.Add("pomegranate");
                basket.Add("Pear");
                Console.WriteLine(" Fruit  List:  ");
                Console.WriteLine($"Fruit List count: {basket.Getcount}");
                Console.WriteLine("Fruit list elements:");
                foreach (string item in basket.GetFruits())
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
