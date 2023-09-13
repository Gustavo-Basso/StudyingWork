using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerPayment.Entities {
    internal class Department {


        public string DPName { get; set; }

        public Department (string DPName) {
            this.DPName = DPName;

        }
        public Department () { }

    }
}
