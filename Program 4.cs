using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name
        {
            get { return name; }
        }

        public DateTime BirthYear
        {
            get { return birthYear; }
        }

        public Person()
        {
            name = "";
            birthYear = DateTime.MinValue;
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            int age = DateTime.Today.Year - birthYear.Year;
            if (DateTime.Today < birthYear.AddYears(age))
            {
                age--;
            }
            return age;
        }

        public void Input()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter birth year (yyyy): ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("Invalid input, try again.");
                Console.Write("Enter birth year (yyyy): ");
            }
            birthYear = new DateTime(year, 1, 1);
        }

        public void ChangeName(string newName)
        {
            name = newName;
        }

        public override string ToString()
        {
            return $"{name}, {Age()} years old";
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator ==(Person person1, Person person2)
        {
            return person1.name == person2.name;
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Person))
            {
                return false;
            }

            return this.name == ((Person)obj).name;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }

    class Program
    {
        static void Main()
        {
            Person[] people = new Person[6];
            for (int i = 0; i < 6; i++)
            {
                people[i] = new Person();
                people[i].Input();
            }

            Console.WriteLine("Names and ages:");
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age()} years old");
            }

            Console.WriteLine("Changing names...");
            foreach (Person person in people)
            {
                if (person.Age() < 16)
                {
                    person.ChangeName("Very Young");
                }
            }

            Console.WriteLine("All people:");
            foreach (Person person in people)
            {
                person.Output();
            }

            Console.WriteLine("People with the same name:");
            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i] == people[j] && people[i].Name != "Very Young" && people[j].Name != "Very Young")
                    {
                        Console.WriteLine($"{people[i].Name} has the same name as {people[j].Name}");
                    }
                }
            }
        }
    }
}
