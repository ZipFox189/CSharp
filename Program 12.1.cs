using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

delegate void MyDel(int m);


namespace HomeWork_12
{

    [Serializable]
    class Student
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

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("student.bin", FileMode.Create);
            binaryFormatter.Serialize(fileStream, student);
            fileStream.Close();

            fileStream = new FileStream("student.bin", FileMode.Open);
            Student deserializedStudent = (Student)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();

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
