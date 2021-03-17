using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cons
{
    class Program
    {
        static void Main()
        {
            string s = new String(new char[] { 'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd', });


            Console.WriteLine(); // \n

            Console.WriteLine(s); //Hello World\n

            Console.WriteLine(s + s);//Hello WorldHello World\n

            Console.WriteLine(s + 1 + s);//Hello World1Hello World\n

            Console.WriteLine("Hello World{0}Hello World{1}", 2, 3);//Hello World2Hello World\n

            Console.WriteLine($"Hello World{1 * 3}Hello World");//Hello World3Hello World\n

            FileStream file = new FileStream("", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            reader.Close();
            file.Close();

            try
            {
                int zero = 0;
                int i = 1;
                i = i / zero;
                throw new Exception("");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                ushort
            }
            catch
            {
                throw;
            }
            finally
            {

            }

            del d = new del(First);

            d += new del(Second);

            Console.WriteLine(d.Invoke());

            i = new del(First);

            i += d;

            i.Invoke();

            Console.ReadLine();
        }

        delegate int del();

        static event del i;

        event del ii
        {
            add
            {
                ii += value;
            }
            remove
            {
                ii -= value;
            }
        }

        static int First()
        {
            Console.WriteLine("first");
            return 1;
        }

        static int Second()
        {
            Console.WriteLine("second");
            return 2;
        }

    }
}