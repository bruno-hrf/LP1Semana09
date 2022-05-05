using System;

namespace AnimInterf
{
    public class Bee : Animal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Bzzz";
        }
        public int NumberOfWings => 2;
    }
}
