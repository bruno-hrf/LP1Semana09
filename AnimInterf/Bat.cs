using System;

namespace AnimInterf
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Ti Ti Ti";
        }
        public int NumberOfNipples => 4;

        public int NumberOfWings => 2;
    }
}
