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
            var w2 = new View2();

            w1.Show();
            w2.Show();
        }
    }
}
