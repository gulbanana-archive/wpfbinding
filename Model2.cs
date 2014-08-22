using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfbinding
{
    class Model2
    {
        public double Data { get; set; }
        public IEnumerable<CalculatedResult> CalculatedResults { get; set; }
    }
}
