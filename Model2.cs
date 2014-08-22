using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;

namespace wpfbinding
{
    class Model2 : BindableBase
    {
        private double data;
        public double Data
        {
            get { return data; }
            set { SetProperty(ref data, value); CalculatedResults = CalculationCallback(value); }
        }

        private IEnumerable<CalculatedResult> calculatedResults;
        public IEnumerable<CalculatedResult> CalculatedResults
        {
            get { return calculatedResults; }
            set { SetProperty(ref calculatedResults, value); }
        }

        public Func<double, IEnumerable<CalculatedResult>> CalculationCallback { get; set; }
    }
}
