using CRUD.Models;
using CRUD.Repository;
using CRUD.Repository.IRepository;

namespace CRUD.Service.Impl
{
    public class DepartmentServiceImpl : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentServiceImpl(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task AddDepartmentAsync(Department department)
        {
            await _departmentRepository.CreateAsync(department);
        }

        public async Task DeleteDepartmentAsync(int id)
        {
            await _departmentRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
            var departments = await _departmentRepository.GetAllAsync();
            return departments ?? new List<Department>();
        }

        public async Task<Department> GetDepartmentByIdAsync(int id)
        {
            return await _departmentRepository.GetByIdAsync(id);
        }

        public async Task UpdateDepartmentAsync(Department department)
        {
            await _departmentRepository.UpdateAsync(department);
        }
    }
}
