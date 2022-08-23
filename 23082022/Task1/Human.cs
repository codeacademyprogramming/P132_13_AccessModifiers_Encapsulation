using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Human
    {
        public string Name;
        protected byte _age;

        public byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0 && value <= 65)
                    _age = value;
            }
        }
    }
}
