namespace Facade;

public class SalaryInformationManagement
{
    public string GetSalary(Guid employeeId)
    {
        // Simulate fetching salary information from a database
        return $"Employee with {employeeId} id earns 50000$";
    }
}