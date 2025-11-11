using System.Text.RegularExpressions;
using Academy.Presentation.Repository.Data;
using Academy.Presentation.Repository.Exception
using Academy.Presentation.Repository.Repositories.Interfaces;
using Repository.Data;

namespace Academy.Presentation.Repository.Repositories.Implementations
{
    public class GroupRepository : IRepository<Group>
    {
        public void CreateGroup(Group data)
        {
            try
            {
                if (data is null) throw new DllNotFoundException("Data not found!");
                AppDbContext<Group>.datas.Add(data);
            }
            catch (Exception ex)
            {
                
                System.Console.WriteLine(ex.Message);
            }
        }
        public void UpdateGroup(Group data)
        {
            Group dbgroup = GetGroupById(global => global.Id == data.Id);
            dbgroup.Name = data.Name;
            dbgroup.Teacher = data.Teacher;
            dbgroup.Room = data.Room;
        }
        public void DeleteGroup(Group data)
        {
            AppDbContext<Group>.datas.Remove(data);
        }
        public List<Group> GetAllGroups(Predicate<Group> predicate = null)
        {
            return predicate != null ? AppDbContext<Group>.datas.FindAll(predicate) : null;
        }

           public List<Group> GetAllGroupsByRoom(Predicate<Group> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetAllGroupsByTeacher(Predicate<Group> predicate)
        {
            throw new NotImplementedException();
        }
        public Group GetAllGroupById(Predicate<Group> predicate)
        {
            return predicate != null ? AppDbContext<Group>.datas.Find(predicate) : null;
        }

        public Group  SearchMethodForGroupsByName(Predicate<Group> predicate)
        {
            return predicate != null ? AppDbContext<Group>.datas.Find(predicate) : null;
        }





    }

    public interface IRepository<T>
    {
    }
}