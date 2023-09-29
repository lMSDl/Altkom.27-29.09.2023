
using Inheritance.Models;

Shape myShape = new Point();

Console.WriteLine(myShape.ToString());

Shape1D myShape1D = new Line(10);
Shape2D myShape2D = new Rectangle(5, 10);


Console.WriteLine(myShape1D.ToString());
Console.WriteLine(myShape2D.ToString());

//polimorfizm umożliwia nam przedstawienie jednego typu jako inny (z hierarchi dziedziczenia)
Shape[] shapes = new Shape[4];

shapes[0] = myShape;
shapes[1] = myShape1D;
shapes[2] = myShape2D;
shapes[3] = new Triangle(3, 6, 30);


foreach(Shape shape in shapes)
{
    Console.WriteLine(shape.ToString());
}

IColor[] colorableShape = new IColor[2];

colorableShape[0] = (Rectangle)myShape2D;
colorableShape[1] = (Line)myShape1D;
