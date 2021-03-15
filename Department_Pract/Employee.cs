using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Department_Pract
{
    class Employee
    {
        string name;
        string surname;
        uint salary;
       
        public string Name
        {
            get => name;
            set
            {
                if (value.All(char.IsDigit) || string.IsNullOrWhiteSpace(value))
                    throw new NameException("Login is incorrect");
                else
                    name = value;
            }
        }
        public string Surname
        {
            get => surname;
            set
            {
                if (value.All(char.IsDigit) || string.IsNullOrWhiteSpace(value))
                    throw new NameException("Login is incorrect");
                else
                    surname = value;
            }
        }
        public uint Salary
        {
            get => salary;
            set => salary = value;
            
        }
        public void RefreshSalary()
        {
            Console.Write("Write salary: ");
            while (true)
            {
                try
                {
                    checked
                    {
                        uint s = uint.Parse(Console.ReadLine());
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }

        }
    }
}
