using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatUI.Background.HelpData
{
    public class EulerAngle2 : Vector2
    {
       
        public EulerAngle2()
        {
            SetAngle(0);
        }

        public EulerAngle2(double angle)
        {
            SetAngle(angle);
        }

        public double Angle
        {
            get => GetAgnle();
        }

        public void SetAngle(double angle)
        {
            _x = Math.Cos(angle);
            _y = Math.Sin(angle);
        }

        public void SetAngle(EulerAngle2 angle)
        {

        }

        public double GetAgnle()
        {
            return Math.Atan2(_y, _x);
        }


        public void RotateAngle(double deltaAngle)
        {
            double x = X * Math.Cos(deltaAngle) - Y * Math.Sin(deltaAngle);
            double y = Y * Math.Cos(deltaAngle) + X * Math.Sin(deltaAngle);
            X = x;
            Y = y;
        }

        public void RotateAngle(EulerAngle2 angle)
        {
            double x = X * angle.X - Y * angle.Y;
            double y = Y * angle.X + X * angle.Y;
            X = x;
            Y = y;
        }

    }
}
