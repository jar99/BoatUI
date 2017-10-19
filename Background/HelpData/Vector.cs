using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatUI.Background.HelpData
{
    public class Vector2
    {
        protected double _x, _y;

        public Vector2()
        {

        }

        public Vector2(Vector2 vector)
        {
            _x = vector.X;
            _y = vector.Y;
        }

        public Vector2(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }

        internal protected double getR()
        {
            return Math.Sqrt(_x * _x + _y * _y);
        }

        public static Vector2 Normalize(Vector2 vector)
        {
            double r = vector.getR();
            return new Vector2(vector.X / r, vector.Y / r);
        }

    }

    public class Vector3
    {
        protected double _x, _y, _z;

        public Vector3()
        {

        }

        public Vector3(Vector3 vector)
        {
            _x = vector.X;
            _y = vector.Y;
            _z = vector.Z;
        }

        public Vector3(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }
        public double Z { get => _z; set => _z = value; }

        protected internal double getR()
        {
            return Math.Sqrt(_x * _x + _y * _y + _z * _z);
        }

        public static Vector3 Normalize(Vector3 vector)
        {
            double r = vector.getR();
            return new Vector3(vector.X / r, vector.Y / r, vector.Z / r);
        }
    }
}
