using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    internal class Person
    {
        private string Name;
        private byte _age;
        private string _surname;
        public string Gender { get; set; }
        public string Surname {
            get
            {
                return this._surname;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value.Length > 2)
                    this._surname = value;
            }
        }
        public byte Age {
            get
            {
                return _age;
            }
            set
            {
                if (value > 14 && value < 66)
                    _age = value;
            }
        }

        public Person()
        {
            _age = 15;
        }
        public void Show()
        {
            Console.WriteLine($"Name: {Name} \nAge: {_age}");
        }

        public void SetAge(byte age)
        {
            if (age > 14 && age < 66)
                this._age = age;
        }
        public byte GetAge()
        {
            return _age;
        }

        public void SetName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name) && name.Length > 2)
                this.Name = name;
        }
    }
}
