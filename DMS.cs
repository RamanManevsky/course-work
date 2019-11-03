/*  Форма "Avto".
 *  Название: Avto.
 *  Язык: C#
 *  Краткое описание:
 *    Данная форма осуществляет просмотр таблицы с возможностью редактирования
 *  Функции используемые в форме:
 *      FillCB() Заполняет все ComboBoxes;
 *      dbvl_Click заменяет старые данные строки БД на новые;
 *      Del_Click удаляет строку из БД;
 *      Bdob_Click Добавляет строку в БД
 *      ToUsers_SelectedValueChanged меняет отображаемую и редактируемую таблицу
 */
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public partial class DMS : Form
    {
        Sqlwork sw = new Sqlwork();
        ComboBox[] mCB;
        public DMS()
        {
            InitializeComponent();
            if (Sqlwork.access_ret() == 1)
            {
                ToUsers.Visible = false;
                box.Visible = false;

            }
            else
                sw.FillDatabaseCB(ToUsers);
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
        /*Функция dbvl_Click заменяет старые данные строки БД на новые 
         Локальные переменные:
         data -- Новые значения строки из базы данных
        */
        private void Bupd_Click(object sender, EventArgs e)
        {
            Stack<string> st = new Stack<string>();
            for (int i = 1; i < sw.Col; i++)
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
        sd -- Значения записываемой строки
       */
        private void Bdob_Click(object sender, EventArgs e)
        {
            string sd = "";
            Stack<string> st = new Stack<string>();
            for (int i = 0; i < dgv1.RowCount; i++)
                sd += dgv1.Rows[i].Cells[0].Value + " ";
            if (sd.IndexOf(CBdob1.Text) == -1)
            {
                for (int i = 0; i < sw.Col; i++)
                    st.Push(mCB[i].Text);
                sw.inc(st);
            }
            else
            {
                MessageBox.Show("Первичный ключ уже существует, или не введен", "Ошибка добавления");
            }
            sw.con(dgv1);
            FillCB();
        }
        /*Функция ToUsers_SelectedValueChanged меняет отображаемую и редактируемую таблицу*/
        private void ToUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            sw.TableName = ToUsers.Text;
            sw.con(dgv1);
            FillCB();
        }

        private void EditConnStr_Click(object sender, EventArgs e)
        {
            sw.EditConnectionString(ServarName.Text, DataBaseName.Text);
            sw.FillDatabaseCB(ToUsers);
            sw.con(dgv1);
            FillCB();
        }
    }
}
