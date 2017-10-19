using BoatUI.Background.HelpData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatUI.UI.Methods
{
    class PointLine
    {
        private int _pointX, _pointY;
        private int _length;

        private EulerAngle angle;

        PointLine(int x, int y, int length)
        {
            _pointX = x;
            _pointY = y;
            _length = length;
        }

        PointLine(int x, int y, int length, double angle)
        {
            angle = new EulerAngle(angle);
            _pointX = x;
            _pointY = y;
            _length = length;
        }
    }
}
