using System;

namespace AnimInterf
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Animal[] animals = new Animal[10];

            Random random = new Random();

            for (int i = 0; i<10; i++)
            {
                int a = random.Next(4);
                switch (a)
                {
                    case 0:
                        animals[i] = new Bat();
                        break;
                    case 1:
                        animals[i] = new Bee();
                        break;
                    case 2:
                        animals[i] = new Cat();
                        break;
                    case 3:
                        animals[i] = new Dog();
                        break;
                }

                 

            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Sound());

                if (animal is IMammal)
                {

                    IMammal mammal = animal as IMammal;
                    Console.WriteLine($"\tnipples =  {mammal.NumberOfNipples}");
                }
                if (animal is ICanFly)
                {

                    ICanFly flier  = animal as ICanFly;
                    Console.WriteLine($"\twings =  {flier.NumberOfWings}");
                }
            }

        }

    }
}
