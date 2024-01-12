namespace Facade;

public class DepartmentInformationManagement
{
    public string GetDepartment(Guid employeeId)
    {
        // Simulate fetching department information from a database
        return $"Employee with {employeeId} id is working in the Accountant department";
    }
}

