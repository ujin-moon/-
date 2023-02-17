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
    public partial class AddNazMedicines : MetroFramework.Forms.MetroForm
    {
        public AddNazMedicines()
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

        // Выбор лекарства
        int idVD;
        string TitleVD;
        private void Button3_Click(object sender, EventArgs e)
        {
            ChoiceMedicine f = new ChoiceMedicine();
            f.ShowDialog();
            idVD = ChoiceMedicine.id;
            TitleVD = ChoiceMedicine.Title;
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
            if (TextBox1.TextLength > 0 && TextBox2.TextLength > 0)
            {
                var sqlCmd = new SqlCommand("AddAppointment", SC);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ID_Посещения", (idPos));
                sqlCmd.Parameters.AddWithValue("@ID_Лекарства", (idVD));
                sqlCmd.Parameters.AddWithValue("@Дозировка", (TextBox2.Text));
                sqlCmd.ExecuteNonQuery();
                Close();
            }
            else
            {
                FormError f = new FormError();
                FormError.TextError = "Не все поля заполнены !";
                f.ShowDialog();
            }
        }

        // Отмена
        private void Button2_Click(object sender, EventArgs e)
        {
            ChoiceMedicine.id = 0;
            ChoiceMedicine.Title = "";
            Close();
        }
    }
}
