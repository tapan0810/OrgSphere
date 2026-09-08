using Microsoft.AspNetCore.Mvc;
using OrgSphere.OrgSphere.Domain.Entities;

namespace OrgSphere.OrgSphere.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class EmployeesController : ControllerBase
{
    private static readonly List<Employee> Employees = [];

    [HttpGet]
    public ActionResult<IEnumerable<Employee>> GetAll() => Ok(Employees);

    [HttpGet("{id:int}")]
    public ActionResult<Employee> GetById(int id)
    {
        var employee = Employees.FirstOrDefault(x => x.Id == id);
        return employee is null ? NotFound() : Ok(employee);
    }

    [HttpPost]
    public ActionResult<Employee> Create(Employee employee)
    {
        if (employee.Id != 0 || string.IsNullOrWhiteSpace(employee.EmployeeCode) || string.IsNullOrWhiteSpace(employee.Email))
            return BadRequest("Id must be 0 and employee code/email are required.");

        employee.Id = Employees.Count == 0 ? 1 : Employees.Max(x => x.Id) + 1;
        employee.CreatedAt = DateTime.UtcNow;
        Employees.Add(employee);
        return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, Employee employee)
    {
        var existing = Employees.FirstOrDefault(x => x.Id == id);
        if (existing is null) return NotFound();
        if (string.IsNullOrWhiteSpace(employee.EmployeeCode) || string.IsNullOrWhiteSpace(employee.Email)) return BadRequest();

        existing.EmployeeCode = employee.EmployeeCode;
        existing.FirstName = employee.FirstName;
        existing.LastName = employee.LastName;
        existing.Email = employee.Email;
        existing.Phone = employee.Phone;
        existing.JobTitle = employee.JobTitle;
        existing.Salary = employee.Salary;
        existing.DepartmentId = employee.DepartmentId;
        existing.TeamId = employee.TeamId;
        existing.ManagerId = employee.ManagerId;
        existing.LocationId = employee.LocationId;
        existing.IsActive = employee.IsActive;
        existing.UpdatedAt = DateTime.UtcNow;
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var employee = Employees.FirstOrDefault(x => x.Id == id);
        if (employee is null) return NotFound();
        Employees.Remove(employee);
        return NoContent();
    }
}
