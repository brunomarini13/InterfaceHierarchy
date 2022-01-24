using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call from object level.
            Rectangle myRectangle = new Rectangle();
            myRectangle.Draw();
            myRectangle.DrawInBoundingBox(10, 10, 100, 150);
            myRectangle.DrawUpsideDown();
            // Get IAdvancedDraw explicitly.
            IAdvancedDraw iAdvDraw = myRectangle as IAdvancedDraw;
            if (iAdvDraw != null)
                iAdvDraw.DrawUpsideDown();
            Console.ReadLine();
        }
    }
}
