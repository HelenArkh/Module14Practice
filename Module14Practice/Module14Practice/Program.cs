using System;
using System.Collections.Generic;
using System.Linq;

namespace Module14Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 23, 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", 55, 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", 49, 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", 21, 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", 20, 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", 39, 799900000013, "innokentii@example.com"));

            // Сортировка по имени и возрасту
            var sortedPhoneBook = phoneBook
               .OrderBy(s => s.Name)
               .ThenBy(s => s.Age);

            foreach (var stud in sortedPhoneBook)
                Console.WriteLine(stud.Name + ", " + stud.Age);
        }
    }
}
