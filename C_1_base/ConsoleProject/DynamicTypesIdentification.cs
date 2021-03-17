using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_2_base;

namespace ConsoleProject
{
    class DynamicTypesIdentification
    {
        static void M()
        {
            Figure[] figs = new Figure[3];

            figs[0] = new Rectangle(1,1);
            figs[1] = new Circle(1);
            figs[2] = new Triangle(3,4,5, 4);

            Rectangle rectangle;
            if(figs[0] is Rectangle)
            {
                rectangle = figs[0] as Rectangle;
            }

            if(figs[0].GetType() == typeof(Rectangle))
            {

            }
        }
    }
}
