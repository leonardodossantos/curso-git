﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoUdemy
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percente)
        {
            Salary += Salary * percente / 100.0;
        }
        public override string ToString()
        {
            return Id 
                + ", " 
                + Name 
                + ", " 
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
