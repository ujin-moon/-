using System;
using System.Windows.Forms;

namespace ZXC
{
    public partial class AddYear : Form
    {
        private DataGridView Grid;
        private bool edit_mode;
        private object year_id;

        public AddYear(ref DataGridView grid, bool edit_mode)
        {
            InitializeComponent();
            this.Grid = grid;
            this.edit_mode = edit_mode;
            
            if (edit_mode)
            {
                textBox1.Text = Grid.SelectedRows[0].Cells[1].Value.ToString();
                this.Text = "Редактирование года выпуска";
                this.button1.Text = "Применить";
                year_id = Grid.SelectedRows[0].Cells[0].Value;
            }

            this.ActiveControl = textBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 4)
            {
                MessageBox.Show("Номер года выпуска должен состоять из 4 цифр", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            if (edit_mode)
            {
                DB.UPDATE.Year(year_id, textBox1.Text);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Years())
                    Grid.Rows.Add(row);
                this.Close();
            }
            else
            {
                DB.INSERT.Year(textBox1.Text);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Years())
                    Grid.Rows.Add(row);
                this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) < 48 || Convert.ToInt32(e.KeyChar) > 57)
                if (Convert.ToInt32(e.KeyChar) != 8)
                    e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
