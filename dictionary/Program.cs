using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Практика - Переводчик оценок

            // Словарь оценок
            Dictionary<int, string> grades = new Dictionary<int, string>();
            grades.Add(5, "отлично");
            grades.Add(4, "хорошо");
            grades.Add(3, "удовлетворительно");
            grades.Add(2, "неудовлетворительно");

            // Ввод оценок
            Console.WriteLine("Введите оценки через пробел:");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            // Перевод оценок
            Console.WriteLine("Результаты перевода:");
            int sum = 0;
            int count = 0;

            for (int i = 0; i < parts.Length; i++)
            {
                int num = Convert.ToInt32(parts[i]);

                if (grades.ContainsKey(num))
                {
                    Console.WriteLine($"{num} -> {grades[num]}");
                    sum += num;
                    count++;
                }
                else
                {
                    Console.WriteLine($"{num} -> нет такой оценки");
                }
            }

            // Статистика
            if (count > 0)
            {
                double average = (double)sum / count;
                Console.WriteLine($"Средний балл: {average}");
            }
        }
    }
}
