using System;

namespace _5_abstract_class
{
    abstract class Figure
    {
        public int Left { get; set; }
        public int Top { get; set; }

        abstract public void Draw();
    }

    class RectangleFigure: Figure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Кто то, где то рисует прямоугольник.");
        }
    }

    class CircleFigure: Figure
    {
        public int Radius { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Кто то, где то рисует круг");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Figure figure = new Figure();  Этот код вызовет ошибку

            Figure rect = new RectangleFigure();
            rect.Draw();
            Figure circle = new CircleFigure();
            circle.Draw();

            /*
             * Если бы мы не использовали override то пришлось бы писать так
             * 
             * ((RectangleFigure)rect).Draw();
             * 
             * RectangleFigure rectFigure = rect as RectangleFigure;
             * 
             * ((RectangleFigure)circle).Draw();
             * 
             * CircleFigure circ = circle as CircleFigure;
             */
        }
    }
}
