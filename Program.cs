



using CSharpShape.Models;
using System.Drawing;
using Rectangle = CSharpShape.Models.Rectangle;

class Program
{
    public double TotalArea(object[] arrObjects)
    {

        double area = 0;
        Rectangle objRectangle;
        Circle objCircle;
        Triangle objTriangle;
        foreach (var obj in arrObjects)
        {
            if(obj is Rectangle)
            {
                objRectangle = (Rectangle)obj;
                area += objRectangle.Height * objRectangle.Width;
            }
            else if (obj is Circle)
            {
                objCircle = (Circle)obj;
                area += objCircle.Radius * objCircle.Radius * Math.PI;
            }
            else
            {
                objTriangle = (Triangle)obj;
                area += (objTriangle.Height * objTriangle.Width) / 2;
            }
        }
        return area;
    }
}