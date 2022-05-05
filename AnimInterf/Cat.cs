using System;

namespace AnimInterf
{
    public class Cat : Animal, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }

        public int NumberOfNipples => 8;
        public int NumberOfWings => 2;
    }
}
