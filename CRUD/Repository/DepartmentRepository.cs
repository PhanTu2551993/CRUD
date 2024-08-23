using CRUD.Data;
using CRUD.Models;
using CRUD.Repository.IRepository;

namespace CRUD.Repository
{
    public class DepartmentRepository : Repository<Department>,IDepartmentRepository
    {
        public DepartmentRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
