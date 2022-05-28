using System;

namespace Lesson_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаю переменный
            string name;
            int age;
            int growth;
            double gradeHistory;
            double gradeMath;
            double gradeRussianLanguage;
            double midlleGrade;

            //Запрашиваю данные от пользователя
            Console.WriteLine("Введите своё имя");
            name=Console.ReadLine();
            Console.WriteLine("Введите свой возраст");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите свой рост");
            growth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите свой бал по истории");
            gradeHistory = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите свой бал по математике");
            gradeMath = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите свой бал по русскому языку");
            gradeRussianLanguage = Convert.ToDouble(Console.ReadLine());

           /* Вычисляю среднюю оценку
             */
            midlleGrade = (gradeHistory + gradeMath + gradeRussianLanguage) / 3;

            

            //вывожу на экран результаты
            Console.WriteLine("Имя: "+name+"\nВозраст: "+age);
            Console.WriteLine("Бал по истории: {0} \nБал по математике {1} \nБал по рускому языку: {2} ",gradeHistory,gradeMath,gradeRussianLanguage);
            Console.WriteLine($"Средний бал: {midlleGrade}");


            Console.ReadKey();
        }
    }
}
