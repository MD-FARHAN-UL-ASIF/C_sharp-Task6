using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_Task_7
{
    class Employee
    {
        public string name;
        public string id;
        public string address;

        public Employee(string name, string id, string address)
        {
            this.name = name;
            this.id = id;
            this.address = address;
        }

        public void showInfo()
        {
            Console.WriteLine("Employee name: " + name);
            Console.WriteLine("Employee id: " + id);
            Console.WriteLine("Employee address: " + address);
        }


        public bool EmployeeStatus()
        {
            return false;
        }
    }

    class Laborer : Employee
    {
        public int userRating;
        public String chargePerService = "500 BDT";
        public int noOfService;

        public Laborer(String id, String name, String address, int userRating, int noOfService) : base(id, name, address)
        {
            this.userRating = userRating;
            this.noOfService = noOfService;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Laborer name: " + name);
            Console.WriteLine("Laborer id: " + id);
            Console.WriteLine("Laborer address: " + address);
            Console.WriteLine("EmployeeStatus:" + this.EmployeeStatus());
        }

        public bool EmployeeStatus()
        {
            return userRating > 70 && noOfService >= 10;
        }

        public int TotalEarn()
        {
            return 10000;
        }
    }

    class Manager : Employee
    {
        public int yearOfExperience;

        public Manager(String id, String name, String address, int yearOfExperience) : base(id, name, address)
        {
            this.yearOfExperience = yearOfExperience;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Manager name: " + name);
            Console.WriteLine("Manager id: " + id);
            Console.WriteLine("Manager address: " + address);
            Console.WriteLine("EmployeeStatus:" + this.EmployeeStatus());
        }

        public bool EmployeeStatus()
        {
            return yearOfExperience > 2;
        }
    }

    class ServiceProvider
    {
        public static List<Employee> employees = new List<Employee>();
        public static void Inset(Employee emp)
        {
            employees.Add(emp);
        }

        public static void ProvideDetails()
        {
            foreach (var emp in employees)
            {
                emp.showInfo();
            }
        }

        public static void SkilledWorker()
        {
            foreach (var emp in employees)
            {
                if (emp.GetType() == typeof(Laborer))
                {
                    Laborer laborer = (Laborer)emp;
                    if (laborer.userRating > 80)
                    {
                        laborer.showInfo();
                    }
                }
            }
        }

    }
}