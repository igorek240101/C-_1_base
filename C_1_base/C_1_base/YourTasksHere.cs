using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1_base
{
    public static class YourTasksHere
    {

        #region Задача 1
        /*
         * На вход подаются два катета прямоугольного тругольника требуется найти площадь этого тругольника
        */

        public static double SquerOfTrungle(uint a, uint b)
        {
            //throw new NotImplementedException();
            return (double)(a*b) / 2;
        }
        #endregion


        #region Задача 2
        /*
         * На вход подаются длины трех отрезков, верните true, если они могут образовать тругольник, в обратном случае верните false
         * 
         * Условие существования треугольника - a меньше или равно b + c, должно выполняться для любой a 
        */

        public static bool isTrungle(uint a, uint b, uint c)
        {
            //throw new NotImplementedException();
            return a <= (b + c) && b <= (a + c) && c <= (a + b) ;
        }
        #endregion


        #region Задача 3
        /*
         * На вход подается два числа, если числа имеют одинаковые знаки, необходимо вывести сумму, иначе разность, взятую по модулю
        */

        public static int Arifmetika(int a, int b)
        {
            //throw new NotImplementedException();
            return (a * b) > 0 ? a + b : Math.Abs(a - b);
        }
        #endregion


        #region Задача 4
        /*
         * На вход подается число, необходимо найти и вернуть факториал этого числа (гарантируется, что входное число больше или равно 1)
        */

        public static int Fuc(int a)
        {
            //throw new NotImplementedException();
            int answer = 1;
            for (int i = 0; i < a; i++)
                answer *= (i + 1);
            return answer;
        }
        #endregion


        #region Задача 5
        /*
         * На вход подается число n, необходимо создать массив длинной n и проинициализровать его значениями n, n-1 ... 1 (гарантируется, что n >= 1)
        */

        public static int[] ArrayCreate(int n)
        {
            //throw new NotImplementedException();
            int[] array = new int[n];
            int size = n;
            for (int i = 0; i < n; i++)
                array[i] = size--;
            return array;
        }
        #endregion


        #region Задача 6
        /*
         * На вход подается массив чисел, необходимо вернуть индекс первого вхождения наибольшего элемента массива
        */

        public static int MaxSearch(int[] array)
        {
            //throw new NotImplementedException();
            int max = array[0];
            for(int i = 0; i < array.Length; i++)
                if (array[i] > max)
                    max = array[i];
            for(int i = 0; i < array.Length; i++)
                if (array[i] == max)
                    return i;
            return - 1;
        }
        #endregion


        #region Задача 7
        /*
         * На вход подается массив чисел, необходимо вернуть его полную копию
        */

        public static int[] ArrayCopy(int[] array)
        {
            //throw new NotImplementedException();
            int[] arrayCopy = new int[array.Length];
            Array.Copy(array,0,arrayCopy,0,array.Length);
            return arrayCopy;
        }
        #endregion


        #region Задача 8
        /*
         * Реализуйте рекурсивную функцию нахождения чисел Фибоначи (a(n) = a(n-1) + a(n-2), где a(1) - 1, a(2) - 2)
        */
        // Не уверен что это правильная математическая реализация, по-моему 1 1 2 3 5...
        public static int Fibonachi(int n)
        {
            //throw new NotImplementedException();
            if (n == 1 || n == 2)
                return n == 1 ? 1 : 2;
            else
                return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        #endregion


        #region Задача 9
        /*SS
         * На вход подается массив, необходимо найти наибольшее значение в нем (рекомендуется использовать функцию из задания 6),
         * а так же вернуть полную копию входного массива с помощью модификатора out (рекомендуется использовать функцию из задания 7)
        */

        public static int HardArray(int[] input, out int[] output)
        {
            //throw new NotImplementedException();
            output = ArrayCopy(input);
            return input[MaxSearch(input)];
    }
        #endregion


        #region Задача 10
        /*
         * Вы создаете боевую систему для компьютерной игры
         * Вам необходимо написать метод, который расчитывает результаты боя
         * На каждом ходу игроки наносят урон противнику равный их силе
         * Бой заканчивается, когда у одного из игроков (или у обоих) здоровье опуститься до 0 или ниже
        */

        public static void Fight(ref int health1, int power1, ref int health2, int power2)
        {
            //throw new NotImplementedException();
            while (health1 > 0 && health2 > 0)
            {
                health2 -= power1;
                health1 -= power2;
            }
        }
        #endregion
    }
}
