namespace OrgSphere.OrgSphere.Domain.Entities
{
    public class Department
    {
        public int Id { get; set; }

        public string Code { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; }

        public ICollection<Employee> Employees { get; set; }
            = new List<Employee>();
    }
}
