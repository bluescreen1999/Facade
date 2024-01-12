namespace Facade;

public class PersonalInformationManagement
{
    public string GetFullName(Guid employeeId)
    {
        // Simulate fetching personal information from a database
        return $"Employee with {employeeId} id full name is Jon P Smith";
    }
}