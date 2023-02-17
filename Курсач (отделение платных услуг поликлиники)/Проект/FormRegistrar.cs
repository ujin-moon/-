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
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();
        }

        // Скрыть/Раскрыть меню
        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (MenuPanel.Width == 248)
            {
                MenuPanel.Width = 55;
            }
            else
            {
                MenuPanel.Width = 248;
            }
        }

        // Переключение меню
        private void AbrirFormEnPanel(object Formhijo)
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

        // Пациенты
        private void MenuButton1_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = MenuButton1.Top;
            MenuButton1.BackColor = Color.FromArgb(0, 100, 182);
            MenuButton2.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton3.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton4.BackColor = Color.FromArgb(39, 57, 80);
            AbrirFormEnPanel(new ListPatient());
        }

        // Время приёма
        private void MenuButton2_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = MenuButton2.Top;
            MenuButton1.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton2.BackColor = Color.FromArgb(0, 100, 182);
            MenuButton3.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton4.BackColor = Color.FromArgb(39, 57, 80);
            AbrirFormEnPanel(new ListThePatientRecord1());
        }

        // Сотрудники
        private void MenuButton3_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = MenuButton3.Top;
            MenuButton1.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton2.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton3.BackColor = Color.FromArgb(0, 100, 182);
            MenuButton4.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton3.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton4.BackColor = Color.FromArgb(39, 57, 80);
            AbrirFormEnPanel(new ListEmployee());
        }

        // Виды графиков
        private void MenuButton4_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = MenuButton4.Top;
            MenuButton1.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton2.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton3.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton4.BackColor = Color.FromArgb(0, 100, 182);
            MenuButton3.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton4.BackColor = Color.FromArgb(39, 57, 80);
            AbrirFormEnPanel(new ListChartView());
        }

        // Запись пациентов
        private void MenuButton5_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = MenuButton3.Top;
            MenuButton1.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton2.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton3.BackColor = Color.FromArgb(0, 100, 182);
            MenuButton4.BackColor = Color.FromArgb(39, 57, 80);
            AbrirFormEnPanel(new ListThePatientRecord());
        }

        // Услуги
        private void MenuButton6_Click(object sender, EventArgs e)
        {
            ActivePanel.Top = MenuButton4.Top;
            MenuButton1.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton2.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton3.BackColor = Color.FromArgb(39, 57, 80);
            MenuButton4.BackColor = Color.FromArgb(0, 100, 182);
            AbrirFormEnPanel(new PrintServices());
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
            AbrirFormEnPanel(new ListThePatientRecord());
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
