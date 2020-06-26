
using System;


/* Форма "Авторизация".
*  Название: autorisation.
*  Язык: C#
*  Краткое описание:
*      Данная форма позволяет пользователю войти в субд MS SQL server
*  Функц      auth() – попытка авторизации;
*/
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public partial class Autorisation : Form
    {
        public Autorisation()
        {
            InitializeComponent();
        }
        protected int i = 0;
        private void auth(object sender, EventArgs e)
        {
            Sqlwork sqlw = new Sqlwork();
            Sqlwork.EdConStr(ServarName.Text, "EAS", Tlogin.Text, TPasswd.Text);
            if (sqlw.TryCon() == true)
                this.Close();
            else
                MessageBox.Show("Неверный сервер, логин или пароль");
        }
    }
}
