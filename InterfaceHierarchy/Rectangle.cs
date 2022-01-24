using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    class Rectangle : IAdvancedDraw
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle...");
        }

        public void DrawInBoundingBox(int top, int left, int bottom, int right)
        {
            Console.WriteLine("Drawing a rectangle inside a bounding box...");
        }

        public void DrawUpsideDown()
        {
            Console.WriteLine("Drawing a rectangle upside down...");
        }
    }
}
