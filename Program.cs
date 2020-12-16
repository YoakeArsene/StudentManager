using System;

namespace Object___Classes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("GCD0808");
            UI.ShowMenuControl();
            int option;
            do
            {
                option = UI.EnterOption();
                switch (option)
                {
                    case 1:
                        {
                            UI.ShowMessage(Message.AddStudent);
                            UI.ShowMessage(Message.AskNumber);
                            int number = int.Parse(Console.ReadLine());
                            for (int i = 1; i <= number; i++)
                            {
                                Console.WriteLine($"#{i}");
                                group.AddStudent(new Student(
                                    UI.EnterId(),
                                    UI.EnterName(),
                                    UI.EnterAge()
                                    ));
                            }
                            UI.ShowMessage(Message.Done);
                        }
                        break;

                    case 2:
                        {
                            UI.ShowMessage(Message.ShowStudent);
                            UI.ShowGroupNameAndStudentList(group);
                        }
                        break;

                    case 3:
                        {
                            UI.ShowMessage(Message.FindStudent);
                            if (group.FindStudentById(UI.EnterId()) == null)
                            {
                                UI.ShowMessage(Message.NotFound);
                            }
                            else group.FindStudentById(UI.EnterId()).ShowStudentInfo();
                        }
                        break;

                    case 4:
                        {
                            UI.ShowMessage(Message.RemoveStudent);
                            group.RemoveStudentById(UI.EnterId());
                            UI.ShowMessage(Message.Done);
                        }
                        break;
                    case 5:
                        {
                            UI.ShowMessage(Message.EditStudent);
                            group.EditStudentById(
                                UI.EnterId(),
                                UI.EnterName(),
                                UI.EnterAge()
                                );
                            UI.ShowMessage(Message.Done);

                        }
                        break;

                    case 0:
                        UI.ShowMessage(Message.Exit);
                        break;

                    default:
                        UI.ShowMessage(Message.Wrong);
                        break;
                }
            } while (option != 0);
            Console.ReadLine();
        }
    }
}
