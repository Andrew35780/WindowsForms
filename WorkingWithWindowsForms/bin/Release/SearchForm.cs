using System;
using System.Drawing;
using System.Windows.Forms;

namespace WorkingWithWindowsForms
{
    public partial class SearchForm : Form
    {
        Point lastPoint;

        public SearchForm()
        {
            InitializeComponent();

            searchButton.Left = (Width - searchButton.Width) / 2;
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e) => closeButton.ForeColor = Color.Red;

        private void CloseButton_MouseLeave(object sender, EventArgs e) => closeButton.ForeColor = Color.White;

        private void CloseButton_Click(object sender, EventArgs e) => Close();

        private void SearchForm_MouseDown(object sender, MouseEventArgs e) => lastPoint = new Point(e.X, e.Y);

        private void SearchForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void SearchRowInTable(DataGridView dataGridView)
        {
            bool isSearchSuccessful = false;

            if (dataGridView.Visible != true)
                return;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Index >= dataGridView.Rows.Count - 1)
                    break;
                row.Selected = false;
                if (row.Cells[0].Value.ToString().Contains(tbStr.Text))
                {
                    row.Selected = true;
                    isSearchSuccessful = true;
                    break;
                }
                else
                    continue;
            }

            if (isSearchSuccessful == true)
                MessageBox.Show("Запись успешно найдена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (isSearchSuccessful == false)
                MessageBox.Show("Такой записи не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;

            if (main == null)
                return;

            SearchRowInTable(main.firstTableDataGridView);
            SearchRowInTable(main.secondTableDataGridView);
            SearchRowInTable(main.thirdTableDataGridView);
            SearchRowInTable(main.fourthTableDataGridView);
        }
    }
}
