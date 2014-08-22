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
            w1.DataContext = new Model1 { Data = 1.0 };

            var w2 = new View2();
            w2.DataContext = new Model2 { Data = 1.0 };

            w1.Show();
            w2.Show();
        }
    }
}
