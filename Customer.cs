using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public abstract class Customer{
        private readonly char letter;
        private readonly int number;

        private static int nextANum = 0;
        private static int nextBNum = 0;
        private static int nextCNum = 0;
        private static int nextDNum = 0;

        public Customer() { 
            letter = 'X';
            number= 0;
        }

        public Customer(char letter) {
            switch (letter)
            {
                case 'A':
                    this.letter = 'A';
                    number = nextANum++;
                    break;

                case 'B':
                    this.letter = 'B';
                    number = nextBNum++;
                    break;

                case 'C':
                    this.letter = 'C';
                    number= nextCNum++;
                    break;

                case 'D':
                    this.letter = 'D';
                    number = nextDNum++;
                    break;

                default:
                    Console.WriteLine("“Error, letter must be A, B, C or D");
                    this.letter = 'X';
                    number = 0;
                    break;
            }
        }

        protected string getTicketNumber() {
            return letter.ToString() + number;
        }

        protected abstract string getCustomerInfo();


    }

}
