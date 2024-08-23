using CRUD.Data;
using CRUD.Models;
using CRUD.Repository.IRepository;

namespace CRUD.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
