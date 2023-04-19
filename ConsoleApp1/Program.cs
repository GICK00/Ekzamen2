using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool reapit = true;
            while (reapit)
            { 
                try
                {
                    Console.Write("Введите размер массива HQ: ");
                    int size = Convert.ToInt32(Console.ReadLine());
                    HR hr = new HR(size);

                    Console.WriteLine($"Введите {size} элементов массива.");
                    hr.AddPersons();
                    hr.ViewPersons();

                    Console.WriteLine("Отсортированныый массив.");
                    hr.Sort();
                    hr.ViewPersons();

                    Console.WriteLine("Массив сохранен.");
                    hr.Save();

                    reapit = Reapit();
                }
                catch
                {
                    Console.WriteLine("Произошла ошибка!");
                    reapit = Reapit();
                }
            }
        }

        static bool Reapit()
        {
            Console.WriteLine("Повторить?");
            Console.Write(@"Да(Y) \ Нет(Любая кнопка): ");
            string result = Console.ReadLine().ToUpper().Trim();
            if (result == "Y")
                return true;
            return false;
        }
    }

    public class HR
    {
        private Person[] persons;
        public HR (int size) => persons = new Person[size];

        public void AddPersons()
        {
            int size = persons.Length;
            for (int i = 0; i < size; i++)
            {
                Person person = new Person();
                Console.Write("Фамилия: ");
                person.Surname = Console.ReadLine();
                Console.Write("Имя: ");
                person.Name = Console.ReadLine();
                Console.Write("Возраст: ");
                person.Age = Console.ReadLine();
                persons[i] = person;
                Console.WriteLine();
            }
        }

        public void ViewPersons()
        {
            foreach(Person person in persons)
                Console.WriteLine($"Фамилия: {person.Surname} Имя: {person.Name} Возраст: {person.Age}");
        }

        public void Sort() => Array.Sort(persons, (x, y) => (x.Surname + " " + x.Name).CompareTo(y.Surname + " " + y.Name));

        public void Save()
        {
            string path = $"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\\Persons.txt";
            using (StreamWriter writer = new StreamWriter(File.Open(path, FileMode.Create)))
            {
                foreach(Person person in persons)
                    writer.WriteLine($"Фамилия: {person.Surname} Имя: {person.Name} Возраст: {person.Age}");
            }
        }
    }

    public class Person
    {
        private string surname;
        private string name;
        private string age;

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}
