using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
        private double radius;
        public const double PI = System.Math.PI;//field
        public double Radius//property, not used in constructor because ????
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public Circle(double radius)
        {
            this.radius = radius;//initializing the variable
        }
        public double CalculateCircumference()
        {
            double circumference = PI * (2 * radius);
            return circumference;
            //allow for user input on number of decimal places
        }
        public string CalculateFormattedCircumference()
        {

            return FormatNumber(CalculateCircumference());
        }
        public double CalculateArea()
        {
            
            double area = PI * radius * radius;
            return area;
        }
        public string CalculateFormattedArea()
        {
            string formattedArea = FormatNumber(CalculateArea());
            return formattedArea;

        }
        private string FormatNumber(double x)
        {
            return $"{x,0:N2}";//$ signals incantination, then index of zero and going two decimal places
        }

    }

}
