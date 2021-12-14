using System;

namespace _6_operator_as_and_is
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Figure rect = new RectangleFigure();

            if (rect is RectangleFigure)
            {
                Console.WriteLine("rect is RectangleFigure == true");
            }

            Figure circle = new CircleFigure();

            if (circle is CircleFigure)
            {
                Console.WriteLine("circle is CircleFigure == true");
            }

            Console.WriteLine("\nType Figure, rect.Drow()");
            rect.Draw();
            Console.WriteLine("Type Figure, circle.Drow()");
            circle.Draw();

            Console.WriteLine("\nПриведение типов ((RectangleFigure)rect).Draw()");
            ((RectangleFigure)rect).Draw();
            Console.WriteLine("Приведение типов ((CircleFigure)circle).Draw()");
            ((CircleFigure)circle).Draw();

            RectangleFigure rect1 = rect as RectangleFigure;
            CircleFigure circle1 = circle as CircleFigure;
            Console.WriteLine("\nПриведение типов " +
                "RectangleFigure rect1 = rect as RectangleFigure");
            rect1.Draw();
            Console.WriteLine("Приведение типов " +
                "CircleFigure circle1 = circle as CircleFigure");
            circle1.Draw();
        }
    }
}
