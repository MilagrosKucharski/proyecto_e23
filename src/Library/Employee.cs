using System;

namespace Library
{
    public class Employee
    {
        //builder
        public Employee(string employeename,int employeeage,string employeelocation,int employeequalification,int employeecellphone)
        {
            this.EmployeeName = employeename;
            this.EmployeeAge=employeeage;
            this.EmployeeLocation=employeelocation;
            this.EmployeeQualification=employeequalification;
            this.EmployeeCellphone=employeecellphone;
        }

        //atributos
        public string EmployeeName {get; set;}
        public int EmployeeAge {get; set;}
        public string EmployeeLocation {get; set;}
        public int EmployeeQualification {get; set;}
        public int EmployeeCellphone {get; set;}

        //metodos
        //public int GetEmployeeQualification()


        public string GetEmployeeDataInformation(string EmployeeName, int EmployeeAge, string EmployeeLocation, int EmployeeQualification, int EmployeeCellphone)
        {
            return $"{this.EmployeeName}\n{this.EmployeeAge}\n{this.EmployeeLocation}\n{this.EmployeeQualification}\n{this.EmployeeCellphone}";

        }
    }
}