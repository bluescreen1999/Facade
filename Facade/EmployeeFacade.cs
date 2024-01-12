namespace Facade;

public class EmployeeFacade
{
    private PersonalInformationManagement _personalInfo;
    private DepartmentInformationManagement _departmentInfo;
    private SalaryInformationManagement _salaryInfo;

    public EmployeeFacade()
    {
        _personalInfo = new PersonalInformationManagement();
        _departmentInfo = new DepartmentInformationManagement();
        _salaryInfo = new SalaryInformationManagement();
    }

    public void DisplayEmployeeDetails(Guid employeeId)
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine(_personalInfo.GetFullName(employeeId));
        Console.WriteLine(_departmentInfo.GetDepartment(employeeId));
        Console.WriteLine(_salaryInfo.GetSalary(employeeId));
    }
}

