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
                int num = int.Parse(parts[i]);

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
                Console.WriteLine($"Средний балл: {average:F1}");
            }

            // Добавление новой оценки
            Console.WriteLine("Хотите добавить новую оценку? (да/нет):");
            string answer = Console.ReadLine();

            if (answer == "да")
            {
                Console.WriteLine("Введите числовую оценку:");
                int newNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите текстовое описание:");
                string newText = Console.ReadLine();

                grades.Add(newNum, newText);
                Console.WriteLine($"Оценка {newNum} -> \"{newText}\" добавлена в словарь");
            }

            // Обратный перевод
            Console.WriteLine("Введите текстовую оценку:");
            string search = Console.ReadLine();
            bool found = false;

            foreach (var grade in grades)
            {
                if (grade.Value == search)
                {
                    Console.WriteLine($"Числовая оценка: {grade.Key}");
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("Такая оценка не найдена");
        }
    }
}
