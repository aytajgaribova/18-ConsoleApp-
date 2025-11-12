using Service.Services.Interfaces;
namespace Academy.Presentation.Service.Services.Implementations
{
    public class StudentService : IStudentService
    {

        public StudentRepository _studentRepository;
        private GroupRepository _groupRepository;
        private int _count = 1;
        private Student student;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
            _groupRepository = new GroupRepository();
        }
        public Student CreateStudent(int groupId, Student Student)
        {
            var group = _groupRepository.Get(g=>g.Id == groupId);

            if (group is null) return null;

            student.Id = _count;

            student.Group = group;

            _studentRepository.Create(student);

            _count++;

            return student;
        }


        public void DeleteStudent(int id)
        {
            Student student = GetStudentById(id);
            _studentRepository.DeleteStudent(student);
        }

        public List<Student> GetAllStudentsByGroupId(int groupId)
        {
            List<Student> students = _studentRepository.GetAll(s => s.Group.Id == id);
            return students;
        }

        public Student GetStudentById(int groupId)
        {
            Student student = _studentRepository.Get(g => g.Id == GroupId);
            if (student == null) return null;
            return student;
        }

        public List<Student> GetStudentsByAge(int age)
        {
            List<Student> students = _studentRepository.GetAll(s => s.Age == age);
            return null;
        }

        public List<Student> SearchMethodForStudentsByNameorSurname(string nameorSurname)
        {
            List<Student> studentname = _studentRepository.GetAll(s => s.Name.Trim().ToLower().Equals(nameorSurname.Trim(), StringComparison.CurrentCultureIgnoreCase));
            List<Student> studentsurname = _studentRepository.GetAll(s => s.SurName.Trim().ToLower().Equals(nameorSurname.Trim(), StringComparison.CurrentCultureIgnoreCase));
            if (studentname.Count > 0)
            {
                return studentname;
            }
            else if(studentsurname.Count> 0)
            {
                return studentsurname;
            }
            else
            {
                return null;
            }
            
        }

        public Student UptadeStudent(int id, Student student)
        {
            Student students = GetStudentById(id);
            if (student is null) return null;
            students.Name = student.Name
            students.Surname = student.Surname;
            students.Age = student.Age;
            students.Group = student.Group;
            _studentRepository.Update(student);
            return GetStudentById(id);
                
            

        }
    }

    internal class StudentRepository
    {
        internal List<Student> GetAll(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}