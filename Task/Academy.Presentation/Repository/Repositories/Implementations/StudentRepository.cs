using Repository.Data;
using Service.Services.Interfaces;

namespace Academy.Presentation.Repository.Repositories.Implementations
{
    public class StudentRepository : IRepository<Student>
    {
        public void Create(Student data)
        {
            try
            {
                if (data == null) throw new Exception("Student not found");
                AppDbContext<Student>.datas.Add(data);
            }
            catch (Exception ex)
            {

                System.Console.WriteLine(ex.Message);
            }
        }
        public void DeleteStudent(Student data)
        {
            AppDbContext<Student>.datas.Remove(data);
        }
        public Student GetStudent(Predicate<Student> predicate)
        {
            return predicate != null ? AppDbContext<Student>.datas.Find(predicate) : null;
        }
        public List<Student> GetAll(Predicate<Student> predicate)
        {

            return predicate != null ? AppDbContext<Student>.datas.FindAll(predicate) : AppDbContext<Student>.datas;
        }
        public void Update(Student data)
        {
            Student student = Get(s => s.Id == data.Id);
            if (student == null) return;
            if (!string.IsNullOrEmpty(student.Name))
            {
                student.Name = data.Name;
            }
            if (!string.IsNullOrEmpty(student.SurName))
            {
                student.Surname = data.Surname;
            }
            if (data.Age > 0)
            {
                student.Age = data.Age;
            }
            if (data.Group != null)
            {
                student.Group=data.Group;
            }
        }
    }
}