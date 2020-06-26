/*  Вспомогательный модуль для обработки действий с базой данных.
 *  Название: Sqlwork.
 *  Язык: C#
 *  Краткое описание:   
 *      Данный модуль предназначен для работы с базой данных на MS SQL Server 2012 года.
 *      
 *  Глобальные переменная в модуле:
 *      ad -- средство заполнения таблицы
 *      Col -- количество обрабатываемых столбцов в базе данных;
 *      dt -- таблица из базы данных;
 *      username -- имя пользователя, который работает 
 *      TableName -- имя обрабатываемой таблицы;
 *      s -- Строка подключения.
 *  Функции используемые в форме:
 *      EdConStr -- редатирует строку подключения к ms sql server
 *      con -- осуществляет считавание таблицы и запись в DataGridView;
 *      S -- возвращает строку подключения s;
 *      FillCB -- заполняет ComboBox;
 *      del -- формирует запрос на удаление;
 *      upd -- формирует запрос на обновление;
 *      inc формирует запрос на добавление;
 *      del -- формирует запрос на удаление;
 *      SqlCom -- отправляет БД запрос
 *      TryCon() -- проверка соединение с сервером.
 *      
 */
 
 using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using System;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication1
{
    class Sqlwork
    {
        
        private string serverName = "CLASS3-312\\SQLEXPRESS"; //Имя сервера
        static private string username = "";
        private string dataBaseName = "aud"; //Имя редактируемоемой базы данных

        public static void EdConStr(string serv, string db, string user = "admin", string pas = "admin")
        {

            s = @"Data Source=" + serv + ";Initial Catalog=" + db + "; Integrated Security=true;" + "user id = " + user + "; password = " + pas;
            username = user;
        }
        SqlDataAdapter ad = new SqlDataAdapter();
        static private int access = 2;
        public int Col = 11;
        public DataTable dt;
        public string TableName = "Aud"; //Имя редактируемоемой таблицы
        static public int access_ret()
        {
            return access;
        }
        static string s = @"";// Строка подключения
                              // Функция ConStr возвращает строку подключения s
                              /*Функция TryCon() проверяет соединение с сервером.
                                                    */

        public string ConStr()
        {
            
            return s;
        }
        //Функция TryCon проверяет наличие соединения с сервером, а так же корректрность логина и пароля
        public bool TryCon()
        {
            using (SqlConnection conn = new SqlConnection(s))
            {
                if (username == "admin")
                    access = 1;
                else access = 0;
                try
                {

                    conn.Open();
                    conn.Close();
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        /*Функция con осуществляет считавание таблицы и запись в DataGridView
         Фактические параметры:
         dgv -- DataGridView, в который записываются данные;
         data -- Имена столбцов для показа.
         Локальные переменные:
        data -- Новые значения строки из базы данных.
        */
        public void con(DataGridView dgv, string data = "*")
        {
            FillTable(TableName, data);
            Col = dt.Columns.Count;
            dgv.DataSource = dt;
        }
        /*Функция con осуществляет считавание таблицы
         Фактические параметры:
         Tname -- имя считываемой таблицы.
        */
        public void con(string tableName = "*", string data = "*", string where = "")
        {
            FillTable(tableName, data, where);
            Col = dt.Columns.Count;
        }
        private void FillTable(string TName, string data = "*", string wh = "")
        {
            using (SqlConnection conn = new SqlConnection(s))
            {
                if (wh != "")
                    wh = " where " + wh;
                try
                {
                    conn.Open();
                    ad = new SqlDataAdapter("select " + data + " from " + TName + wh, conn);
                    dt = new DataTable(TName);
                    ad.Fill(dt);
                }
                catch (SqlException Ex)
                {
                    MessageBox.Show(Ex.Message, "Ошибка соединения");
                }
            }
        }
        /*Функция FillCB заполняет ComboBox с привязкой к datagreedview
         Фактические параметры:
         CB -- заполняемый ComboBox;
        */
        public void FillCBEasy(ComboBox CB)
        {
            CB.DataSource = dt;
            CB.DisplayMember = dt.Columns[0].ColumnName;
        }
        /*Функция FillCB заполняет ComboBox без привязки к datagreedview
         Фактические параметры:
         CB -- заполняемый ComboBox;
         j -- столбец значений из таблицы.
        */
        public void FillCB(ComboBox CB, int j = 0)
        {
            CB.Items.Clear();
            string s, s1 = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                s = dt.Rows[i][j].ToString();
                if (s1.IndexOf(s) == -1)
                {
                    CB.Items.Add(s);
                    s1 += s;
                }
            }
        }
        //Функция FillDatabaseCB заполняет ComboBox именами таблиц базы данных
        public void FillDatabaseCB(ComboBox cb)
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(s);
            con.Open();
            cb.Items.Clear();
            var table = con.GetSchema("Tables");
            foreach (DataRow row in table.Rows)
                cb.Items.Add(row["TABLE_NAME"]);
            if (cb.Items.Count != 0)
            {
                TableName = cb.Items[0].ToString();
                access = 2;
            }
            else access = 1;
            con.Close();
        }
        /*Функция del формирует запрос на удаление из таблицы по умолчанию
         Фактические параметры:
         pk -- первичный ключ удаляемой строки.
        */
        public void del(string pk)
        {
            SqlCom("Delete From " + TableName + " where [" + dt.Columns[0].ColumnName + "] = '" + pk + "'"); //Создание запроса на удаление
        }
        /*Функция del формирует запрос на удаление из определенной таблицы
         Фактические параметры:
         pk -- первичный ключ удаляемой строки,
         Tname -- имя таблицы.
        */
        public void del(string pk, string Tname)
        {
            SqlCom("Delete From " + Tname + " where " + dt.Columns[0].ColumnName + " = '" + pk + "'"); //Создание запроса на удаление
        }
        /*Функция upd формирует запрос на обновление
        Фактические параметры:
        data -- значения столбцов;
        condition -- значение первичного ключа в изменяемой строке.
        */
        public void upd(Stack<string> st, string condition = "")
        {
            if (access == 1)
                SqlCom("exec update_rasp " + condition + "," + st.Pop() + ",'" + st.Pop() + "'," + st.Pop() + ",'" + st.Pop() + "'");
            else
            {
                int i = 0;
                string data = " ";
                for (i = 1; i < Col - 1; i++)
                    data += "["+dt.Columns[i].ColumnName + "]='" + st.Pop() + "', ";
                data +="["+ dt.Columns[i].ColumnName + "]='" + st.Pop() + "'";
                SqlCom("update " + TableName + " set " + data + " where " + dt.Columns[0].ColumnName + " = '" + condition + "'"); //Создание запроса на обновление
            }
        }
        /*Функция inc формирует запрос на добавление
        Фактические параметры:
        data -- значения столбцов.
        Локальные переменные:
        ColNames -- список имен столбцов.
        */
        public void inc(Stack<string> st)
        {

            string ColNames = "", data = "";
            for (int i = 0; i < Col - 1; i++)
            {
                ColNames +="[" +dt.Columns[Col - 1 - i].ColumnName + "],";
                data = ", '" + st.Pop() + "' " + data;
            }
            ColNames +="[" +dt.Columns[0].ColumnName+"]";
            data = "'" + st.Pop() + "'" + data;
            SqlCom("insert into " + TableName + "(" + ColNames + ") values (" + data + ")");
        }
        /*Функция SqlCom отправляет БД запрос
        Фактические параметры:
        text_sql -- текст sql запроса.
        Локальные переменные:
        sql -- запрос к базе данных
        */
        public bool SqlCom(string text_sql)
        {
            using (SqlConnection conn = new SqlConnection(s))
            {
                try
                {
                    conn.Open();
                    SqlCommand sql = new SqlCommand(text_sql, conn);// Создаем команду
                    sql.ExecuteNonQuery(); // Выполняем команду
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        //Функция usRet возвращает введенный логин пользователя
        public string usRet()
        {
            return username;
        }
        //функция Import импортирует в Exel указанную таблицу
        //Формальные параметры:
        //tableName -- имя таблицы
        public void Import(string tableName)
        {
            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.InitialDirectory = "C:\\";
            ofd.Multiselect = false;
            ofd.Title = "Выделите файл для импорта данных";
            ofd.ValidateNames = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            else
            {
                MessageBox.Show("Некорректный путь");
                return;
            }
            SqlCom("exec upd" + tableName + " '" + filePath + "'");
        }
        //функция  импортирует в Exel указанную таблицу
        //Формальные параметры:
        //tableName -- имя таблицы
        public void ExpTable(string tableName)
        {
            con(tableName);
            ToExel();
        }
        //Функция ToExel формирует .xlsx файл с данными из переменной dt
        public void ToExel()
        {
            Excel.Worksheet xlSheet;
            Range xlSheetRange;

            Excel.Application xlApp = new Excel.Application();
            try
            {
                //добавляем книгу

                Workbook workbook = xlApp.Workbooks.Add(1);
                Worksheet worksheet = (Worksheet)workbook.Sheets[1];

                //делаем временно неактивным документ
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;

                //выбираем лист на котором будем работать (Лист 1)
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                //Название листа
                xlSheet.Name = "Данные";


                int collInd = 0;
                int rowInd = 0;
                string data = "";


                //называем колонки
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[1, i + 1] = data;

                    //выделяем первую строку
                    xlSheetRange = xlSheet.get_Range("A1:Z1", Type.Missing);

                    //делаем полужирный текст и перенос слов
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                //заполняем строки
                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }

                //выбираем всю область данных
                xlSheetRange = xlSheet.UsedRange;

                //выравниваем строки и колонки по их содержимому
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Показываем ексель
                xlApp.Visible = true;

                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;

                //Отсоединяемся от Excel
                releaseObject(xlApp);
            }
        }
        //Функция realiseObject освобождает память 
        //Формальные параметры: 
        //obj -- имя объекта
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
