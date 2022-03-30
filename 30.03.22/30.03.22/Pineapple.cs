using System;
using System.Collections.Generic;
using System.Text;

namespace _30._03._22
{
     class Pineapple<V>
    {
        private V Vitamins;


        public Pineapple(V vitamin)
        {
            Vitamins = vitamin;

        }
        public override string ToString()
        {
            return $"Pineapple Vitamins: {Vitamins}";


        }
    }
}
