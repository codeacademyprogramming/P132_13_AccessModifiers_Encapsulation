using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Employee:Human
    {
        public Employee()
        {
            _age = 18;
        }
        public string Position;
        public byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 18 && value <= 65)
                    _age = value;
            }
        }
    }
}
