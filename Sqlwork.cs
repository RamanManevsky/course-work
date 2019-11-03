/*  Вспомогательный модуль для обработки действий с базой данных.
 *  Название: Sqlwork.
 *  Язык: C#
 *  Краткое описание:   
 *      Данный модуль предназначен для работы с базой данных на MS SQL Server 2012 года.
 *      
 *  Глобальная переменная в модуле:
 *      Col -- количество обрабатываемых столбцов в базе данных;
 *      dt -- таблица из базы данных;
 *      TableName -- имя обрабатываемой таблицы;
 *      s -- Строка подключения.
 *  Функции используемые в форме:
 *      con -- осуществляет считавание таблицы и запись в DataGridView;
 *      S -- возвращает строку подключения s;
 *      FillCB -- заполняет ComboBox;
 *      del -- формирует запрос на удаление;
 *      upd -- формирует запрос на обновление;
 *      inc формирует запрос на добавление;
 *      del -- формирует запрос на удаление;
 *      SqlCom -- отправляет БД запрос
 *      login выполняет авторизацию пользователя
 */
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Collections.Generic;
namespace WindowsFormsApplication1
{
    class Sqlwork
    {
        private string serverName = "KOLOVRAT"; //Имя сервера

        private string dataBaseName = "KatTV"; //Имя редактируемоемой базы данных
        public void EditConnectionString(string server, string database)
        {
            serverName = server;
            dataBaseName = database;
                s = @"Data Source=" + serverName + ";Initial Catalog="+dataBaseName+"; Integrated Security=True"; 
        }
        SqlDataAdapter ad = new SqlDataAdapter();
        static private int access = 0;
        public int Col = 11;
        public DataTable dt;
        public string TableName = "TVkat"; //Имя редактируемоемой таблицы
        static public int access_ret()
        {
            return access;
        }
        string s = @"Data Source=KOLOVRAT; Initial Catalog=KatTV; Integrated Security=True";// Строка подключения
                                                             // Функция S возвращает строку подключения s
        public string ConnectionString()
        {
            return s;
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
            FillTable(TableName);
            if (dt.Columns.Count < 12)
                Col = dt.Columns.Count;
            else
                Col = 12;
            dgv.DataSource = dt;
        }
        /*Функция con осуществляет считавание таблицы
         Фактические параметры:
         Tname -- имя считываемой таблицы.
        */
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
        /*Функция FillCB заполняет ComboBox
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

        public void FillDatabaseCB(ComboBox cb)
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(s);
            con.Open();
            cb.Items.Clear();
            var table = con.GetSchema("Tables");
            foreach (DataRow row in table.Rows)
                cb.Items.Add(row["TABLE_NAME"]);
            TableName = cb.Items[0].ToString();
            con.Close();

        }
        /*Функция del формирует запрос на удаление из таблицы по умолчанию
         Фактические параметры:
         pk -- первичный ключ удаляемой строки.
        */
        public void del(string pk)
        {
            SqlCom("Delete From " + TableName + " where " + dt.Columns[0].ColumnName + " = '" + pk + "'"); //Создание запроса на удаление
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
            int i = 0;
            string data = " ";
            for (i = Col - 1; i > 1; i--)
                data += dt.Columns[i].ColumnName + "='" + st.Pop() + "', ";
            data += dt.Columns[i].ColumnName + "='" + st.Pop()+"'";
            SqlCom("update " + TableName + " set " + data + " where " + dt.Columns[0].ColumnName + " = '" + condition + "'"); //Создание запроса на обновление
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
                ColNames += dt.Columns[i].ColumnName + ",";
                data = ", '" + st.Pop() + "' " + data;
            }
            ColNames += dt.Columns[Col - 1].ColumnName;
            data = "'" + st.Pop() + "'" + data;
            SqlCom("insert into " + TableName + "(" + ColNames + ") values (" + data + ")");
        }

        /*Функция SqlCom отправляет БД запрос
        Фактические параметры:
        text_sql -- текст sql запроса.
        Локальные переменные:
        sql -- запрос к базе данных
        */
        private void SqlCom(string text_sql)
        {
            using (SqlConnection conn = new SqlConnection(s))
            {
                try
                {
                    conn.Open();
                    SqlCommand sql = new SqlCommand(text_sql, conn);// Создаем команду
                    sql.ExecuteNonQuery(); // Выполняем команду
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }
        /*Функция login выполняет авторизацию пользователя
        Фактические параметры:
        login -- введенный логин пользователя,
        pass -- введенный пароль;
        */
        public bool login(string login, string pass, string UsersDataBaseName="users")
        {
            // MessageBox.Show();
            try
            {
                FillTable(UsersDataBaseName, "*", " loginn = '" + login + "'");
                if (System.Convert.ToInt16(dt.Rows[0][3]) > 19)
                {
                    MessageBox.Show("Профиль заблокирован за певышение попыток входа, обратитесь к администратору");
                    return false;
                }
                if (dt.Rows[0][1].ToString() == pass)
                {
                    access = System.Convert.ToInt16(dt.Rows[0][2]);
                    return true;
                }
                else
                {
                    SqlCom("update"+UsersDataBaseName+"set countofwrongaut = " + (System.Convert.ToInt16(dt.Rows[0][3]) + 1) + " where loginn = " + login);
                    MessageBox.Show("Неверный логин или пароль");
                    return false;
                }
            }
            catch (System.IndexOutOfRangeException s)
            {
                MessageBox.Show("Такого пользователя не существует");
                return false;
            }
        }

        public string Protecting(string data)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            return System.BitConverter.ToString(md5.ComputeHash(Encoding.Unicode.GetBytes(data))).Replace("-", "");
        }
    }
}

