using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurProject._0
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();                                   // Включает визуальные стили для приложения
            Application.SetCompatibleTextRenderingDefault(false);               // Задает значения по умолчанию во всем приложении для свойства UseCompatibleTextRendering, определенного в конкретных элементах управления.
            Application.Run(new Helper());                                      // Запускает стандартный цикл обработки сообщений приложения в текущем потоке и делает указанную форму видимой.
        }
    }
}
