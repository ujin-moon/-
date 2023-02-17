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
    public partial class AddNazDiagnosis1 : MetroFramework.Forms.MetroForm
    {
        public AddNazDiagnosis1()
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
            ChooseDiagnosis f = new ChooseDiagnosis();
            f.ShowDialog();
            idVD = ChooseDiagnosis.id;
            TitleVD = ChooseDiagnosis.Title;
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
                var sqlCmd = new SqlCommand("AddNazDiagnosis", SC);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ID_Посещения", (idPos));
                sqlCmd.Parameters.AddWithValue("@ID_Диагноза", (idVD));
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
            ChooseDiagnosis.id = 0;
            ChooseDiagnosis.Title = "";
            Close();
        }
    }
}
