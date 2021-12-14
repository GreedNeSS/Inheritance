using System;

namespace _6_operator_as_and_is
{
    class RectangleFigure : Figure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public new void Draw()
        {
            Console.WriteLine("Кто то, где то рисует прямоугольник.");
        }
    }
}
