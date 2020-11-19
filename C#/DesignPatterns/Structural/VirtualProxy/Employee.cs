using System.Text;

namespace VirtualProxy
{
    public sealed class Employee
    {
        public string EmployeeName { get; }
        public decimal EmployeeSalary { get; }
        public string EmployeeDesignation { get; }

        public Employee(string employeeName, decimal employeeSalary, string employeeDesignation)
        {
            EmployeeName = employeeName;
            EmployeeSalary = employeeSalary;
            EmployeeDesignation = employeeDesignation;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            return builder.Append($"Employee Name: {EmployeeName}, EmployeeDesignation: {EmployeeDesignation}, Employee Salary: {EmployeeSalary}").ToString(); // REPLACE?
        }
    }
}