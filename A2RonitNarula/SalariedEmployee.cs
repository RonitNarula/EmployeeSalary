using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2RonitNarula
{
    class SalariedEmployee : Employee
    {
        private double _weeklySalary;

        /*
         * An overriden Property that gets and sets WeeklySalary
         */
        public override double WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

        /*
         * An overriden Property that gets and sets GrossEarnings
         */
        public override double GrossEarnings
        {
            get
            {
                return WeeklySalary;
            }
        }

        /*
         * A Parametrized constructor that accteptts the employee name, type and weeklySalary
         */
        public SalariedEmployee(string name, EmployeeType typeOfEmployee, double weeklySalary)
            : base(name, typeOfEmployee)
        {
            WeeklySalary = weeklySalary;
        }
    }
}
