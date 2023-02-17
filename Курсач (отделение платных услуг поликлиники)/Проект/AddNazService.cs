using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Проект
{
    public partial class AddNazService : MetroFramework.Forms.MetroForm
    {
        public AddNazService()
        {
            InitializeComponent();
        }

        // Подключение
        SqlConnection SC;
        private void Add_Shown(object sender, EventArgs e)
        {
            ConnectionClass z = new ConnectionClass();
            SC = z.ConnectBD();
            SC.Open();
        }

        // Выбор диагноза
        int idVD;
        string TitleVD;
        private void Button3_Click(object sender, EventArgs e)
        {
            ChooseService f = new ChooseService();
            f.ShowDialog();
            idVD = ChooseService.id;
            TitleVD = ChooseService.Title;
            if (idVD > 0)
            {
                Button3.Text = "Изменить";
                TextBox1.Text = TitleVD;
            }
        }

        // Сохранить
        static public int idPos;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.TextLength > 0)
            {
                var sqlCmd = new SqlCommand("AddNazService", SC);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ID_Посещения", (idPos));
                sqlCmd.Parameters.AddWithValue("@ID_ВидаУслуги", (idVD));
                sqlCmd.ExecuteNonQuery();
                Close();
            }
            else
            {
                FormError f = new FormError();
                FormError.TextError = "Не выбран диагноз !";
                f.ShowDialog();
            }
        }

        // Отмена
        private void Button2_Click(object sender, EventArgs e)
        {
            ChooseService.id = 0;
            ChooseService.Title = "";
            Close();
        }
    }
}
