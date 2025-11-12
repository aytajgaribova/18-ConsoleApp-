using System.Text.RegularExpressions;
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
        public Group GetById(Predicate<Group> predicate)
        {
            return predicate != null ? AppDbContext<Group>.datas.Find(predicate) : null;
        }
        public void UpdateGroup(Group data)
        {
            Group dbgroup = GetById(group => group.Id == data.Id);
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
            return predicate != null ? AppDbContext<Group>.datas.FindAll(predicate) : AppDbContext<Group>.datas;
        }
           public List<Group> GetAllGroupsByRoom(Predicate<Group> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetAllGroupsByTeacher(Predicate<Group> predicate)
        {
            throw new NotImplementedException();
        }
        public Group GetAllGroupsById(Predicate<Group> predicate)
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