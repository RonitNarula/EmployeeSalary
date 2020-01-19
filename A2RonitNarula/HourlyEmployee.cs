using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2RonitNarula
{
    class HourlyEmployee : Employee
    {
        private double _hoursWorked;

        /*
         * An overriden Property that gets and sets HoursWorked
         */
        public override double HoursWorked
        {
            get { return _hoursWorked; }
            set { _hoursWorked = value; }
        }

        private double _hourlyWage;

        /*
         * An overriden Property that gets and sets HourlyWage
         */
        public override double HourlyWage
        {
            get { return _hourlyWage; }
            set { _hourlyWage = value; }
        }

        /*
         * An overriden Property that gets and sets GrossEarnings
         */
        public override double GrossEarnings
        {
            get
            {
                if (HoursWorked <= 40)
                    return HoursWorked * HourlyWage;
                else
                    return (40* HourlyWage) + (HoursWorked-40) * HourlyWage * 1.5;
            }
        }

        /*
         * A Parametrized constructor that accteptts the employee name, type, hoursWorked and hourlyWage
         */
        public HourlyEmployee(string name, EmployeeType typeOfEmployee, double hoursWorked, double hourlyWage)
            : base(name, typeOfEmployee)
        {
            HoursWorked = hoursWorked;
            HourlyWage = hourlyWage;
        }
    }
}
