using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShape.Models
{
    public class Triangle
    {
        public Triangle(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }
        public double Height { get; set; }
        public double Width { get; set; }
    }
}
