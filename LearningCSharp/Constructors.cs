using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace LearningCSharp
{
    public class Constructors
    {
        private ITestOutputHelper _output;

        public Constructors(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void HiringSomeone()
        {
            var judy = new Employee("Judy", "TV", 120000M);

            Assert.Equal("Judy", judy.Name);
            //employee.Name = "Jocelyn";

            var tempSue = new Employee("Sue", "HR");
            Assert.Equal("Sue", tempSue.Name);
            Assert.Equal(0, tempSue.Salary);

            var retiree = new Retiree("Ben", "Smith", 180000);


            var folks = new List<Person> { judy, tempSue, retiree };

            foreach (var p in folks)
            {
                _output.WriteLine(p.GetInfo());
                _output.WriteLine(p.GetCompensation());
            }


        }
    }

    public abstract class Person
    {
        public Person(string name, string department)
        {
            Name = name;
            Department = department;
        }
        public string Name { get; protected set; }
        public string Department { get; protected set; }

        public virtual string GetInfo()
        {
            return $"{Name} works in {Department}";
        }

        public abstract string GetCompensation();

    }
    public class Employee : Person
    {

        public Employee(string name, string department, decimal salary) : base(name, department)
        {
            Salary = salary;
        }

        public Employee(string name, string department) : this(name, department, 0) { }

        public decimal Salary { get; private set; }
        public override string GetInfo()
        {
            return base.GetInfo() + $" Is an employee with a salary of {Salary:c}";
        }

        public override string GetCompensation()
        {
            return $"As an employee, {Name} gets a SALARY of {Salary:c}";
        }
    }

    public class Retiree : Person
    {

        public Retiree(string name, string department, decimal pension) : base(name, department)
        {
            Pension = pension;
        }
        public decimal Pension { get; private set; }

        public override string GetCompensation()
        {
            return $"As a Retiree, {Name} gets a PENSION of {Pension:c}";
        }
    }
}
