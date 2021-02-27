using System;
using static System.Console;

namespace Project1
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Level { get; set; }
        public DateTime DateHired { get; set; }
        public DateTime DateTraining { get; set; }
        public double Salary { get; set; }
        public string GetPropertyValues()
        {
            if (FirstName == null)
            {
                Write("Enter the employee's first name: " + "\n");
                string a = ReadLine();
                if (a.Length == 0)
                {
                    Write("Please enter valid response: " + "\n" + "\n");
                    return GetPropertyValues();
                }
                FirstName = a;
            }
            if (LastName == null)
            {
                Write("Enter the employee's last name: " + "\n");
                string a = ReadLine();
                if (a.Length == 0)
                {
                    Write("Please enter valid response: " + "\n" + "\n");
                    return GetPropertyValues();
                }
                LastName = a;
            }
            if (Department == null)
            {
                Write("Enter the employee's department: " + "\n");
                string a = ReadLine();
                if (a.Length == 0)
                {
                    Write("Please enter valid response: " + "\n" + "\n");
                    return GetPropertyValues();
                }
                Department = a;
            }
            if (Level == null)
            {
                Write("Enter the employee's level: " + "\n");
                string a = ReadLine();
                if (a.Length == 0)
                {
                    Write("Please enter valid response: " + "\n");
                    return GetPropertyValues();
                }
                Level = a;
            }
            return FirstName;
        }
        public DateTime HiredDate()
        {
            string HireDate = ReadLine();
            DateTime q;
            bool response;
            do
            {
                Write("Please enter a valid hire date." +"\n");
                response = DateTime.TryParse(Console.ReadLine(), out q);
                DateHired = q;
            } while (!response);
            return DateHired;
        }
        public DateTime AddedDays()
        {
            DateTraining = DateHired.AddDays(100);
            return DateTraining;
        }
        public double GetSalary()
        {
            double q;
            bool response; 
            do
            {
                Write("Please enter a valid salary." +"\n");
                response = double.TryParse(ReadLine(), out q);
                Salary = q;
            } while (!response);
            return Salary;
        }
        public void Display()
        {
            Write("Employee first name: " + FirstName + "\n" +
                 "Employee last name: " + LastName + "\n" +
                 "Employee department: " + Department + "\n" +
                 "Date hired: " + (DateHired.ToString("MM/dd/yyyy")) + "\n" +
                 "Training date: " + (DateTraining.ToString("MM/dd/yyyy")) +"\n" +
                 "Employee level: " + Level + "\n" +
                 "Employee salary: " + Salary.ToString("C") + "\n" );
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            DateTime DateTraining = e.DateTraining;
            e.GetPropertyValues();
            e.GetPropertyValues();
            e.GetPropertyValues();
            e.GetPropertyValues();
            e.GetSalary();
            e.HiredDate();
            e.DateTraining = e.AddedDays();
            WriteLine("");
            e.Display();
        }
    }
}
