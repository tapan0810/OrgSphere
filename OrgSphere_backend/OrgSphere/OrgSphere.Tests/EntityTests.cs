using NUnit.Framework;
using OrgSphere.OrgSphere.Domain.Entities;

namespace OrgSphere.Tests;

[TestFixture]
public sealed class EntityTests
{
    [Test]
    public void NewEmployee_IsActiveByDefault()
    {
        var employee = new Employee();
        Assert.That(employee.IsActive, Is.True);
    }

    [Test]
    public void NewDepartment_StartsWithEmptyEmployeeCollection()
    {
        var department = new Department();
        Assert.That(department.Employees, Is.Empty);
    }

    [Test]
    public void NewLocation_StartsWithEmptyEmployeeCollection()
    {
        var location = new Location();
        Assert.That(location.Employees, Is.Empty);
    }
}
