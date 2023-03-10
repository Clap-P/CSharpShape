



using CSharpShape.Models;
using System.Drawing;
using Rectangle = CSharpShape.Models.Rectangle;

class Program
{
    public static double TotalArea(object[] arrObjects)
    {

        double area = 0;
        Rectangle objRectangle;
        Circle objCircle;
        Triangle objTriangle;
        foreach (var obj in arrObjects)
        {
            if (obj is Rectangle)
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
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(10, 5);
        Circle Cir = new Circle(4);
        Triangle Tri = new Triangle(10, 5);

        object[] arrObjects = { rect, Cir, Tri };

        double totalArea = TotalArea(arrObjects);

        Console.WriteLine("La somme des aires est : " + totalArea);
    }
}