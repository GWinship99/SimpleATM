using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleATM
{
    // this class stores the important details of the card which the balance is being changed for
    public class CardDetails
    {
        public string CardholderName; // the full name of the person the card belongs to - this may not be needed but putting it in
                                      // just in case
        public string CardNumber; // the number that's on the bank card that the user wants to use
        public string Balance; // the amount of money that's on the card - to make it easier to program the ATM this will be 0 by default
        public string PIN = "1111"; // the PIN number that the user will use to verify their ID.
       
    }
}
