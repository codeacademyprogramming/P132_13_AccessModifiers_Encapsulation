using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Student:Human
    {
        public byte Point;

        public Student()
        {
            _age = 15;
        }
        public byte Age
        {
            //get
            //{
            //    return _age;
            //}
            get => _age;
            set
            {
                if (value >= 15 && value <= 65)
                    _age = value;
            }

        }
    }
}
