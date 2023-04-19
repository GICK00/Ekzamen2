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
            Console.Write("Введите размер массива HQ: ");
            int size = Convert.ToInt32(Console.ReadLine());
            HR hr = new HR(size);

            Console.WriteLine($"Введите {size} элементов массива.");
            hr.AddPersons();


            
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

        }

        public static void Sort()
        {

        }

        public static void Save(Person[] masSave)
        {
            string path = $"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\\mas.txt";
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
