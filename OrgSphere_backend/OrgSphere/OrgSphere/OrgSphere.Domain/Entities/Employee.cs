namespace OrgSphere.OrgSphere.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string EmployeeCode { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string? Phone { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateOfJoining { get; set; }

        public string JobTitle { get; set; } = string.Empty;

        public decimal Salary { get; set; }

        public int DepartmentId { get; set; }

        public int? TeamId { get; set; }

        public int? ManagerId { get; set; }

        public int LocationId { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

    }
}
