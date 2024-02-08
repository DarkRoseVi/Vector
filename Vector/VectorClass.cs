using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    internal class VectorClass
    {
        public  double x;
        public double y;
        public double z;
        public VectorClass(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

      public  double Length => Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
      
        public void PrintLenth() 
        {
            Console.WriteLine("Length " + Length);
        }
        public void Print()
        {
            Console.WriteLine(x + " "+ y + " " + z);
        }

        public  VectorClass AddVector ( VectorClass vector2)
        {
            double sumX = x + vector2.x;
            double sumY = y + vector2.y;
            double sumZ = z + vector2.z;
            return new VectorClass(sumX, sumY,sumZ);
        }
        public VectorClass Subtract(VectorClass vector2)
        {
            double sumX = x - vector2.x;
            double sumY = y - vector2.y;
            double sumZ = z - vector2.z;
            return new VectorClass(sumX, sumY, sumZ);
        }
    }
    
}
