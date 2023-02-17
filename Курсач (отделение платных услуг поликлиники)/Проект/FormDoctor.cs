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
    public partial class FormDoctor : Form
    {
        public FormDoctor()
        {
            InitializeComponent();
        }

        // Скрыть/Раскрыть меню
        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (MenuPanel.Width == 248)
            {
                MenuButton5.Text = "";
                MenuPanel.Width = 55;
            }
            else
            {
                MenuButton5.Text = "Записанные пациенты";
                MenuPanel.Width = 248;
            }
        }

        // Переключение меню
        public void AbrirFormEnPanel(object Formhijo)
        {
            if (this.FullPanel.Controls.Count > 0)
                this.FullPanel.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.FullPanel.Controls.Add(fh);
            this.FullPanel.Tag = fh;
            fh.Show();
        }

        // Категория диагноза
        private void MenuButton1_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = MenuButton1.Top;
            MenuButton1.BackColor = Color.FromArgb(0, 100, 182);
            MenuButton2.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton3.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton4.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton5.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton6.BackColor = Color.FromArgb(39, 57, 80);
            AbrirFormEnPanel(new ListCategoryDiagnos());
        }

        // Диагнозы
        private void MenuButton2_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = MenuButton2.Top;
            MenuButton1.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton2.BackColor = Color.FromArgb(0, 100, 182);
            MenuButton3.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton4.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton5.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton6.BackColor = Color.FromArgb(39, 57, 80);
            AbrirFormEnPanel(new ListDiagnosis());
        }

        // Категории лекарств
        private void MenuButton3_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = MenuButton3.Top;
            MenuButton1.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton2.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton3.BackColor = Color.FromArgb(0, 100, 182);
            MenuButton4.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton5.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton6.BackColor = Color.FromArgb(39, 57, 80);
            AbrirFormEnPanel(new ListCategoryMedicine());
        }

        // Лекарства
        private void MenuButton4_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = MenuButton4.Top;
            MenuButton1.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton2.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton3.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton4.BackColor = Color.FromArgb(0, 100, 182);
            MenuButton5.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton6.BackColor = Color.FromArgb(39, 57, 80);
            AbrirFormEnPanel(new ListMedicine());
        }

        // Постановка диагноза, назначение лекарств и услуг
        private void MenuButton5_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = MenuButton5.Top;
            MenuButton1.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton2.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton3.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton4.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton5.BackColor = Color.FromArgb(0, 100, 182);
            MenuButton6.BackColor = Color.FromArgb(39, 57, 80);
            AbrirFormEnPanel(new ListPostanDiagnosis());
        }

        // Пациенты
        private void MenuButton6_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = MenuButton6.Top;
            MenuButton1.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton2.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton3.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton4.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton5.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton6.BackColor = Color.FromArgb(0, 100, 182);
            AbrirFormEnPanel(new PrintPatient());
        }

        // Дата и время
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss ");
            DateLabel.Text = DateTime.Now.ToLongDateString();
        }

        // Подключение
        SqlConnection SC;
        private void FormAdministrator_Shown(object sender, EventArgs e)
        {
            ConnectionClass z = new ConnectionClass();
            SC = z.ConnectBD();
            SC.Open();
            this.Opacity = 0.97;
            AbrirFormEnPanel(new ListPostanDiagnosis());
        }

        // Кнопка выхода из приложения
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Кнопка уменьшить окно
        private void r1Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            r1Button.Visible = false;
            r2Button.Visible = true;
        }

        // Кнопка развернуть на весь экран
        private void r2Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            r1Button.Visible = true;
            r2Button.Visible = false;
        }

        // Кнопка скрыть
        private void HideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Прозрачность
        private void ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleSwitch1.Checked == true) this.Opacity = 0.97;
            else if (ToggleSwitch1.Checked == false) this.Opacity = 1;
        }

        // Выход
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SC.Close();
            Hide();
            FormAuthorization f = new FormAuthorization();
            f.ShowDialog();
            Close();
        }
    }
}
