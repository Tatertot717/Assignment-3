using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Suspended : Customer
    {
        private string custName;
        private string violation;
        
        public Suspended(string custName, string violation) 
            :base('D')
        {
            this.custName = custName;
            this.violation = violation;

        }

        public override string getCustomerInfo()
        {
            return ("Violation: " + violation + ". Ticket Number " + getTicketNumber() + ". Name: " + custName);
        }
    }
}
