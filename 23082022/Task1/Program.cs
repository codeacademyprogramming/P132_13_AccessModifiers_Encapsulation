using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "";

        
            Console.WriteLine(car1.Brand);

            Human human = new Human();
            human.Age = 17;

            Console.WriteLine(human.Age);

            Employee employee = new Employee();
            employee.Age = 10;
            employee.Age = 20;

            Console.WriteLine($"Emoloyee age: {employee.Age}");



            Student student = new Student();
            student.Age = 10;
            student.Age = 30;
            Console.WriteLine($"Student age: {student.Age}");




        }
      
    }
}
