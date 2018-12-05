using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Plant carrot = new Plant("Carrot");
            Herbivore rabbit = new Herbivore("Rabbit");
            Carnivore snake = new Carnivore("Snake");
            carrot.Grow += ShowMessage;
            carrot.Grows();
            carrot.HasGrown();
            if (carrot.Grown)
            {
                rabbit.EatPlant += ShowMessage;
                rabbit.Eating(carrot.Kind);
            }
            if (rabbit.Eat)
            {
                snake.EatHerbivore += ShowMessage;
                snake.Eating(rabbit.Kind);
            }
            Console.ReadLine();
        } 

        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
