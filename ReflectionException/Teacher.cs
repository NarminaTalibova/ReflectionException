using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionException
{
    public class Teacher
    {
        private string _name;

        public Teacher()
        {
        }

        public Teacher(string name)
        {
            _name = name;
        }

        private void ShowInfo()
        {
            Console.WriteLine($"Teacher's name: {_name}");
        }
    }
}
