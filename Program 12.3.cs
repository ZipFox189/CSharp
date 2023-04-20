using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public delegate void MyDel(int m);


namespace HomeWork_12
{
    public class Student
    {
        public string Name { get; set; }
        public List<int> Marks { get; set; }
        public event MyDel MarkChange;

        public void AddMark(int mark)
        {
            Marks.Add(mark);
            MarkChange?.Invoke(mark);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { Name = "John", Marks = new List<int>() { 70, 80, 90 } };

            string jsonString = JsonConvert.SerializeObject(student);
            File.WriteAllText("student.json", jsonString);

            string jsonFromFile = File.ReadAllText("student.json");
            Student deserializedStudent = JsonConvert.DeserializeObject<Student>(jsonFromFile);

            Console.WriteLine("Name: " + deserializedStudent.Name);
            Console.Write("Marks: ");
            foreach (int mark in deserializedStudent.Marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
    }

}
