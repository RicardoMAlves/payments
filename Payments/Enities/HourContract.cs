using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Payments.Enities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public double totalValue()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            return Date + ", " + ValuePerHour.ToString("F2", CultureInfo.InvariantCulture) + ", " + Hours;
        }
    }
}
