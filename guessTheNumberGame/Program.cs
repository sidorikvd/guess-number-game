using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessTheNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userMinValue;
            int userMaxValue;
            int userMaxQuantityAttemps;
            int userAnswer;
            int randomNumber;

            Console.WriteLine("Приветствуем тебя в игре Случайное число!");
            Console.WriteLine("Но для начала проведем небольшие настройки:");
            Console.Write("Напиши минимальное число: ");
            userMinValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Напиши максимальное число: ");
            userMaxValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Напиши кол-во попыток: ");
            userMaxQuantityAttemps = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            randomNumber = random.Next(userMinValue, userMaxValue);

            Console.Clear();
            Console.WriteLine($"Поехали! Мы загадали число от {userMinValue} до {userMaxValue}. Ваша задача его угадать, у вас {userMaxQuantityAttemps} попыток");

            while(userMaxQuantityAttemps > 0)
            {
                Console.Write("Пожалуйста, введите число: ");
                userAnswer = Convert.ToInt32(Console.ReadLine());

                if (userAnswer == randomNumber)
                {
                    Console.WriteLine("Поздравляю! Вы угадали загаданное число, игра окончена.");
                    break;
                }
                else
                {
                    userMaxQuantityAttemps -= 1;
                    Console.WriteLine($"Вы не угадали, у вас осталось: {(userMaxQuantityAttemps)} попыток");
                }
            }

            if (userMaxQuantityAttemps == 0)
            {
                Console.WriteLine("Сожалею, но вы проиграли, повезет в след.раз, заходите еще!");
            }
        }
    }
}
