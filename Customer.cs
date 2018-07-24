using System;
using Person;

namespace Customer
{
    public class Customer : Person.Person
    {
        public string address;
        public string city;
        public string state;
        public Customer(int ID, string firstName, string lastName, string DOB, string address, string city, string state) : 
        base(ID, firstName, lastName, DOB){
            this.address=address;
            this.city=city;
            this.state=state;
        }
    }
}