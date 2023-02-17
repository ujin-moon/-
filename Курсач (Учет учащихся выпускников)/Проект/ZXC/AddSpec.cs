using System;
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
    public partial class AddSpec : Form
    {
        private DataGridView Grid;
        bool edit_mode;
        object spec_id;

        public AddSpec(ref DataGridView grid, bool edit_mode)
        {
            InitializeComponent();
            Grid = grid;
            this.edit_mode = edit_mode;

            if (edit_mode)
            {
                this.Text = "Редактирование записи о специальности";
                button1.Text = "Применить";
                this.textBox1.Text = Grid.SelectedRows[0].Cells[1].Value.ToString();
                spec_id = Grid.SelectedRows[0].Cells[0].Value;
            }

            this.ActiveControl = textBox1;
        }

        private void button2_Click(object sender, EventArgs e) => this.Close();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 2)
            {
                MessageBox.Show("Название специальности не может быть короче 2 символов", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            if (edit_mode)
            {
                DB.UPDATE.Spec(spec_id, textBox1.Text);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Speciality())
                    Grid.Rows.Add(row);
                this.Close();
            }
            else
            {
                DB.INSERT.Spec(textBox1.Text);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Speciality())
                    Grid.Rows.Add(row);
                this.Close();
            }
        }
    }
}
