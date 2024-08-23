

using CRUD.Data;
using CRUD.Models;
using CRUD.Service;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public async Task<IActionResult> IndexDepartment()
        {
            var departments = await _departmentService.GetAllDepartmentsAsync();
            return View(departments ?? new List<Department>()); 
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Department department)
        {
            if (ModelState.IsValid)
            {
                await _departmentService.AddDepartmentAsync(department);
                return RedirectToAction(nameof(IndexDepartment));
            }
            return View(department);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var department = await _departmentService.GetDepartmentByIdAsync(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Department department)
        {
            if (ModelState.IsValid)
            {
                await _departmentService.UpdateDepartmentAsync(department);
                return RedirectToAction(nameof(IndexDepartment));
            }
            return View(department);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _departmentService.DeleteDepartmentAsync(id);
            return RedirectToAction(nameof(IndexDepartment));
        }


    }
}
