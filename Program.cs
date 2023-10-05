using System;
namespace oop{ 
internal class Program
{
        static void Main(string[] args)
        {
            avto car = new avto();
            car.info(car);
            car.infoOut();
            string y_n = "";
            if (car.will_he_get_there() == true)
            {
                Console.WriteLine("Вы не сможете доехать до назначенного местаю\n Хотите заправиться(y/n)? ");
                y_n = Console.ReadLine();
            }

            if (y_n == "y")
            {
                car.zapravka();
            }
            if (y_n == "n")
                Console.WriteLine("Вы не сможете доехать");
            car.drive();


        }

    }
}
