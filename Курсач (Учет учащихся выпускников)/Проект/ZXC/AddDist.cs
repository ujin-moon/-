using System;
using System.Windows.Forms;

namespace ZXC
{
    public partial class AddDist : Form
    {
        private DataGridView Grid;
        private bool edit_mode;
        private object dist_id;
        

        public AddDist(ref DataGridView grid, bool edit_mode)
        {
            InitializeComponent();
            Grid = grid;
            this.edit_mode = edit_mode;

            if (edit_mode)
            {
                this.textBox1.Text = Grid.SelectedRows[0].Cells[1].Value.ToString();
                dist_id = Grid.SelectedRows[0].Cells[0].Value;
                this.Text = "Редактирование записи о районе";
                button1.Text = "Применить";
            }
            this.ActiveControl = textBox1;
        }


        private void button2_Click(object sender, EventArgs e) => this.Close();


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 2)
            {
                MessageBox.Show("Название района не может быть короче 2 символов", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            if (edit_mode)
            {
                DB.UPDATE.Dist(dist_id, textBox1.Text);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Dist())
                    Grid.Rows.Add(row);
                this.Close();
            }
            else
            {
                DB.INSERT.Dist(textBox1.Text);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Dist())
                    Grid.Rows.Add(row);
                this.Close();
            }
        }
    }
}
