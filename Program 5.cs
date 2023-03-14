using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    class Program
    {
        public interface IDeveloper
        {
            string Tool { get; set; }

            void Create();

            void Destroy();
        }

        public class Programmer : IDeveloper, IComparable<Programmer>
        {
            public string Language { get; set; }
            public string Tool { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void Create()
            {
                Console.WriteLine($"Writing code in {Language}...");
            }

            public void Destroy()
            {
                Console.WriteLine($"Deleting code in {Language}...");
            }

            public int CompareTo(Programmer other)
            {
                return this.Language.CompareTo(other.Language);
            }
        }

        public class Builder : IDeveloper, IComparable<Builder>
        {
            public string Tool { get; set; }

            public void Create()
            {
                Console.WriteLine($"Building with {Tool}...");
            }

            public void Destroy()
            {
                Console.WriteLine($"Destroying with {Tool}...");
            }

            public int CompareTo(Builder other)
            {
                return this.Tool.CompareTo(other.Tool);
            }
        }

        

        static void Main()
        {
            List<IDeveloper> developers = new List<IDeveloper>();

            developers.Add(new Programmer { Language = "C#", Tool = "Visual Studio" });
            developers.Add(new Builder { Tool = "Hammer" });
            developers.Add(new Programmer { Language = "Java", Tool = "Eclipse" });
            developers.Add(new Builder { Tool = "Saw" });

            developers.Sort();

            Dictionary<uint, string> persons = new Dictionary<uint, string>();
            persons.Add(1, "John");
            persons.Add(2, "Sarah");
            persons.Add(3, "David");
            persons.Add(4, "Amy");
            persons.Add(5, "James");
            persons.Add(6, "Emily");
            persons.Add(7, "Michael");

            Console.Write("Enter ID to look up: ");
            uint id = Convert.ToUInt32(Console.ReadLine());

            if (persons.ContainsKey(id))
            {
                Console.WriteLine($"The person with ID {id} is {persons[id]}.");
            }
            else
            {
                Console.WriteLine($"No person with ID {id} found.");
            }
        }
    }
}
