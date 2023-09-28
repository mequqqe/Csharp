using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };

            // Используем LINQ для фильтрации и сортировки
            var selectedPeople = people
                .Where(person => person.ToUpper().StartsWith("T"))
                .OrderBy(person => person)
                .ToList();

            // Выводим результат
            foreach (string person in selectedPeople)
            {
                Console.WriteLine("ФИльтрация по букве" + person);
            }



            var namesWithLength = people.Where(p => p.Length == 3);

            foreach (string person in namesWithLength)
            {
                Console.WriteLine("Выборка имени по длине" + person);
            }


            var upperCaseNames = people.Select(p => p.ToUpper());

            foreach (string person in upperCaseNames)
            {
                Console.WriteLine($"преоброзвание на верхни регистр {person}");
            }

            var allNames = people.Aggregate((a, b) => a + ", " + b);


            foreach (string person in allNames)
            {
                Console.WriteLine($"групировка всех имени {person}");
            }

        }
    }
