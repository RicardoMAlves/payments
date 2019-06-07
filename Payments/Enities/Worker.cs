using System.Globalization;
using Payments.Enities.Enums;

namespace Payments.Enities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public override string ToString()
        {
            return Name + ", " + Level + ", " + BaseSalary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
