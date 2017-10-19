using BoatUI.Background.HelpData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoatUI.UI.Methods
{
    class PointLine
    {
        private int _pointX, _pointY, _length;

        private EulerAngle2 _angle;

        public PointLine(int x, int y, int length)
        {
            
            _pointX = x;
            _pointY = y;
            _length = length;
            _angle = new EulerAngle2();
        }

        public PointLine(int x, int y, int length, double angle)
        {
            
            _pointX = x;
            _pointY = y;
            _length = length;
            _angle = new EulerAngle2(angle);
        }

        //Function that rotates the angle
        public void Rotate(double deltaAngle)
        {
            _angle.RotateAngle(deltaAngle);
        }

        //Getters used to get the draw points
        //Returns the start points
        public System.Drawing.Point GetStartPoint
        {
            get
            {
                return new System.Drawing.Point(_pointX, _pointY);
            }
        }

        //Gets the end points of the line
        public System.Drawing.Point GetEndPoint
        {
            get
            {
                int endX = (int)(_angle.X * _length) + _pointX;
                int endY = (int)(_angle.Y * _length) + _pointY;
                return new System.Drawing.Point(endX, endY);
            }
        }

        public int PointX { get => _pointX; }
        public int PointY { get => _pointY; }
    }
}
