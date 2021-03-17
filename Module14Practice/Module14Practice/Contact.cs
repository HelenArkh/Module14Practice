using System;
using System.Collections.Generic;
using System.Text;

namespace Module14Practice
{
    public class Contact
    {
        public Contact(string name, int age, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;           
        }

        public String Name { get; }
        public int Age { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }
}
