using System;

namespace HomeWork_3
{
    public enum ShapeType
    {
        rectangle = 0, circle = 1, triangle = 2
    }

    class ShapeFactorDyemo
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            ShapeFactory factory = new ShapeFactory();
            int sum = 0;
            Shape temp = null;
            for(int i = 0; i < 10; i++)
            {
                temp = factory.GetShape((ShapeType)rand.Next(0, 3));
                if (temp.IsLegal(temp))
                {
                    sum += temp.area;
                    Console.WriteLine(temp.GetType());
                }
                else
                {
                    Console.WriteLine("此次随机产生的图形不成立");
                }
            }
            Console.WriteLine("面积之和为：" + sum);
            Console.ReadKey();
        }
    }


    public class ShapeFactory
    {
        Random rand = new Random();
        public Shape GetShape(ShapeType type)
        {
            if (type == ShapeType.rectangle)
            {
                return new Rectangle(rand.Next(1, 10), rand.Next(1, 10));
            }else if(type == ShapeType.circle)
            {
                return new Circle(rand.Next(1, 10));
            }else if(type == ShapeType.triangle)
            {
                return new Triangle(rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10));
            }
            else { return null; }
        }
    }
    public abstract class Shape
    {
        protected int _area = 0;
        public int area
        {
            get => _area;
            set => _area = value;
        }
        public abstract bool IsLegal(Shape shape);
    }

    public class Rectangle : Shape
    {
        private int _length, _width = 0;//长方形的长与宽
        public int length { get => _length; set => _length = value; }
        public int width { get => _width; set => _length = value; }
        public Rectangle(int length, int width)
        {
            this._length = length;
            this._width = width;
            this.area = width * length;
        }
        public override bool IsLegal(Shape shape)
        {
            if (this._length <= 0 || this._width <= 0)
            {
                return false; 
            }
            else
            {
                return true;
            }
        }
    }

    public class Circle : Shape
    {
        private int _ras = 0;
        const int Pi = 3;
        public int ras { get => _ras; set => _ras = value; }

        public Circle(int ras)
        {
            this.ras = ras;
            this.area = ras * ras * Pi;

        }

        public override bool IsLegal(Shape shape)
        {
            if (this.ras <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public class Triangle : Shape
    {
        private int[] _edge = new int[3];
        public int this[int num]
        {
            get => _edge[num];
            set => _edge[num] = value;
        }

        public Triangle(int a, int b, int c)
        {
            int p = (a + b + c) / 2;
            this[0] = a;
            this[1] = b;
            this[2] = c;
            this.area = (int)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override bool IsLegal(Shape shape)
        {
            if (this[0] > this[1] + this[2] || this[1] > this[0] + this[2] || this[2] > this[1] + this[0])
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    
}

