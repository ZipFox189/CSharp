using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            try
            {
                using (StreamReader sr = new StreamReader("phones.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] tokens = line.Split(',');
                        if (tokens.Length != 2)
                        {
                            throw new FormatException($"Invalid line format: {line}");
                        }

                        string name = tokens[0].Trim();
                        string phone = tokens[1].Trim();

                        phoneBook[name] = phone;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: File not found");
                return;
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error reading file: {e.Message}");
                return;
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Error reading file: {e.Message}");
                return;
            }

            using (StreamWriter sw = new StreamWriter("Phones.txt"))
            {
                foreach (string phone in phoneBook.Values)
                {
                    sw.WriteLine(phone);
                }
            }

            Console.Write("Enter name to find phone number: ");
            string nameToFind = Console.ReadLine();
            if (phoneBook.TryGetValue(nameToFind, out string phoneNumber))
            {
                Console.WriteLine($"Phone number for {nameToFind}: {phoneNumber}");
            }
            else
            {
                Console.WriteLine($"No phone number found for {nameToFind}.");
            }

            Dictionary<string, string> newPhoneBook = new Dictionary<string, string>();
            foreach (var entry in phoneBook)
            {
                string phone = entry.Value;
                if (phone.StartsWith("80") && phone.Length == 10)
                {
                    phone = "+3" + phone;
                }
                newPhoneBook[entry.Key] = phone;
            }

            using (StreamWriter sw = new StreamWriter("New.txt"))
            {
                foreach (var entry in newPhoneBook)
                {
                    sw.WriteLine($"{entry.Key}, {entry.Value}");
                }
            }

            Console.WriteLine("Done.");
        }
    }
}
