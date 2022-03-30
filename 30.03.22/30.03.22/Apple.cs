using System;
using System.Collections.Generic;
using System.Text;

namespace _30._03._22
{
     class Apple<V>
     {
        private V Vitamin;
         public Apple (V Vitamins)
         {
            Vitamin = Vitamins;


         }
        public override string ToString()
        {
            return $"Apple Vitamins:{ Vitamin}";

        }
    }
}
