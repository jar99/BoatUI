using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatUI.Background.HelpData
{
    public class EulerAngle : Vector2
    {
       
        public EulerAngle()
        {
            SetAngle(0);
        }

        public EulerAngle(double angle)
        {
            SetAngle(angle);
        }

        public void SetAngle(double angle)
        {
            _x = Math.Cos(angle);
            _y = Math.Sin(angle);
        }

        public double GetAgnle()
        {
            return Math.Atan2(_y, _x);
        }

        public void AddAngle(double deltaAngle)
        {
            double x = _x + Math.Cos(deltaAngle);
            double y = _y + Math.Sin(deltaAngle);
            double r = Math.Sqrt(x * x + y * y);
            _x = x;
            _y = y;
        }
    }
}
