using System;

namespace Object___Classes_2
{
    enum Message
    {
        AddStudent,
        ShowStudent,
        FindStudent,
        RemoveStudent,
        EditStudent,
        AskNumber,
        Done,
        NotFound,
        Exit,
        Wrong
    }

    class UI
    {
        public static void ShowGroupNameAndStudentList(Group group)
        {
            Console.WriteLine($"Group: {group.GroupName}");
            Console.WriteLine($"Number of students: {group.Students.Count}");
            foreach (var student in group.Students)
            {
                student.ShowStudentInfo();
            }
        }
        public static string EnterId()
        {
            Console.Write("Enter student ID: ");
            return Console.ReadLine();
        }
        public static string EnterName()
        {
            Console.Write("Enter student name: ");
            return Console.ReadLine();
        }
        public static int EnterAge()
        {
            Console.Write("Enter student age: ");
            return int.Parse(Console.ReadLine());
        }
        public static void ShowMenuControl()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("Welcome to the Student Group Manager");
            Console.WriteLine("Press 1 to add new students.");
            Console.WriteLine("Press 2 to show the student list.");
            Console.WriteLine("Press 3 to find a student by his ID.");
            Console.WriteLine("Press 4 to remove a student by his ID.");
            Console.WriteLine("Press 5 to edit a student info by his ID.");
            Console.WriteLine("Press 0 to quit the program.");
        }
        public static int EnterOption()
        {
            Console.WriteLine("===========================================");
            Console.Write("Enter your option: ");
            return int.Parse(Console.ReadLine());
        }
        public static void ShowMessage(Message message)
        {

            switch (message)
            {
                case Message.AddStudent:
                    Console.WriteLine("     -o0o-ADD STUDENT-o0o-");
                    break;
                case Message.ShowStudent:
                    Console.WriteLine("     -o0o-SHOW STUDENT LIST-o0o-");
                    break;
                case Message.FindStudent:
                    Console.WriteLine("     -o0o-FIND STUDENT-o0o-");
                    break;
                case Message.RemoveStudent:
                    Console.WriteLine("     -o0o-REMOVE STUDENT-o0o-");
                    break;
                case Message.EditStudent:
                    Console.WriteLine("     -o0o-EDIT STUDENT-o0o-");
                    break;
                case Message.AskNumber:
                    Console.Write("Number of student to add: ");
                    break;
                case Message.Done:
                    Console.WriteLine("Done.");
                    break;
                case Message.NotFound:
                    Console.WriteLine("Student Not Found.");
                    break;
                case Message.Exit:
                    Console.WriteLine("Exit program.");
                    break;
                case Message.Wrong:
                    Console.WriteLine("Wrong input.");
                    break;
                default:
                    break;
            }

        }
    }
}