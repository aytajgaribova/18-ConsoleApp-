using System.Text.RegularExpressions;
using Service.Services.Interfaces;

namespace Service.Services.Implementations
{
    public class GroupService : IGroupService
    {

        private GroupRepository _groupRepository;
        private int _count=1;

        public GroupService()
        {
            _groupRepository = new GroupRepository();
        }
        public Group Create(Group group)
        {
            group.Id = _count;
            _groupRepository.Create(group);
            _count++;
            return group;

        }

        public void Delete(int id)
        {
            Group group = GetById(id);
            _groupRepository.Delete(group);
        }

        public object GetAllByTeacher(string groupTeacher)
        {
            Group group = _groupRepository.Get(g => g.Teacher == groupTeacher);
            if (group is null) return null;
            return group;
        }

        public List<Group> GetAll()
        {
            return _groupRepository.GetAll();
        }
        public Group GeyById(int id)
        {
            Group group=_groupRepository.Get(g=>g.Id==id);
            if (group is null) return null;
             return group;
        }

        public Group Update(int id, Group group)
        {
            throw new NotImplementedException();

        }
        public object GetByRoom(string groupRoom)
        {
            Group group = groupRepository.Get(g => g.Room==groupRoom);
            if (group is null) return null;
            return group;
        }
    }
}
    

    internal class GroupRepository
    {
    }
