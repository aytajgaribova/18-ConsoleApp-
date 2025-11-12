namespace Repository.Repostories.Interfaces
{
    public interface IRepositoryStudent<T> where T : BaseEntity
    {
        void CreateStudent(T data); //8
        void UpdateStudent(T data); //9
        T GetStudentById(Predicate<T> predicate); //10
        void DeleteStudent(T data); //11
        List<T> GetStudentsByAge(Predicate<T> predicate);  //12
        List<T> GetAllStudentsByGroupId(Predicate<T> predicate); //13
        List<T> SearchMethodForStudentsByNameorSurname(Predicate<T> predicate); //14
    }

    public class BaseEntity
    {
    }
}