using System;
namespace Library{
    public class Employer{
        public string EmployerName { get; set; }

        public string EmployerCellphone { get; set; }

        public int EmployerQualify { get; set; }

        public Employer(string employerName, string employerCellphone, int employerQualify){
            
            this.EmployerName = employerName;
            this.EmployerCellphone = employerCellphone;
            this.EmployerQualify = employerQualify;
        }
        //public string GetEmployeeDataInformation()
    }
}