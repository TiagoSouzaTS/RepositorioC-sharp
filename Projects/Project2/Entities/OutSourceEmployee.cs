using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;

namespace Project2.Entities
{
    internal sealed class OutSourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourceEmployee() { 
        
        }

        public OutSourceEmployee(double additionalCharge, string name, int hours, double valuePerHour) : base(name, hours, valuePerHour) {

            AdditionalCharge = additionalCharge;
        }

        public sealed override double Payment() {

           double x = base.Payment();
            return x + ((AdditionalCharge * 110) / 100);

        }
    }
}
