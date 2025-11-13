using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IStudentService
    {
        Student Create(Student student);
        Student Update(int id, Student student);
        void Delete(int id);
        Student GetById(int id);
        List<Student> GetByGroup(string groupName);
        List<Student> GetAll();
        List<Student> Search(string searchText);
    }
}
