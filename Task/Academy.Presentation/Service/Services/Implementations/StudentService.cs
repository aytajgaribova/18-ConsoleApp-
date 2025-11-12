using LibrarySystem.Domain.Entities;
using LibrarySystem.Repository.Repositories.Implementations;
using LibrarySystem.Service.Services.Interfaces;
namespace LibrarySystem.Service.Services.Implementations
{
    public class StudentService : IStudentService
    {
        private StudentRepository _studentRepository;
        private GroupRepository _groupRepository;
        private int _count = 1;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
            _groupRepository = new GroupRepository();
        }
        public Student Create(int groupId, Student Student)
        {
            var group = _groupRepository.Get(g=>g.Id == groupId);

            if (group is null) return null;

            student.Id = _count;

            student.Group = group;

            _studentRepository.Create(student);

            _count++;

            return student;
        }
    }
}