using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatUI.Background.HelpData
{
    class DVector2
    {
        private double _x, _y;

        public DVector2()
        {

        }

        public DVector2(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }
    }
}
