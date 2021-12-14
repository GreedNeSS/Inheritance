using System;

namespace _6_operator_as_and_is
{
    class CircleFigure : Figure
    {
        public int Radius { get; set; }

        public new void Draw()
        {
            Console.WriteLine("Кто то, где то рисует круг");
        }
    }
}
