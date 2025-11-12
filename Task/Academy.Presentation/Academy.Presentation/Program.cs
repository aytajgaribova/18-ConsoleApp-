using Academy.Presentation.Helpers;
using Academy.System.Presentation.Controller;

namespace Academy.Presentation;

class Program
{
    static void Main(string[] args)
    {
        GroupController groupController = new GroupController();
        StudentController studentController = new StudentController();
    
        Helper.PrintConsole(ConsoleColor.Blue, "Select one option");
        Helper.PrintConsole(ConsoleColor.Yellow, "1 - Create Group, /n 2 - Update Group, /n 3 - Delete Group, /n 4 - Get group  by id, /n 5 - Get all groups  by teacher , /n 6 - Get all groups by room, /n 7 - Get all groups   ,/n 8 - Create Student, /n 9 - Update Student   , /n 10- Get student  by id, /n 11 - Delete student, /n 12 - Get students by age, /n 13 - Get all students  by group id , /n 14- Search method for groups by name, /n 15 - Search method for students by name or surname");
        
        while (true)
        {
            SelectOption: string SelectOption=Console.ReadLine();
            int TrueSelectOption;
            bool IsSelectOption = int.TryParse(SelectOption, out TrueSelectOption);
            if (IsSelectOption)
            {

                switch (TrueSelectOption)
                {
                       case 1:
                            groupController.CreateGroup();
                            break;
                        case 2:
                            studentController.CreateStudent();
                            break;
                        case 3:
                            groupController.Update();
                            break;
                        case 4:
                            studentController.UpdateStudent();
                            break;
                        case 5:
                            groupController.Delete();
                            break;
                        case 6:
                            studentController.DeleteStudent();
                            break;
                        case 7:
                            groupController.GetAllByRoom();
                            break;
                        case 8:
                            groupController.GetAllByTeacher();
                            break;
                        case 9:
                            groupController.GetAll();
                            break;
                        case 10:
                            studentController.GetAllStudentsByGroupId();
                            break;
                        case 11:
                            groupController.GetGroupById();
                            break;
                        case 12:
                            studentController.GetStudentById();
                            break;
                        case 13:
                            studentController.GetStudentsByAge();
                            break;
                        case 14:
                            groupController.SearchMethodForGroupsByName();
                            break;
                        case 15:
                            studentController.SearchMethodForStudentsByNameorSurname(); 
                            break;

                }
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "Select correct option type!");
                goto SelectOption;
            }
        }





    }
}
