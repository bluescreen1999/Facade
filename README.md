# Employee Management System Facade

## Overview

This project implements the Facade design pattern in C# to simplify the interaction with an Employee Management System. The `EmployeeFacade` class serves as a unified interface, providing convenient methods for accessing employee details such as personal information, department information, and salary information.

## Design

The system is divided into three separate classes, each responsible for managing a specific aspect of employee information:

- **PersonalInformationManagement**: Manages personal information, such as the full name of an employee.

- **DepartmentInformationManagement**: Manages department-related information for an employee.

- **SalaryInformationManagement**: Manages salary information for an employee.

The `EmployeeFacade` class aggregates instances of these management classes and exposes a single method, `DisplayEmployeeDetails(Guid employeeId)`, to retrieve and display comprehensive employee details.

## Usage

To use the Employee Management System Facade, follow these steps:

1. **Create an instance of the `EmployeeFacade` class**:

    ```csharp
    EmployeeFacade employeeFacade = new EmployeeFacade();
    ```

2. **Retrieve and display employee details using the facade**:

    ```csharp
    employeeFacade.DisplayEmployeeDetails(Guid.Parse("e7fd1253-3c1c-473c-9671-1afa012c681e"));
    ```

## Example

```csharp
EmployeeFacade employeeFacade = new EmployeeFacade();
employeeFacade.DisplayEmployeeDetails(Guid.Parse("e7fd1253-3c1c-473c-9671-1afa012c681e"));
