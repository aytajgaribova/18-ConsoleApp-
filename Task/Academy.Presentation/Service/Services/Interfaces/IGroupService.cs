using System.Text.RegularExpressions;
namespace Service.Services.Interfaces
{
    public interface IGroupService
    {
        Group CreateGroup(Group group);
        Group Update(int id, Group group);
        void Delete(int id);
        Group GetById(int id);
        List<Group> Searchmethodforgroupsbyname(string name);
        List<Group> GetAll();
        List<Group> GetAllByRoom();
        List<Group> GetAllByTeacher();
    }
}