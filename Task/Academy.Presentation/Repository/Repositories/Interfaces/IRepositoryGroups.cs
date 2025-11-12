namespace Repository.Repostories.Interfaces
{
public interface IRepositoryGroup<T> where T : BaseEntity
    {
        void CreateGroup(T data); //1
        void UpdateGroup(T data); //2
        void DeleteGroup(T data); //3
        T GetGroupById(Predicate<T> predicate); //4
        List<T> GetAllGroupsByTeacher(Predicate<T> predicate); //5
        List<T> GetAllGroupsByRoom(Predicate<T> predicate); //6
        List<T> GetAllGroups(Predicate<T> predicate);  //7
        T SearchMethodForGroupsByName(Predicate<T> predicate); //8
    }
}