using System.Text.RegularExpressions;
using Academy.Presentation.Helpers;
using Service.Services.Implementations;
namespace Academy.System.Presentation.Controller
{
    public class GroupController
    {

        GroupService _groupService = new();

        public void CreateGroup()
        {
            Helper.PrintConsole(ConsoleColor.Blue, "Add Group Teacher");
            string GroupTeacher = Console.ReadLine();
        Room: Helper.PrintConsole(ConsoleColor.Blue, "Add Group Room");
            string GroupRoom = Console.ReadLine();
            int room;
            bool IsGroupRoom = int.TryParse(GroupRoom, out room);
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
        }
        public void GetById()
        {
        GroupId: Helper.PrintConsole(ConsoleColor.Blue, "Add Group Id");

            string groupId = Console.ReadLine();

            int id;

            bool isGroupId = int.TryParse(groupId, out id);

            if (isGroupId)
            {
                Group group = _groupService.GetById(id);

                if (group != null)
                {
                    Helper.PrintConsole(ConsoleColor.Green, $"Group Id : {group.Id}, Name : {group.Name}, room : {group.Room}, Teacher: {group.teacher}");
                }
                else
                {
                    Helper.PrintConsole(ConsoleColor.Red, "Group not found!");
                    goto GroupId;
                }
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "Add correct GroupId type");
                goto GroupId;
            }
        }
        public void GetAll()
        {
            List<Group> groups = _groupService.GetAll();

            if (groups.Count != 0)
            {
                foreach (var group in groups)
                {
                    Helper.PrintConsole(ConsoleColor.Green, $"Group Id : {group.Id}, Name : {group.Name}, Room : {group.Room} , Teacher: {group.teacher}");
                }
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "Please Create Group!");
            }
        }
        public void Delete()
        {
        GroupId: Helper.PrintConsole(ConsoleColor.Blue, "Add Group Id");

            string groupId = Console.ReadLine();

            int id;

            bool isGroupId = int.TryParse(groupId, out id);

            if (isGroupId)
            {
                _groupService.Delete(id);
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "Add correct GroupId type");
                goto GroupId;
            }
        }

        public void Update()

        {
        GroupId: Helper.PrintConsole(ConsoleColor.Blue, "Add Group Id (or press Enter to cancel)");

            string groupId = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(groupId))
            {
                Helper.PrintConsole(ConsoleColor.Red, "Update operation cancelled.");
                return;
            }

            int id;

            bool isGroupId = int.TryParse(groupId, out id);

            if (isGroupId)
            {
                var findGroup = _groupService.GetById(id);

                if (findGroup != null)
                {
                    Helper.PrintConsole(ConsoleColor.Blue, $"Current Name: {findGroup.Name}. Add Group new name (or press Enter to keep current)");

                    string groupNewName = Console.ReadLine();

                Room: Helper.PrintConsole(ConsoleColor.Blue, $"Current Room: {findGroup.Room}. Add Group new room (or press Enter to keep current)");

                    string groupNewRoom = Console.ReadLine();
                    string teacher = Console.ReadLine();

                    int room = findGroup.Room;

                    if (!string.IsNullOrWhiteSpace(groupNewRoom))
                    {
                        bool isRoom = int.TryParse(groupNewRoom, out room);

                        if (!isRoom)
                        {
                            Helper.PrintConsole(ConsoleColor.Red, "Add correct room type");
                            goto Room;
                        } 
                    }

                    if (string.IsNullOrWhiteSpace(groupNewName))
                    {
                      groupNewName = findGroup.Name;
                    }

                    Group group = new Group { Name = groupNewName, Room = room, Teacher = teacher };

                    var updatedGroup = _groupService.Update(id, group);

                    if (updatedGroup == null)
                    {
                        Helper.PrintConsole(ConsoleColor.Red, "Group not Updated, please try again");
                        goto GroupId;
                    }
                    else
                    {
                        Helper.PrintConsole(ConsoleColor.Green, $"group Id: {updatedGroup.Id}, Name: {updatedGroup.Name}, Room: {updatedGroup.Room}");
                    }
                }
                else
                {
                    Helper.PrintConsole(ConsoleColor.Red, "group not found");
                    goto GroupId;
                }
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "Add correct groupId type");
                goto GroupId;
            }
        }
        public void SearchMethodForGroupsByName()
        {
            Searchtext: Helper.PrintConsole(ConsoleColor.Blue, "Add Group Search Method");
            string searchname = Console.ReadLine();
            List<Group> groups = _groupService.Search(searchname);
            if (groups.Count != 0)
            {
                foreach (var group in groups)
                {
                    Helper.PrintConsole(ConsoleColor.Green, $"Group Name; {Group.Name}, Group Teacher: {Group.Teacher}, Group Rooms: {Group.Room}");
                }
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "Group not found for search metod!");
                goto Searchtext;
            }
        }

        internal void GetAllGroupsByRoom()
        {
            throw new NotImplementedException();
        }
    }
    


}