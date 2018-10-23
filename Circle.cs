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
        public double Radius//property, not included in default constructor because we dont know the values yet
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
            this.radius = radius;//initializing the variable inside constructor
        }
        public double CalculateCircumference()
        {
            double circumference = PI * (2 * radius);
            return circumference;
            //allow for user input on number of decimal places
        }
        public string CalculateFormattedCircumference()
        {

            return FormatNumber(CalculateCircumference());//formats output to hundreths decimal place
        }
        public double CalculateArea()
        {
            
            double area = PI * radius * radius;
            return area;
        }
        public string CalculateFormattedArea()
        {
            string formattedArea = FormatNumber(CalculateArea());//formats are to hundreths place
            return formattedArea;

        }
        private string FormatNumber(double x)
        {
            return $"{x,0:N2}";//$ signals incantination, then index of zero and going two decimal places
        }

    }

}
