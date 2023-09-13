using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace WorkerPayment.Entities {
    internal class HourContract {


        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hour { get; set; }


        public HourContract() { }

        public HourContract(DateTime date, double valuePerHour, int hour) {
            
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hour;
        }

        public double TotalValor() {

            return ValuePerHour * Hour;

        }

    }
}
