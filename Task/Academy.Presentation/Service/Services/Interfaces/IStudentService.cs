using LibrarySystem.Domain.Entities;
namespace LibrarySystem.Service.Services.Interfaces
{
    public interface IStudentService
    {
        Student Create(int groupId, Student student);
    }
}