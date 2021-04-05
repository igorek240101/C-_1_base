using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace C_5_base
{


    /*
     * Создайте графическое приложение организуещее базовый функционал проводника Windows
     * 1) Можно выбрать логический диск для которого просматривать содержимое
     * 2) Для выбранного диска необходимо вывести все содержимого корневого каталога
     * 3) При нажатии на каталог отображаются новые данные - содежимые этого каталога
     * 4) Должна существовать кнопка возвращения к родительскому каталогу
     * 5) При нахождении в родительском каталоге эта кнпока должна быть неактивна или скрыта
     * 6) При нажатии на файл, он должен открываться в ассоциированной программе
     * 
     * 
     * Подсказка!!!
     * Внимание!
     * Спойлеры!!!
     * Не читать, если не хотите испортить себе впечатления от кодинга!!!
    */
    #region Большой секрет!
    /*
     * Вам понадобится класс Directory из пространства имен System.IO и класс Process из пространства имен System.Diagnostics
    */
    #endregion
    /*
     * 
    */



    static class YourTaskHere
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
