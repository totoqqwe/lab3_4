using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        private readonly DateTime registrationDate;

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            registrationDate = DateTime.Now;
        }

        public void WriteUserInfo()
        {
            Console.WriteLine("Інформація про користувача:");
            Console.WriteLine($"Логін: {login}");
            Console.WriteLine($"Ім'я: {name}");
            Console.WriteLine($"Прізвище: {surname}");
            Console.WriteLine($"Вік: {age}");
            Console.WriteLine($"Дата заповнення анкети: {registrationDate.ToString("yyyy-MM-dd HH:mm:ss")}");
        }
    }
}
