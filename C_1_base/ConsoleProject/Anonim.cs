using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cons
{
    class Anonim
    {
        delegate void del();

        static void M()
        {
            del del = delegate ()
            {
                //здесь ваш метод
            };

            del = () => Console.WriteLine();

            D(del);

            D(() => Console.WriteLine());
        }

        static void D(del d)
        {
            var i = new { Name = "Игорь", Age = 1 };
            var ii = new { Name = "Игорь", Age = 1 };
            i = ii;

            void Dd()
            {

            }
        }


    }
}
