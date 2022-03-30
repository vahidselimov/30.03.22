using System;
using System.Collections.Generic;
using System.Text;

namespace _30._03._22
{
    class Lemon<V>
    {
        private V Vitamins;


        public Lemon(V vitamin)
        {
            Vitamins = vitamin;

        }
        public override string ToString()
        {
            return $"Lemon Vitamins: {Vitamins}";


        }



    }

}

