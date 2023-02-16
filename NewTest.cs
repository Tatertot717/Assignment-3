using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class NewTest : Customer
    {
        private readonly string custName;
        private readonly string dateOfBirth;
        
        NewTest(string custName, string dateOfBirth) 
            :base('A')
        {
            this.custName = custName;
            this.dateOfBirth = dateOfBirth;

        }

        protected override string getCustomerInfo()
        {
            return ("New Driver's License. Ticket Number "+getTicketNumber()+". Name: "+custName+", DOB: "+dateOfBirth);
        }
    }
}
