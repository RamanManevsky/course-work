
/* Форма "Пользовательское формирование заявки".
*  Название: UserDMS.
*  Язык: C#
*  Краткое описание:
*      Данная форма позволяет рядовому пользователю формировать заявку на мультимедийную аудиторию
*      Функции:
*       bCL -- ввод данных для заявки на аудиторию;
*       InsZ -- формирование заявки на мультимедийную аудиторию.
*/
using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UserDMS : Form
    {
        private int i = 0;
        private string[] tables = { "Aud", "Groups", "", "Пары" };
        private string comm = "";
        private Sqlwork sw;
        public UserDMS()
        {
            InitializeComponent();
            dateTimePicker1.Visible = false;
            sw = new Sqlwork();
            sw.TableName = tables[i];
            sw.con(dgv);
            sw.FillCBEasy(CB);
        }
        //Функция bCL формирует заявку на аудиторию
        private void bCl(object sender, EventArgs e)
        {
            if (i == 2)
            {
                CB.Text = dateTimePicker1.Value.ToString("dd.MM.yyyy");
                dateTimePicker1.Visible = false;
                CB.Visible = true;
                dgv.Visible = true;
            }
            sw.con("Расписание");
            comm += "'" + CB.Text + "', ";

            i++;
            if (i == 4)
            {
                InsZ();
                this.Close();
                return;
            }
            if (i == 2)
            {
                dgv.Visible = false;
                CB.Visible = false;
                dateTimePicker1.Visible = true;
            }
            else
            {
                sw.TableName = tables[i];
                sw.con(dgv);
                sw.FillCBEasy(CB);
            }

        }
        // Функция InsZ формирует запрос на добавление заявки
        private void InsZ()
        {
            comm = "insert into Расписание values(" + (sw.dt.Rows.Count + 1).ToString() + "," + comm + "'')";
            Program.create = sw.SqlCom(comm);
        }
    }
}
