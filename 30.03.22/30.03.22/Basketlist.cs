using System;
using System.Collections.Generic;
using System.Text;

namespace _30._03._22
{
    class Basketlist<V>
    {
        public V[] Fruits;
        public int count;
        public int Getcount { get => Fruits.Length; }      

        public Basketlist()
        {
            Fruits = new V [0];

        }
        public V[] GetFruits()
        {
            return Fruits;

        }
        public void Add(V Fruit)
        {
            Array.Resize(ref Fruits, Fruits.Length + 1);
            Fruits[Fruits.Length - 1] = Fruit;
        }
    }

}
