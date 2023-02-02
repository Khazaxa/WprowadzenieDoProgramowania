using System;
using System.Collections.Generic;

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
        int t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            List<IFigure> figures = new List<IFigure>();
            for (int j = 0; j < n; j++)
            {
                string[] line = Console.ReadLine().Split();
                char type = char.Parse(line[0]);
                switch (type)
                {
                    case 'p':
                        int x = int.Parse(line[1]);
                        int y = int.Parse(line[2]);
                        figures.Add(new Point(x, y));
                        break;
                    case 'c':
                        int centerX = int.Parse(line[1]);
                        int centerY = int.Parse(line[2]);
                        int radius = int.Parse(line[3]);
                        figures.Add(new Circle(new Point(centerX, centerY), radius));
                        break;
                    case 'l':
                        int startX = int.Parse(line[1]);
                        int startY = int.Parse(line[2]);
                        int endX = int.Parse(line[3]);
                        int endY = int.Parse(line[4]);
                        figures.Add(new Line(new Point(startX, startY), new Point(endX, endY)));
                        break;
                }
            }
            Rectangle mbr = MinimumBoundingRectangle(figures);
            Console.WriteLine(mbr.LowerLeft.X + " " + mbr.LowerLeft.Y + " " + mbr.UpperRight.X + " " + mbr.UpperRight.Y);
        }

    }
}
