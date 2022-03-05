using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory Creater = new ShapeFactory();
            //试试各种异常情况
            //输入参数个数不对
            try{ Shape s1 = Creater.CreateShape("Rectangle", 2);}
            catch(Exception e) { Console.WriteLine(e.Message); }
            //输入的形状类型不对
            try { Creater.CreateShape("S", 3); }
            catch(Exception e) { Console.WriteLine(e.Message); }
            //输入的参数有负数或零
            try { Creater.CreateShape("Square", -1); }
            catch (Exception e) { Console.WriteLine(e.Message); }
            //输入的边长不能组成三角形
            try { Creater.CreateShape("Triangle", 1, 2, 3); }
            catch (Exception e) { Console.WriteLine(e.Message); }
            //简单工厂创建10个对象
            Shape[] shapes = new Shape[10];
            shapes[0] = Creater.CreateShape("Rectangle", 2, 4);
            shapes[1] = Creater.CreateShape("Rectangle", 2, 2);
            shapes[2] = Creater.CreateShape("Rectangle", 1, 4);
            shapes[3] = Creater.CreateShape("Square", 2);
            shapes[4] = Creater.CreateShape("Square", 4);
            shapes[5] = Creater.CreateShape("Square", 1);
            shapes[6] = Creater.CreateShape("Triangle", 3, 4, 5);
            shapes[7] = Creater.CreateShape("Triangle", 2, 2, 2);
            shapes[8] = Creater.CreateShape("Triangle", 6, 8, 10);
            shapes[9] = Creater.CreateShape("Triangle", 4, 4, 4);
            //求和
            double sum = 0;
            for(int i=0;i<10;i++)
            {
                sum += shapes[i].GetArea();
            }
            Console.WriteLine($"The sum:{sum}");
        }
    }
    abstract public class Shape
    {
        abstract public bool IsLegal();
        abstract public double GetArea();
    }
    public class Rectangle:Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double newWidth,double newHeight)
        {
            Width = newWidth;
            Height = newHeight;
        }
        override public bool IsLegal()
        {
            if (Width > 0 && Height > 0) return true;
            return false;
        }
        override public double GetArea()
        {
            if (IsLegal()) return Width * Height;
            else throw new Exception("Illegal shape");
        }
    }
    public class Square:Shape
    {
        public double Side { get; set; }
        public Square(double newSide)
        {
            Side = newSide;
        }
        override public bool IsLegal()
        {
            if (Side > 0) return true;
            return false;
        }
        public override double GetArea()
        {
            if (IsLegal()) return Side * Side;
            throw new Exception("Illegal shape");
            
        }
    }
    public class Triangel:Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public Triangel(double newSide1,double newSide2, double newSide3)
        {
            Side1 = newSide1;
            Side2 = newSide2;
            Side3 = newSide3;
        }
        public override bool IsLegal()
        {
            if (Side1 > 0 && Side2 > 0 && Side3 > 0 && Side1+Side2>Side3 && Side1+Side3>Side2 && Side2+Side3>Side1) return true;
            return false;
        }
        public override double GetArea()
        {
            if (IsLegal())
            {
                double p = (Side1 + Side2 + Side3) / 2;
                return Math.Sqrt(p*(p-Side1)*(p-Side2)*(p-Side3));
            }
            else throw new Exception("Illegal shape");
        }
    }
    public class ShapeFactory
    {
        public Shape CreateShape(String shapeType,params double[] side)
        {
            Shape s;
            if (shapeType == "Rectangle")
            {
                if (side.Length != 2) throw new Exception("Illegal Number of Parameters");
                s = new Rectangle(side[0], side[1]);
            }
            else if (shapeType == "Square")
            {
                if (side.Length != 1) throw new Exception("Illegal Number of Parameters");
                s = new Square(side[0]);
            }
            else if (shapeType == "Triangle")
            {
                if (side.Length != 3) throw new Exception("Illegal Number of Parameters");
                s = new Triangel(side[0], side[1], side[2]);
            }
            else throw new Exception("Illegal shapeType");
            if (s.IsLegal()) return s;
            throw new Exception("Illegal shape! The sides can't become a shape");
        }
    }
}
