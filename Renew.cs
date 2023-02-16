using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Renew : Customer
    {
        private readonly string custName;

        public Renew(string custName)
            : base('B')
        {
            this.custName = custName;
        }

        public override string getCustomerInfo()
        {
            return ("Renewal License. Ticket Number " + getTicketNumber() + ". Name: " + custName);
        }
    }
}
