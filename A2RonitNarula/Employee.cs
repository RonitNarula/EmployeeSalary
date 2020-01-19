using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2RonitNarula
{
    /*
     * A data type called EmployeeType is created to store type of employee
     */
    enum EmployeeType
    {
        SalariedEmployee, HourlyEmployee, CommissionEmployee
    }

    abstract class Employee
    {
        private string _name;
        
        /*
         * Property Name that sets and gets employees name
         */
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private EmployeeType _typeOfEmployee;

        /*
         * Property to set and get employee type
         */
        public EmployeeType TypeOfEmployee
        {
            get { return _typeOfEmployee; }
            set { _typeOfEmployee = value; }
        }

        /*
         * An abstract method that must be overriden in the derived class
         */
        public abstract double GrossEarnings
        {
            get;
        }

        /*
         * A read only property that returns tax
         */
        public double Tax
        {
            get
            {
                return 0.2 * GrossEarnings;
            }
        }

        /*
         * A read only property that returns net earnings
         */
        public double NetEarnings
        {
            get
            {
                return GrossEarnings - (0.2 * GrossEarnings);
            }
        }

        private double _hoursWorked;

        /*
         * Property that gets and sets number of hours worked
         */
        public virtual double HoursWorked
        {
            get { return _hoursWorked; }
            set { _hoursWorked = value; }
        }

        private double _hourlyWage;


        /*
         * Virtual Property that gets and sets hourly wage and can be overriden in the derived class
         */
        public virtual double HourlyWage
        {
            get { return _hourlyWage; }
            set { _hourlyWage = value; }
        }

        private double _grossSales;

        /*
         * Virtual Property that gets and sets gross sales and can be overriden in the derived class
         */
        public virtual double GrossSales
        {
            get { return _grossSales; }
            set { _grossSales = value; }
        }

        private double _commissionRate;

        /*
         * Virtual Property that gets and sets commission rate and can be overriden in the derived class
         */
        public virtual double CommissionRate
        {
            get { return _commissionRate; }
            set { _commissionRate = value; }
        }

        private double _weeklySalary;

        /*
         * Virtual Property that gets and sets weekly salary and can be overriden in the derived class
         */
        public virtual double WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }


        /*
         * A Parametrized constructor that accteptts the employee name and type
         */
        public Employee(string name, EmployeeType typeOfEmployee)
        {
            Name = name;
            TypeOfEmployee = typeOfEmployee;
        }
    }
}
