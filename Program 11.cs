using System;
using System.Collections.Generic;

delegate void MyDel(int m);


namespace HomeWork_11
{
    class Student
    {
        public string Name { get; set; }
        public List<int> Marks { get; set; }
        public event MyDel MarkChange;

        public Student(string name)
        {
            Name = name;
            Marks = new List<int>();
        }

        public void AddMark(int mark)
        {
            Marks.Add(mark);
            MarkChange?.Invoke(mark);
        }
    }

    class Parent
    {
        public void OnMarkChange(int mark)
        {
            Console.WriteLine($"Mark changed to {mark}");
        }
    }

    class Accountancy
    {
        public void PayingFellowship(int mark)
        {
            if (mark >= 80)
            {
                Console.WriteLine("Congratulations! You have been awarded a scholarship.");
            }
            else
            {
                Console.WriteLine("You did not qualify for a scholarship.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("John");
            Parent parent = new Parent();
            Accountancy accountancy = new Accountancy();

            student.MarkChange += parent.OnMarkChange;
            student.MarkChange += accountancy.PayingFellowship;

            student.AddMark(70);
            student.AddMark(85);
            student.AddMark(90);
        }
    }
}
