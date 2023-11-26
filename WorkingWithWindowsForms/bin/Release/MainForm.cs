using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WorkingWithWindowsForms
{
    public partial class MainForm : Form
    {
        private RoundButton currentButton;

        private readonly List<DataGridView> dataGridViews;

        private Point lastPoint;

        public MainForm()
        {
            InitializeComponent();

            dataGridViews = new List<DataGridView>() {firstTableDataGridView, secondTableDataGridView, thirdTableDataGridView, fourthTableDataGridView };

            ChangeDataGridViewVisible(firstTableDataGridView);

            PlacElementsInMiddleOfPanel();

            currentButton = chooseFirstTableButton;
            currentButton.BackColor = Color.FromArgb(28, 83, 128);
            currentButton.BackColor2 = Color.FromArgb(30, 135, 119);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vikaDBDataSet.Начисление_заработной_платы". При необходимости она может быть перемещена или удалена.
            this.начисление_заработной_платыTableAdapter.Fill(this.vikaDBDataSet.Начисление_заработной_платы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vikaDBDataSet.Учёт_рабочего_времени". При необходимости она может быть перемещена или удалена.
            this.учёт_рабочего_времениTableAdapter.Fill(this.vikaDBDataSet.Учёт_рабочего_времени);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vikaDBDataSet.Отделы_цеха". При необходимости она может быть перемещена или удалена.
            this.отделы_цехаTableAdapter.Fill(this.vikaDBDataSet.Отделы_цеха);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vikaDBDataSet.Работники". При необходимости она может быть перемещена или удалена.
            this.работникиTableAdapter.Fill(this.vikaDBDataSet.Работники);
        }

        private void PlacElementsInMiddleOfPanel()
        {
            label.Left = (panel1.Width - label.Width) / 2;
            chooseFirstTableButton.Top = (panel1.Height - chooseFirstTableButton.Height) / 2;
            chooseSecondTableButton.Top = (panel1.Height - chooseFirstTableButton.Height) / 2;
            chooseThirdTableButton.Top = (panel1.Height - chooseThirdTableButton.Height) / 2;
            chooseFourthTableButton.Top = (panel1.Height - chooseFourthTableButton.Height) / 2;
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e) => closeButton.ForeColor = Color.Red;

        private void CloseButton_MouseLeave(object sender, EventArgs e) => closeButton.ForeColor = Color.White;

        private void CloseButton_Click(object sender, EventArgs e) => Close();

        private void Panel1_MouseDown(object sender, MouseEventArgs e) => lastPoint = new Point(e.X, e.Y);

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e) => lastPoint = new Point(e.X, e.Y);

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void ChangeCurrentButtonColor(RoundButton roundButtonName)
        {
            currentButton.BackColor = Color.FromArgb(37, 110, 170);
            currentButton.BackColor2 = Color.FromArgb(37, 170, 150);

            currentButton = roundButtonName;

            currentButton.BackColor = Color.FromArgb(28, 83, 128);
            currentButton.BackColor2 = Color.FromArgb(30, 135, 119);
        }

        private void ChangeDataGridViewVisible(DataGridView currentDataGridView)
        {
            foreach (var dataGridView in dataGridViews)
            {
                if (dataGridView.Name == currentDataGridView.Name)
                    currentDataGridView.Visible = true;
                else
                    dataGridView.Visible = false;
            }
        }

        private void ChooseFirstTableButton_Click(object sender, EventArgs e)
        {
            if (currentButton != chooseFirstTableButton)
            {
                ChangeCurrentButtonColor(chooseFirstTableButton);
                ChangeDataGridViewVisible(firstTableDataGridView);
            }   
        }

        private void ChooseSecondTableButton_Click(object sender, EventArgs e)
        {
            if (currentButton != chooseSecondTableButton)
            {
                ChangeCurrentButtonColor(chooseSecondTableButton);
                ChangeDataGridViewVisible(secondTableDataGridView);
            }
        }

        private void ChooseThirdTableButton_Click(object sender, EventArgs e)
        {
            if (currentButton != chooseThirdTableButton)
            {
                ChangeCurrentButtonColor(chooseThirdTableButton);
                ChangeDataGridViewVisible(thirdTableDataGridView);
            }  
        }

        private void ChooseFourthTableButton_Click(object sender, EventArgs e)
        {
            if (currentButton != chooseFourthTableButton)
            {
                ChangeCurrentButtonColor(chooseFourthTableButton);
                ChangeDataGridViewVisible(fourthTableDataGridView);
            } 
        }

        private void ShowDeletingRowMessageBox(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void FirstTableDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) => ShowDeletingRowMessageBox(sender, e);

        private void SecondTableDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) => ShowDeletingRowMessageBox(sender, e);

        private void ThirdTableDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) => ShowDeletingRowMessageBox(sender, e);

        private void FourthTableDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) => ShowDeletingRowMessageBox(sender, e);

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Validate();
            работникиBindingSource.EndEdit();
            отделыЦехаBindingSource.EndEdit();
            учётРабочегоВремениBindingSource.EndEdit();
            начислениеЗаработнойПлатыBindingSource.EndEdit();
            работникиTableAdapter.Update(vikaDBDataSet.Работники);
            отделы_цехаTableAdapter.Update(vikaDBDataSet.Отделы_цеха);
            учёт_рабочего_времениTableAdapter.Update(vikaDBDataSet.Учёт_рабочего_времени);
            начисление_заработной_платыTableAdapter.Update(vikaDBDataSet.Начисление_заработной_платы);

            MessageBox.Show("Таблица успешно сохранена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm
            {
                Owner = this
            };
            searchForm.Show();
        }

        private void ShowDataErrorMessageBox(DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"{e.Exception.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false;  
        }

        private void FirstTableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) => ShowDataErrorMessageBox(e);

        private void SecondTableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) => ShowDataErrorMessageBox(e);

        private void ThirdTableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) => ShowDataErrorMessageBox(e);

        private void FourthTableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) => ShowDataErrorMessageBox(e);   
    }

    public class RoundButton : Control
    {
        public Color BackColor2 { get; set; }
        public Color ButtonBorderColor { get; set; }
        public int ButtonRoundRadius { get; set; }

        public Color ButtonHighlightColor { get; set; }
        public Color ButtonHighlightColor2 { get; set; }
        public Color ButtonHighlightForeColor { get; set; }

        public Color ButtonPressedColor { get; set; }
        public Color ButtonPressedColor2 { get; set; }
        public Color ButtonPressedForeColor { get; set; }

        private bool IsHighlighted;
        private bool IsPressed;

        public RoundButton()
        {
            Size = new Size(100, 40);
            ButtonRoundRadius = 30;
            BackColor = Color.Gainsboro;
            BackColor2 = Color.Silver;
            ButtonBorderColor = Color.Black;
            ButtonHighlightColor = Color.Orange;
            ButtonHighlightColor2 = Color.OrangeRed;
            ButtonHighlightForeColor = Color.Black;

            ButtonPressedColor = Color.Red;
            ButtonPressedColor2 = Color.Maroon;
            ButtonPressedForeColor = Color.White;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return createParams;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            var foreColor = IsPressed ? ButtonPressedForeColor : IsHighlighted ? ButtonHighlightForeColor : ForeColor;
            var backColor = IsPressed ? ButtonPressedColor : IsHighlighted ? ButtonHighlightColor : BackColor;
            var backColor2 = IsPressed ? ButtonPressedColor2 : IsHighlighted ? ButtonHighlightColor2 : BackColor2;


            using (var pen = new Pen(ButtonBorderColor, 1))
                e.Graphics.DrawPath(pen, Path);

            using (var brush = new LinearGradientBrush(ClientRectangle, backColor, backColor2, LinearGradientMode.Vertical))
                e.Graphics.FillPath(brush, Path);

            using (var brush = new SolidBrush(foreColor))
            {
                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                var rect = ClientRectangle;
                rect.Inflate(-4, -4);
                e.Graphics.DrawString(Text, Font, brush, rect, sf);
            }

            base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            IsHighlighted = true;
            Parent.Invalidate(Bounds, false);
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            IsHighlighted = false;
            IsPressed = false;
            Parent.Invalidate(Bounds, false);
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Parent.Invalidate(Bounds, false);
            Invalidate();
            IsPressed = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Parent.Invalidate(Bounds, false);
            Invalidate();
            IsPressed = false;
        }

        protected GraphicsPath Path
        {
            get
            {
                var rect = ClientRectangle;
                rect.Inflate(-1, -1);
                return GetRoundedRectangle(rect, ButtonRoundRadius);
            }
        }

        public static GraphicsPath GetRoundedRectangle(Rectangle rect, int d)
        {
            var gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, d, d, 180, 90);
            gp.AddArc(rect.X + rect.Width - d, rect.Y, d, d, 270, 90);
            gp.AddArc(rect.X + rect.Width - d, rect.Y + rect.Height - d, d, d, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - d, d, d, 90, 90);
            gp.CloseFigure();

            return gp;
        }
    }
}
