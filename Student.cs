using System;

namespace Object___Classes_2
{
    class Student
    {
        public string Id;
        public string FullName;
        public int Age;
        public Student()
        {
            Id = "N/A";
            FullName = "N/A";
            Age = -1;
        }
        public Student(string id, string name, int age)
        {
            Id = id;
            FullName = name;
            Age = age;
        }
        public void ShowStudentInfo()
        {
            Console.WriteLine("===============");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Student Name: {FullName}");
            Console.WriteLine($"Age: {Age}");

        }
    }
}
