using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHW
{
    // -Create a Polygon class that inherits from Shape. 
    // This class will handle uncommon shapes that do not 
    // fall under common classifications, such as Rectangle, Circle, or Triangle.
    class Polygon : Shape, IEnumerable
    {
        private int _numberOfSides;
        public List<double> SizeLengths = new List<double>();
        
        //constructors
        public Polygon(params double[] sides)
        {
            this._numberOfSides = sides.Length;
            this.SizeLengths = sides.ToList();
        }

        /* Tried to include a private method per the instructions, but it can't override the public abstract class.
        private double CalculatePerimeter()
        {
            return SizeLengths.Sum();
        }
        */

        public override double CalculatePerimeter()
        {
            return SizeLengths.Sum();
        }

        // Tried to add the static keyword per instructions, but it won't compile due to "An object reference is required for the nonstatic field, method, or property"
        public static double CalculatePerimeter(params double[] sides)
        {
            /* More verbose method...
            double sum = 0;
            int i = 0;
            while (i < SizeLengths.Count)
            {
                sum += SizeLengths[i];
                i++;
            };
            return sum;
            */
            return SizeLengths.Sum();
        }


        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)SizeLengths).GetEnumerator();
        }

        //destructor
        ~Polygon()
        {
        }
    }
}
