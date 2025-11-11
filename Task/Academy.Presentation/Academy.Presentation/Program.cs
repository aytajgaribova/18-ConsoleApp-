using Academy.Presentation.Domain.Entities;
using Academy.Presentation.Helpers;
using Academy.Presentation.Controllers;
using Service.Services.Implementations;

namespace Academy.Presentation;

class Program
{
    static void Main(string[] args)
    {
        GroupService _groupservice;
        Helper.PrintConsole(ConsoleColor.Black, "Select one option");
        Helper.PrintConsole(ConsoleColor.Blue, "1 - Create Group, /n 2 - Update Group, /n 3 - Delete Group, /n 4 - Get group  by id, /n 5 - Get all groups  by teacher , /n 6 - Get all groups by room, /n 7 - Get all groups   ,/n 8 - Create Student, /n 9 - Update Student   , /n 10- Get student  by id, /n 11 - Delete student, /n 12 - Get students by age, /n 13 - Get all students  by group id , /n 14- Search method for groups by name, /n 15 - Search method for students by name or surname");
        
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
                        Helper.PrintConsole(ConsoleColor.Green, "Add Group Teacher");
                        string GroupTeacher = Console.ReadLine();
                        Room:  Helper.PrintConsole(ConsoleColor.Green, "Add Group Room");
                        string GroupRoom = Console.ReadLine();
                        int room;
                        bool IsGroupRoom = int.TryParse(GroupRoom, out room );
                        if (IsGroupRoom)
                        {
                            Group group = new Group { Teacher = GroupTeacher, Room = room };
                            var result = _groupservice.Create(group);
                            Helper.PrintConsole(ConsoleColor.Green, $"Group Name; {Group.Name}, Group Teacher: {Group.Teacher}, Group Rooms: {Group.Room}");
                        }
                        else
                        {
                            Helper.PrintConsole(ConsoleColor.Red, "Add Correct Room Type");
                            goto Room;
                        }
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
