using System.Text.RegularExpressions;
namespace Service.Services.Interfaces
{
    public interface IGroupService
    {
        Group Create(Group group);
        Group Update(int id, Group group);
        void Delete(int id);
        Group GetById(int id);
    }
}