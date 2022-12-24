using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
  public abstract class Figure
  {    
    public abstract double GetPerimetr();
    public abstract double GetSquare();

  }

  public class Triangle : Figure
  {
    public double a, b, c, h;    

    public Triangle(double a, double b, double c, double h)
    {
      this.a = a;
      this.b = b;
      this.c = c;
      this.h = h;
    }
    public override double GetPerimetr()
    {
      return a + b + c;
    }

    public override double GetSquare()
    {
      return (a * h) / 2;
    }
  }

  public class Rectangle : Figure
  {   
    public double a, b;
    public Rectangle(double a, double b)
    {
      this.a = a;
      this.b = b;
    }

    public override double GetPerimetr()
    {
      return 2 * (a + b);
    }

    public override double GetSquare()
    {
      return a * b;
    }
  }

  public class Circle : Figure
  {
    public double a;
    public Circle(double a)
    {
      this.a = a;
    }
    public override double GetPerimetr()
    {
      return 2 * this.a * Math.PI;
    }

    public override double GetSquare()
    {
      return Math.PI * Math.Pow(a, 2);
    }
  }
}
