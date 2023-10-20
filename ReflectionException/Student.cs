using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReflectionException
{
    public class Student
    {
        private static int _counter = 0;
        private string _name;
        private string _surname;

        public Student()
        {
        }

        public Student(string name, string surname)
        {
            Id = ++_counter;
            Name = name;
            Surname = surname;
        }

        public int Id { get; }
        public string Name
        {
            get  { return _name; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Ad ən azı 3 simvol uzunluğunda olmalıdır.");
                }
                _name = value;
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Soyad ən azı 3 simvol uzunluğunda olmalıdır.");
                }
                _surname = value;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Student ID: {Id},\nName: {Name},\nSurname: {Surname}");
        }
    }
}
