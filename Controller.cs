using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfbinding
{
    class Controller
    {
        public Controller()
        {
            var w1 = new View1();
            w1.DataContext = new Model1 { DoCalculate = new DelegateCommand<Model1>(this.Model1_DoCalculate) };

            var w2 = new View2();
            w2.DataContext = new Model2 { CalculationCallback = this.Calculate };

            w1.Show();
            w2.Show();
        }

        private IEnumerable<CalculatedResult> Calculate(double data)
        {
            for (int i = 0; i < 10; i++)
            {
                yield return new CalculatedResult {Formula = "+"+i.ToString(), Result = data+i};
            }
        }

        private void Model1_DoCalculate(Model1 viewModel)
        {
            viewModel.CalculatedResults = Calculate(viewModel.Data);
        }
    }
}
