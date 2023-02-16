using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Move : Customer
    {
        private string custName;
        private string prevState;
        
        Move(string custName, string prevState) 
            :base('C')
        {
            this.custName = custName;
            this.prevState = prevState;

        }

        protected override string getCustomerInfo()
        {
            return ("Moved from "+prevState+". Ticket Number "+getTicketNumber()+". Name: "+custName);
        }
    }
}
