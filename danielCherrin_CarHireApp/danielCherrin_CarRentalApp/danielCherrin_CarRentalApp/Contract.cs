using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danielCherrin_CarRentalApp
{
    public class Contract
    {
        public int contractNo;
        public int empNo;
        public int customerNo;
        public string VIN;
        public string pickupDate;
        public string pickupTime;
        public string returnDate;
        public string returnTime;
        public float discount;
        public double cost;
        public int odoReadingOutbound;
        public int odoReadingInbound;
        public string observationsOut;
        public string observationsIn;
    }
}
