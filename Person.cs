using System;

namespace Person
{
    public class Person
    {
        public int ID;
        public string firstName;
        public string lastName;
        public string DOB;
        public Person (int ID, string first, string last, string birth){
            this.ID=ID;
            this.firstName=first;
            this.lastName=last;
            this.DOB=birth;
        }
    }
}
