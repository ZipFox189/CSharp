using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public delegate void MyDel(int m);


namespace HomeWork_12
{

    [Serializable]
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

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            StreamWriter streamWriter = new StreamWriter("student.xml");
            xmlSerializer.Serialize(streamWriter, student);
            streamWriter.Close();

            StreamReader streamReader = new StreamReader("student.xml");
            Student deserializedStudent = (Student)xmlSerializer.Deserialize(streamReader);
            streamReader.Close();

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
