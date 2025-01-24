using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS06
{
    public class Point3D : ICloneable, IComparable<Point3D>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x = 0, int y = 0, int z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Point3D point)
            {
                return X == point.X && Y == point.Y && Z == point.Z;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (X, Y, Z).GetHashCode();
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        public int CompareTo(Point3D other)
        {
            if (X != other.X) return X.CompareTo(other.X);
            return Y.CompareTo(other.Y);
        }
    }
    }
