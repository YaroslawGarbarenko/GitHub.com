using System;

namespace GitHub.com
{
    class Person
    {
        public string Name { get; set; }
    }
    class People
    {
        Person[] people;

        public People()
        {
            people = new Person[2];
        }
        public Person this[int index]
        {
            get
            {
                if (index == 0) return people[0];
                if (index == 1) return people[1];
                else
                {
                    Console.WriteLine("Введите верный индекс !");
                    return people[index];
                }
            }
            set
            {
                if (index == 0) people[0] = value;
                if (index == 1) people[1] = value;
                else Console.WriteLine("Введите верный индекс !");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите индекс");
            Convert.ToInt32(Console.ReadLine());
            People people = new People();
            people[0] = new Person() { Name = "Tom" };
            people[1] = new Person() { Name = "Bob" };
            Person x = people[0];
            Person y = people[1];
            Console.WriteLine(x?.Name);
            Console.WriteLine(y?.Name);
            Console.ReadKey();
        }
    }
}
