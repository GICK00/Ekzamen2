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
            HQ hq = new HQ(size);

            Console.WriteLine($"Введите {size} элементов массива.");
            for (int n = 0; n < size; n++)
            {

            }
            
        }
    }

    public class HQ
    {
        private Person[] mas;
        public HQ (int size) => mas = new Person[size];

        public void AddPerson(int size)
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
