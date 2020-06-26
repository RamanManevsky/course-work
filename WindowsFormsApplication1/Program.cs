/* Выпускная квалификационная дипломныя работа.
 *  Название: .
 *  Разработал: Маневский Роман Юрьевич, группа ТМП-81.
 *  Дата и номер версии: 17.06.2020 v4.0.
 *  Язык: C#.
 *  Краткое описание:   
 *      Данная программа является системой бронирования мультимедийных аудиторий.
 *  Задание:	
 *      Создать базу данных «Бронирование аудиторий» и разработать СУБД на языке программирования C# для управления созданной БД в Microsoft SQL Server.  
 *  Формы, используемая в программе:
.*Autorisation – авторизация пользователя;
 * DMS - основная форма программы;
 * UserDMS - форма для создания заявки обычным пользователем.
 */

using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static  class Program
    {
        static public bool create = false;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static int Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Autorisation());
            if (Sqlwork.access_ret() == 2) return 0;
            if (Sqlwork.access_ret() == 0)
            {
                Application.Run(new UserDMS());
                if (create == true)MessageBox.Show("Бронирование аудитории успешно выполнено");
            }
            else
                Application.Run(new DMS());
            return 0;
        }
    }
}
