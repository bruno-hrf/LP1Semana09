using System;

namespace AnimInterf
{
    public class Dog : Animal, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }

        public int NumberOfNipples => 8;
    }
    
}
