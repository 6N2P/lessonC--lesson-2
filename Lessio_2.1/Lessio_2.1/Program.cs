using System;

namespace Lessio_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Иванов Сергей Владимирович";            
            int age = 32;
            string email = "sergey@mail.ru";
            double balyProgram = 5.8;
            double balyMath = 4.6;
            double balyPhysics = 2.5;
            double sum;
            double middleBal;

            string patern = "Имя: {0};\nВозраст: {1};\nПочта: {2};\nБаллы по программированию: {3};" +
                "\nБаллы по математематике: {4};\nБаллы по физике: {5};";

            Console.WriteLine(patern, fullName, age, email, balyProgram, balyMath, balyPhysics);
            Console.ReadKey();

            sum = balyProgram + balyMath + balyPhysics;
            string dFormted = sum.ToString("#.#");
            middleBal = sum / 3;

            Console.WriteLine("Сумма балов: " + dFormted);
            Console.ReadKey();
            Console.WriteLine("Среднее арифметическое значение: {0}",middleBal);

        }
    }
}
