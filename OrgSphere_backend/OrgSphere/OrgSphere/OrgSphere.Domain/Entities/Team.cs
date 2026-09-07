namespace OrgSphere.OrgSphere.Domain.Entities
{
    public class Team
    {
        public int Id { get; set; }

        public int DepartmentId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;

        public Department Department { get; set; } = null!;

        public ICollection<Employee> Employees { get; set; }
            = new List<Employee>();
    }
}
