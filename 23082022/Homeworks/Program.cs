using System;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "group";

            Console.WriteLine(FindLastWord(sentence));


            byte age;
          

            do
            {
                Console.WriteLine("yasi daxil edin");
                string ageStr = Console.ReadLine();
                age = Convert.ToByte(ageStr);
            } while (age<15 || age>65);

            string name;

            do
            {
                Console.WriteLine("Adi daxil edin");
                name = Console.ReadLine();
            } while (String.IsNullOrWhiteSpace(name) || name.Length<3 || HasNonLetterChar(name));

            Person person = new Person();
            //person.Name = "a";
            person.SetName(name);
            person.SetName("abbas");


            //person.SetAge(age);
            person.Age = 55;
            person.Surname = "A";
            Console.WriteLine(person.Surname);
            Console.WriteLine(person.Gender);


            person.Show();
            //Console.WriteLine(person.GetAge());
            Console.WriteLine(person.Age);


        }

        static string FindLastWord(string str)
        {
            str = str.TrimEnd();
            int lastSpaceIndex = str.LastIndexOf(' ');
            if (lastSpaceIndex != -1)
            {
                string word = str.Substring(lastSpaceIndex + 1);
                return word;
            }

            return str;
        }

        static bool HasNonLetterChar(string str)
        {
            if (!String.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (Char.IsLetter(str[i]) == false)
                        return true;
                }
            }

            return false;
        }
    }
}
