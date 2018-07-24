using System;
using Person;
using Customer;
using Employee;

namespace main
{
   class Program
   {
        static void Main(string[] args)
        {
            int personID = 0;
            int workerID =100;

            Employee.Employee johnS = new Employee.Employee(personID++, "John", "Smith", "03/24/1992", "Sales", workerID++, "11/12/2010");
            Customer.Customer customer1 = new Customer.Customer(personID++, "Andrew", "Beans", "04/26/1985", "123 Parkway Lane", "Jerky", "Nevada");
            Employee.Employee codyG = new Employee.Employee(personID++, "Cody", "Godfreed", "05/07/2000", "Human Resources", workerID++, "08/05/2017");
            Employee.Employee harryP = new Employee.Employee(personID++, "Harry", "Potter", "11/13/1974", "Sales", workerID++, "06/30/1990");
            Customer.Customer customer2 = new Customer.Customer(personID++, "Nick", "Sharp", "12/26/1983", "456 Jungle Avenue", "Spoon", "Californa");
            Customer.Customer customer3 = new Customer.Customer(personID++, "Phil", "Write", "05/01/1957", "789 Space Boulevard", "Townsvill", "Oregon");
            Customer.Customer customer4 = new Customer.Customer(personID++, "Cleo", "Jones", "04/19/1935", "101 Teachers Way", "Springston", "Georgia");
            Employee.Employee zakJ = new Employee.Employee(personID++, "Zak", "Jack", "02/22/1992", "Marketing", workerID++, "01/24/2008");
            Customer.Customer customer5 = new Customer.Customer(personID++, "Jessica", "Whyzen", "06/20/1974", "258 Terror Drive", "Hampton", "Maine");
            Employee.Employee zackH = new Employee.Employee(personID++, "Zack", "Hound", "09/03/1969", "Public Relations", workerID++, "07/23/2018");
            
            Employee.Employee[] store = new Employee.Employee[5];
            Customer.Customer[] clients = new Customer.Customer[5];

            store[0] = johnS;
            store[1] = codyG;
            store[2] = harryP;
            store[3] = zakJ;
            store[4] = zackH;

            clients[0] = customer1;
            clients[1] = customer2;
            clients[2] = customer3;
            clients[3] = customer4;
            clients[4] = customer5;

            //Sorts Employees
            Employee.Employee[] storeHold = new Employee.Employee[1];
            for(int i = 0; i < store.Length; i++){
                for(int j = 0; j < store.Length;j++){
                    int c = string.Compare(store[j].firstName, store[i].firstName);
                    if(c==1){
                        storeHold[0] = store[i];
                        store[i] = store[j];
                        store[j] = storeHold[0];
                    }
                }
            }

            //Sorts Clients
            Customer.Customer[] clientHold = new Customer.Customer[1];
            for(int i = 0; i < clients.Length; i++){
                for(int j = 0; j < clients.Length;j++){
                    int c = string.Compare(clients[j].firstName, clients[i].firstName);
                    if(c==1){
                        clientHold[0] = clients[i];
                        clients[i] = clients[j];
                        clients[j] = clientHold[0];
                    }
                }
            }
            
            Console.WriteLine("This stores employees include:");
            for(int i = 0; i < store.Length; i++){
                Console.WriteLine($"PID: {store[i].ID} First Name: {store[i].firstName} Last Name: {store[i].lastName} Date of Birth: {store[i].DOB} " +
                $"Department: {store[i].department} Employee ID: {store[i].employeeID} Date Employeed: {store[i].DOJ}");
            }

            Console.WriteLine("This stores clients include:");
            for(int t = 0; t < clients.Length; t++){
                Console.WriteLine($"PID: {clients[t].ID} First Name: {clients[t].firstName} Last Name: {clients[t].lastName} Date of Birth:{clients[t].DOB} " +
                $"Address: {clients[t].address} City: {clients[t].city} State: {clients[t].state}");
            }
        }
    }
}