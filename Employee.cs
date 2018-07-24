using System;
using Person;

namespace Employee
{
    public class Employee : Person.Person
    {
        public string department;
        public int employeeID;
        public string DOJ;
        public Employee(int ID, string firstName, string lastName, string DOB, string department, int employeeID, string join) : 
        base(ID, firstName, lastName, DOB){
            this.department=department;
            this.employeeID=employeeID;
            this.DOJ=join;
        }
    }
}