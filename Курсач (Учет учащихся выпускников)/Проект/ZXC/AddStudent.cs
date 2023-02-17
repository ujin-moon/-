using System;
using System.Collections;
using System.Windows.Forms;

namespace ZXC
{
    public partial class AddStudent : Form
    {
        private DataGridView Grid;
        private bool edit_mode;
        private int student_id;


        public AddStudent(ref DataGridView grid, bool edit_mode)
        {
            InitializeComponent();
            this.Grid = grid;
            this.edit_mode = edit_mode;

            ArrayList arr1 = new ArrayList();
            ArrayList arr2 = new ArrayList();
            ArrayList arr3 = new ArrayList();
            foreach (string[] item in DB.SELECT.Years())
                arr1.Add(new { Name = item[1], ID = item[0] });
            foreach (string[] item in DB.SELECT.Speciality())
                arr2.Add(new { Name = item[1], ID = item[0] });
            foreach (string[] item in DB.SELECT.Sredstva())
                arr3.Add(new { Name = item[1], ID = item[0] });
            comboBox1.DataSource = arr1;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox2.DataSource = arr2;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "ID";
            comboBox3.DataSource = arr3;
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "ID";

            if (edit_mode)
            {
                this.Text = "Редактирование записи о выпускнике";
                textBox1.Text = Grid.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = Grid.SelectedRows[0].Cells[2].Value.ToString();
                textBox3.Text = Grid.SelectedRows[0].Cells[3].Value.ToString();
                student_id = Convert.ToInt32(grid.SelectedRows[0].Cells[0].Value);
                comboBox1.SelectedValue = Grid.SelectedRows[0].Cells[8].Value;
                comboBox2.SelectedValue = Grid.SelectedRows[0].Cells[4].Value;
                comboBox3.SelectedValue = Grid.SelectedRows[0].Cells[6].Value;
                button1.Text = "Применить";
            }

            this.ActiveControl = textBox1;
        }


        private void button2_Click(object sender, EventArgs e) => this.Close();


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 2)
            {
                MessageBox.Show("Имя не может быть короче 2 символов", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            else if (textBox2.Text.Length < 2)
            {
                MessageBox.Show("Фамилия не может быть короче 2 символа", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            else if (textBox3.Text.Length < 2)
            {
                MessageBox.Show("Отчество не может быть короче 2 символов", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            if (edit_mode)
            {
                DB.UPDATE.Student(student_id, textBox2.Text, textBox1.Text, textBox3.Text, comboBox2.SelectedValue, comboBox3.SelectedValue, comboBox1.SelectedValue);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Students())
                    Grid.Rows.Add(row);
                this.Close();
            }
            else
            {
                DB.INSERT.Student(textBox2.Text, textBox1.Text, textBox3.Text, comboBox2.SelectedValue, comboBox3.SelectedValue, comboBox1.SelectedValue);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Students())
                    Grid.Rows.Add(row);
                this.Close();
            }
        }
    }
}
