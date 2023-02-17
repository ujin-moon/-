using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZXC
{
    public partial class AddRasp : Form
    {
        private DataGridView Grid;
        private bool edit_mode;
        private object id;


        // Конструктор
        public AddRasp(ref DataGridView grid, bool edit_mode)
        {
            InitializeComponent();
            this.Grid = grid;
            this.edit_mode = edit_mode;
            ArrayList studs = new ArrayList();
            foreach (string[] item in DB.SELECT.Students())
                studs.Add(new { ID = item[0], Name = item[1] + " " + item[2] + " " + item[3] });
            comboBox1.DataSource = studs;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            ArrayList zays = new ArrayList();
            foreach (string[] item in DB.SELECT.Zay())
                zays.Add(new { ID = item[0], Name = "№" + item[8] + ", " + item[6] });
            comboBox2.DataSource = zays;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "ID";

            if (edit_mode)
            {
                this.Text = "Редактирование информации о распределении";
                button1.Text = "Применить";
                id = Grid.SelectedRows[0].Cells[0].Value;
                comboBox1.SelectedValue = Grid.SelectedRows[0].Cells[1].Value;
                comboBox2.SelectedValue = Grid.SelectedRows[0].Cells[3].Value;
                dateTimePicker1.Value = Convert.ToDateTime(Grid.SelectedRows[0].Cells[5].Value);
                textBox2.Text = Grid.SelectedRows[0].Cells[6].Value.ToString();
                dateTimePicker2.Value = Convert.ToDateTime(Grid.SelectedRows[0].Cells[7].Value);
                textBox3.Text = Grid.SelectedRows[0].Cells[8].Value.ToString();
            }
        }


        // Закрытие окна
        private void button2_Click(object sender, EventArgs e) => this.Close();


        // Добавить / применить изменения
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 2)
            {
                MessageBox.Show("Название места прибытия должно быть не короче 2 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox3.Text.Length < 2)
            {
                MessageBox.Show("Номер подтверждения должен быть не короче 2 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (edit_mode)
            {
                DB.UPDATE.Rasp(id, comboBox1.SelectedValue, comboBox2.SelectedValue, dateTimePicker1.Value, textBox2.Text, dateTimePicker2.Value, textBox3.Text);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Rasp())
                    Grid.Rows.Add(row);
                this.Close();
            }
            else
            {
                DB.INSERT.Rasp(comboBox1.SelectedValue, comboBox2.SelectedValue, dateTimePicker1.Value, textBox2.Text, dateTimePicker2.Value, textBox3.Text);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Rasp())
                    Grid.Rows.Add(row);
                this.Close();
            }
        }
    }
}
