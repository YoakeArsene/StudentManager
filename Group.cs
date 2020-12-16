using System.Collections.Generic;
using System.Linq;

namespace Object___Classes_2
{
    class Group
    {
        public string GroupName;
        public List<Student> Students;
        public Group(string name)
        {
            GroupName = name;
            Students = new List<Student>();
        }
        public Student FindStudentById(string id) 
        {
            return Students.SingleOrDefault(s => s.Id == id); 
        }
        public void AddStudent(Student student)
        {
            if (FindStudentById(student.Id) != null)
            {
                UI.ShowMessage(Message.NotFound);
                return;
            }
            Students.Add(student);
        }
        public void RemoveStudentById(string id)
        {
            
            if (FindStudentById(id) == null)
            {
                UI.ShowMessage(Message.NotFound);
                return;
            }
            Students.Remove(FindStudentById(id));
        }
        public Student EditStudentById(string id, string name, int age)
        {
            var studentInDatabase = FindStudentById(id);
            if (studentInDatabase == null)
            {
                UI.ShowMessage(Message.NotFound);
            }
            studentInDatabase.FullName = name;
            studentInDatabase.Age = age;
            return studentInDatabase;

        }
    }
}
