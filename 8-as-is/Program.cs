using System;

namespace _8_as_is
{

    class Point
    {
        public Point(int x, int y)
        {
            Console.WriteLine("Конструктор Point");
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public virtual void ShowCoord()
        {
            Console.WriteLine($"X: {X}, Y: {Y}");
        }

    }

    class Point3D : Point
    {
        public Point3D(int x, int y, int z) : base(x, y)
        {
            Console.WriteLine("Конструктор Point3D");
            Z = z;
        }

        public int Z { get; set; }

        public override void ShowCoord()
        {
            Console.WriteLine($"X: {X}, Y: {Y}, Z: {Z}");
        }
    }

    class C : Point3D
    {
        public C(int x, int y, int z): base(x,y,z)
        {
            Console.WriteLine("Консруктор C");
        }

        public override void ShowCoord()
        {
            Console.WriteLine($"X: {X}, Y: {Y}, Z: {Z} Class C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Object obj = new C(3, 4, 6);*/
            Object obj = new Point3D(3, 4, 6);
            /*Object obj = new Point(3, 4);*/
            /*Object obj = "Hello";*/
            Point point = obj as Point;

            if (point != null)
            {
                point.ShowCoord();
            }

            if (point is Point3D point3D)
            {
                point3D.ShowCoord();
            }
            
            if (point is C c)
            {
                c.ShowCoord();
            }
        }
    }
}
