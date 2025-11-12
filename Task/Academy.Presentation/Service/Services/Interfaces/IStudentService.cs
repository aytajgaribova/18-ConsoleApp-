namespace Service.Services.Interfaces
{
    public interface IStudentService
    {
        Student CreateStudent(int groupId, Student student);
        Student UptadeStudent(int id, Student student);
        void DeleteStudent(int id);
        Student GetStudentById(int id);
        List<Student> GetStudentsByAge(int age);
        List<Student> GetAllStudentsByGroupId(int groupId);
        List<Student> SearchMethodForStudentsByNameorSurname(string nameorSurname);
    }

    public class Student
    {
    }
}