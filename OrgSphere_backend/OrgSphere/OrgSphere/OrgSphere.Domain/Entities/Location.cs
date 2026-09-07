namespace OrgSphere.OrgSphere.Domain.Entities
{
    public class Location
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public string? PostalCode { get; set; }

        public bool IsActive { get; set; } = true;

        public ICollection<Employee> Employees { get; set; }
            = new List<Employee>();
    }
}
