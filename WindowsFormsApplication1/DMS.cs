/*  Форма "DMS".
 *  Название: DMS.cs.
 *  Язык: C#
 *  Краткое описание:
 *    Данная форма осуществляет просмотр базы данных EAS с возможностью редактирования
 *  Функции используемые в форме:
 *      FillCB() Заполняет все ComboBoxes;
 *      dbvl_Click заменяет старые данные строки БД на новые;
 *      Del_Click удаляет строку из БД;
 *      Bdob_Click Добавляет строку в БД
 *      ToUser меняет отображаемую и редактируемую таблицу
 *      menuClose завершает работу программы
 *      IpmListAud реализует импорт таблицы "Аудитории"
 *      IpmListGroups реализует импорт таблицы "Группы"
 *      ExpGroups реализует экспорт таблицы "Группы"
 *      ExpAuds реализует экспорт таблицы "Аудитории"
 *      ExpRasp реализует экспорт таблицы "Расписание"
 *      ExpAll реализует экспорт всех таблиц
 *      Dinamica поддерживает структуру приложения при изменении размера
 *      BOtch_Click создает отчет на основе таблицы "Расписание"
 *      Spravka предоставляет контакты разработчика
 */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public partial class DMS : Form
    {
        Sqlwork sw = new Sqlwork();
        ComboBox[] mCB;
        public DMS()
        {
            InitializeComponent();
            sw.FillDatabaseCB(ToUsers);
            ToUsers.SelectedItem = 1;
            sw.con(dgv1);
            mCB = new ComboBox[] { CBdob1, CBdob2, CBdob3, CBdob4, CBdob5, CBdob6, CBdob7, CBdob8, CBdob9, CBdob10, CBdob11, CBdob12 };
            FillCB();

        }
        //Функция FillCB() Заполняет все ComboBoxes
        private void FillCB()
        {
            int j = 0;
            for (j = 0; j < sw.Col; j++)
            {
                sw.FillCB(mCB[j], j);
                mCB[j].Visible = true;
            }
            for (j = j; j < 12; j++)
                mCB[j].Visible = false;
            sw.FillCB(CBdel);
        }
        /*Функция Bupd_Click заменяет старые данные строки БД на новые */
        private void Bupd_Click(object sender, EventArgs e)
        {
            Stack<string> st = new Stack<string>();
            for (int i = sw.Col - 1; i >= 1; i--)
                st.Push(mCB[i].Text);
            sw.upd(st, mCB[0].Text);
            sw.con(dgv1);
            FillCB();
        }
        // Функция Del_Click удаляет строку из БД
        private void Del_Click(object sender, EventArgs e)
        {
            sw.del(CBdel.Text);
            sw.con(dgv1);
            FillCB();
        }
        /*Функция Bdob_Click Добавляет строку в БД
         Локальные переменные:
         ыекштп
        sd -- Значения записываемой строки
       */
        private void Bdob_Click(object sender, EventArgs e)
        {
            string sd = "";
            Stack<string> st = new Stack<string>();
            for (int i = dgv1.RowCount - 1; i >= 0; i--)
                sd += dgv1.Rows[i].Cells[0].Value + " ";
            for (int i = sw.Col - 1; i >= 0; i--)
                st.Push(mCB[i].Text);
            sw.inc(st);

            sw.con(dgv1);
            FillCB();
        }
        /*Функция ToUser меняет отображаемую и редактируемую таблицу*/
        private void ToUser(object sender, EventArgs e)
        {
            sw.TableName = ToUsers.Text;
            sw.con(dgv1);
            FillCB();
        }
        //Функция menuClose завершает работу программы
        private void menuClose(object sender, EventArgs e)
        {
            this.Close();
        }
        //Функция IpmListAud реализует импорт таблицы "Аудитории"
        private void ImpListAud(object sender, EventArgs e)
        {
            sw.Import("Aud");
            sw.con(dgv1);
        }
        //Функция IpmListGroups реализует импорт таблицы "Группы"
        private void ImpListGroups(object sender, EventArgs e)
        {
            sw.Import("groups");
            sw.con(dgv1);
        }
        //Функция ExpGroups реализует экспорт таблицы "Группы"
        private void ExpGroups(object sender, EventArgs e)
        {
            sw.ExpTable("groups");
        }
        //Функция ExpAuds реализует экспорт таблицы "Аудитории"
        private void ExpAuds(object sender, EventArgs e)
        {
            sw.ExpTable("Aud");
        }
        //Функция ExpRasp реализует экспорт таблицы "Расписание"
        private void ExpRasp(object sender, EventArgs e)
        {
            sw.ExpTable("Расписание");
        }
        //Функция ExpAll реализует экспорт всех таблиц
        private void Expall(object sender, EventArgs e)
        {
            sw.ExpTable("Aud");
            sw.ExpTable("Расписание");
            sw.ExpTable("groups");
        }
        //Функция Dinamica поддерживает структуру приложения при изменении размера
        private void Dinamica(object sender, EventArgs e)
        {
            dgv1.Width = DMS.ActiveForm.Width;
            dgv1.Height = DMS.ActiveForm.Height - 240;
            box.Location = new Point(160, DMS.ActiveForm.Height - 210);
            ToUsers.Location = new Point(1250, DMS.ActiveForm.Height - 180);
        }
        //Функция BOtch_Click создает отчет на основе таблицы "Расписание"
        private void BOtch_Click(object sender, EventArgs e)
        {
            sw.con("Расписание", "*", "Группа ='" + Totch.Text + "'");
            sw.ToExel();
            sw.con(ToUsers.Text);
        }
        //Функция Spravka предоставляет контакты разработчика
        private void Spravka(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Маневский Роман Юрьевич\nКонтакт: Manevsky@roman.by");
        }
    }
}
