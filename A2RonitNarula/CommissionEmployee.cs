using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2RonitNarula
{
    class CommissionEmployee : Employee
    {
        private double _grossSales;

        /*
         * An overriden Property that gets and sets gross sales
         */
        public override double GrossSales
        {
            get { return _grossSales; }
            set { _grossSales = value; }
        }

        private double _commissionRate;

        /*
         * An overriden Property that gets and sets CommissionRate
         */
        public override double CommissionRate
        {
            get { return _commissionRate; }
            set { _commissionRate = value; }
        }

        /*
         * An overriden Property that gets and sets GrossEarnings
         */
        public override double GrossEarnings
        {
            get
            {
                return GrossSales * CommissionRate;
            }
        }

        /*
         * A Parametrized constructor that accteptts the employee name, type, grossSales and commissionRate
         */
        public CommissionEmployee(string name, EmployeeType typeOfEmployee, double grossSales, 
            double commissionRate):base(name, typeOfEmployee)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }
    }
}
