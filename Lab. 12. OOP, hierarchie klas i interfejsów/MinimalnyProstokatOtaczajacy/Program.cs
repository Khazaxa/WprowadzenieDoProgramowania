using System;
using System.Collections.Generic;
using System.Linq.Expressions;

interface IFigure
{
    Rectangle GetBoundingRectangle();
}

class Point : IFigure
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Rectangle GetBoundingRectangle()
    {
        return new Rectangle(new Point(X, Y), new Point(X, Y));
    }
}

class Circle : IFigure
{
    public Point Center { get; set; }
    public int Radius { get; set; }

    public Circle(Point center, int radius)
    {
        Center = center;
        Radius = radius;
    }

    public Rectangle GetBoundingRectangle()
    {
        int left = Center.X - Radius;
        int right = Center.X + Radius;
        int bottom = Center.Y - Radius;
        int top = Center.Y + Radius;
        return new Rectangle(new Point(left, bottom), new Point(right, top));
    }
}

class Line : IFigure
{
    public Point Start { get; set; }
    public Point End { get; set; }

    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    public Rectangle GetBoundingRectangle()
    {
        int left = Math.Min(Start.X, End.X);
        int right = Math.Max(Start.X, End.X);
        int bottom = Math.Min(Start.Y, End.Y);
        int top = Math.Max(Start.Y, End.Y);
        return new Rectangle(new Point(left, bottom), new Point(right, top));
    }
}

class Rectangle : IFigure
{
    public Point LowerLeft { get; set; }
    public Point UpperRight { get; set; }

    public Rectangle(Point lowerLeft, Point upperRight)
    {
        LowerLeft = lowerLeft;
        UpperRight = upperRight;
    }

    public Rectangle GetBoundingRectangle()
    {
        return this;
    }
}

class Program
{
    static Rectangle MinimumBoundingRectangle(IList<IFigure> figures)
    {
        int left = int.MaxValue;
        int right = int.MinValue;
        int bottom = int.MaxValue;
        int top = int.MinValue;
        foreach (var figure in figures)
        {
            Rectangle rectangle = figure.GetBoundingRectangle();
            left = Math.Min(left, rectangle.LowerLeft.X);
            right = Math.Max(right, rectangle.UpperRight.X);
            bottom = Math.Min(bottom, rectangle.LowerLeft.Y);
            top = Math.Max(top, rectangle.UpperRight.Y);
        }
        return new Rectangle(new Point(left, bottom), new Point(right, top));
    }

    static void Main(string[] args)
    {
        try
        {

            int? t = int.Parse(Console.ReadLine());
            
            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int xMin = int.MaxValue;
                int yMin = int.MaxValue;
                int xMax = int.MinValue;
                int yMax = int.MinValue;

                for (int i = 0; i < n; i++)
                {
                    string[] input = Console.ReadLine().Split();
                    char type = char.Parse(input[0]);
                    int x = int.Parse(input[1]);
                    int y = int.Parse(input[2]);

                    if (type == 'p')
                    {
                        xMin = Math.Min(xMin, x);
                        yMin = Math.Min(yMin, y);
                        xMax = Math.Max(xMax, x);
                        yMax = Math.Max(yMax, y);
                    }
                    else if (type == 'c')
                    {
                        int r = int.Parse(input[3]);
                        xMin = Math.Min(xMin, x - r);
                        yMin = Math.Min(yMin, y - r);
                        xMax = Math.Max(xMax, x + r);
                        yMax = Math.Max(yMax, y + r);
                    }
                    else if (type == 'l')
                    {
                        int x2 = int.Parse(input[3]);
                        int y2 = int.Parse(input[4]);
                        xMin = Math.Min(xMin, Math.Min(x, x2));
                        yMin = Math.Min(yMin, Math.Min(y, y2));
                        xMax = Math.Max(xMax, Math.Max(x, x2));
                        yMax = Math.Max(yMax, Math.Max(y, y2));
                    }
                }

                Console.WriteLine("{0} {1} {2} {3}", xMin, yMin, xMax, yMax);
            }
             
        }
        catch
        {
            Console.WriteLine("Value cannot be null.");
        }
        


    }
}
