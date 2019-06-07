using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Payments.Enities
{
    class HourContract
    {
        public DateTime date { get; set; }
        public double valuePerHour { get; set; }
        public int hours { get; set; }

        public double totalValue()
        {
            return valuePerHour * hours;
        }

        public override string ToString()
        {
            return date + ", " + valuePerHour.ToString("F2", CultureInfo.InvariantCulture) + ", " + hours;
        }
    }
}
