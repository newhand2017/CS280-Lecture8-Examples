using MathExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Vector : IComparable<Vector>
    {
        //-------------------------------------------------
        // Cliam
        //-------------------------------------------------
        public double X { get; set; }

        public double Y { get; set; }

        public static int Selection { get; set; }

        public Vector(Random random)
        {
            //Random random = new Random(); //會造成種子相同而亂數也相同

            this.X = random.NextDouble(-100.0, 100.0);
            this.Y = random.NextDouble(-100.0, 100.0);
        }

        //For User Input
        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double Length
        {
            get
            {
                return (Math.Sqrt(this.X * this.X + this.Y * this.Y));
            }
        }

        //-------------------------------------------------
        //Sort Function
        //-------------------------------------------------
        /*
          public int CompareTo(Vector other)
          {
              switch (Vector.Selection)
              {
                  case 1:
                      {
                          if (this.X < other.X)
                              return -1;
                          else if (this.X == other.X)
                              return 0;
                          else
                              return 1;

                          break;
                      }
                  case 2:
                      {
                          if (this.Y < other.Y)
                              return -1;
                          else if (this.Y == other.Y)
                              return 0;
                          else
                              return 1;

                          break;
                      }

                  default:
                  case 3:
                      {
                          if (this.Length < other.Length)
                              return -1;
                          else if (this.Length == other.Length)
                              return 0;
                          else
                              return 1;

                          break;
                      }
              }
          }
          */

        //精簡版
        public int CompareTo(Vector other)
        {
            switch (Vector.Selection)
            {
                case 1:
                    return this.Compare(this.X, other.X);

                case 2:
                    return this.Compare(this.Y, other.Y);

                default:
                case 3:
                    return this.Compare(this.Length, other.Length);
            }
        }

        private int Compare(double a, double b)
        {
            if (a < b)
                return -1;
            else if (a == b)
                return 0;
            else
                return 1;
        }

        //-------------------------------------------------
        //Output Result
        //-------------------------------------------------
        public override string ToString()
        {
            return string.Format("Vector = ({0}, {1}), Length = {2}", this.X, this.Y, this.Length);
        }

        //-------------------------------------------------
    }
}