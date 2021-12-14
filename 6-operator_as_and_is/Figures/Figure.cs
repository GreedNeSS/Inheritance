using System;

namespace _6_operator_as_and_is
{
    abstract class Figure
    {
        public int Left { get; set; }
        public int Top { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Abstract class");
        }
    }
}
