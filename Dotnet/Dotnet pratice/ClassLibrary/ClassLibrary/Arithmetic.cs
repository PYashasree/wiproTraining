using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Arithmetic
    {
        public static  void Main(String[] args)
        {

        }
        public int? Add(int? a, int? b)
        {
            if (a == null || b == null)
                return null; 

            return a.Value + b.Value; 
        }

        public int? Subtract(int? a, int? b)
        {
            if (a == null || b == null)
                return null; 

            return a.Value - b.Value; 
        }

        public int? Multiply(int? a, int? b)
        {
            if (a == null || b == null)
                return null;

            return a.Value * b.Value;
        }

        public int? Square(int? a)
        {
            if (a == null)
                return null; 

            return a.Value * a.Value; 
        }
    }
}
