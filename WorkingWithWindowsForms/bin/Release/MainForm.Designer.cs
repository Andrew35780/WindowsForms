namespace WorkingWithWindowsForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Label();
            this.chooseThirdTableButton = new WorkingWithWindowsForms.RoundButton();
            this.label = new System.Windows.Forms.Label();
            this.chooseFourthTableButton = new WorkingWithWindowsForms.RoundButton();
            this.chooseSecondTableButton = new WorkingWithWindowsForms.RoundButton();
            this.chooseFirstTableButton = new WorkingWithWindowsForms.RoundButton();
            this.searchButton = new WorkingWithWindowsForms.RoundButton();
            this.saveButton = new WorkingWithWindowsForms.RoundButton();
            this.firstTableDataGridView = new System.Windows.Forms.DataGridView();
            this.табельныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отделЦехаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.режимРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.работникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vikaDBDataSet = new WorkingWithWindowsForms.VikaDBDataSet();
            this.secondTableDataGridView = new System.Windows.Forms.DataGridView();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отделыЦехаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thirdTableDataGridView = new System.Windows.Forms.DataGridView();
            this.номерРаботникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.месяцDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.всегоЧасовПоПлануЗаМесяцDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.всегоЧасовПоФактуЗаМесяцDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.учётРабочегоВремениBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fourthTableDataGridView = new System.Windows.Forms.DataGridView();
            this.табельныйНомерDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.месяцDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоОтработанныхДнейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.больничныеДниDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.командировочныеДниDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заработнаяПлатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.премияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.начислениеЗаработнойПлатыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.работникиTableAdapter = new WorkingWithWindowsForms.VikaDBDataSetTableAdapters.РаботникиTableAdapter();
            this.отделы_цехаTableAdapter = new WorkingWithWindowsForms.VikaDBDataSetTableAdapters.Отделы_цехаTableAdapter();
            this.учёт_рабочего_времениTableAdapter = new WorkingWithWindowsForms.VikaDBDataSetTableAdapters.Учёт_рабочего_времениTableAdapter();
            this.начисление_заработной_платыTableAdapter = new WorkingWithWindowsForms.VikaDBDataSetTableAdapters.Начисление_заработной_платыTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vikaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыЦехаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учётРабочегоВремениBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.начислениеЗаработнойПлатыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.chooseThirdTableButton);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.chooseFourthTableButton);
            this.panel1.Controls.Add(this.chooseSecondTableButton);
            this.panel1.Controls.Add(this.chooseFirstTableButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 82);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WorkingWithWindowsForms.Properties.Resources.PeopleIcon;
            this.pictureBox4.Location = new System.Drawing.Point(158, 57);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WorkingWithWindowsForms.Properties.Resources.BuildIcon;
            this.pictureBox3.Location = new System.Drawing.Point(305, 57);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WorkingWithWindowsForms.Properties.Resources.TimeIcon;
            this.pictureBox2.Location = new System.Drawing.Point(453, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorkingWithWindowsForms.Properties.Resources.NewCashIcon;
            this.pictureBox1.Location = new System.Drawing.Point(604, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(777, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 27);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "x";
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // chooseThirdTableButton
            // 
            this.chooseThirdTableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(110)))), ((int)(((byte)(170)))));
            this.chooseThirdTableButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.chooseThirdTableButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.chooseThirdTableButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(144)))), ((int)(((byte)(221)))));
            this.chooseThirdTableButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(195)))), ((int)(((byte)(172)))));
            this.chooseThirdTableButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.chooseThirdTableButton.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(163)))), ((int)(((byte)(95)))));
            this.chooseThirdTableButton.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(99)))), ((int)(((byte)(58)))));
            this.chooseThirdTableButton.ButtonPressedForeColor = System.Drawing.Color.White;
            this.chooseThirdTableButton.ButtonRoundRadius = 20;
            this.chooseThirdTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseThirdTableButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseThirdTableButton.Location = new System.Drawing.Point(410, 36);
            this.chooseThirdTableButton.Name = "chooseThirdTableButton";
            this.chooseThirdTableButton.Size = new System.Drawing.Size(117, 28);
            this.chooseThirdTableButton.TabIndex = 6;
            this.chooseThirdTableButton.Text = "Учёт времени";
            this.chooseThirdTableButton.Click += new System.EventHandler(this.ChooseThirdTableButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(325, 3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(140, 20);
            this.label.TabIndex = 0;
            this.label.Text = "Выбрать таблицу:";
            // 
            // chooseFourthTableButton
            // 
            this.chooseFourthTableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(110)))), ((int)(((byte)(170)))));
            this.chooseFourthTableButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.chooseFourthTableButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.chooseFourthTableButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(144)))), ((int)(((byte)(221)))));
            this.chooseFourthTableButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(195)))), ((int)(((byte)(172)))));
            this.chooseFourthTableButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.chooseFourthTableButton.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(163)))), ((int)(((byte)(95)))));
            this.chooseFourthTableButton.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(99)))), ((int)(((byte)(58)))));
            this.chooseFourthTableButton.ButtonPressedForeColor = System.Drawing.Color.White;
            this.chooseFourthTableButton.ButtonRoundRadius = 20;
            this.chooseFourthTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseFourthTableButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseFourthTableButton.Location = new System.Drawing.Point(561, 37);
            this.chooseFourthTableButton.Name = "chooseFourthTableButton";
            this.chooseFourthTableButton.Size = new System.Drawing.Size(117, 28);
            this.chooseFourthTableButton.TabIndex = 5;
            this.chooseFourthTableButton.Text = "Начисление ЗП";
            this.chooseFourthTableButton.Click += new System.EventHandler(this.ChooseFourthTableButton_Click);
            // 
            // chooseSecondTableButton
            // 
            this.chooseSecondTableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(110)))), ((int)(((byte)(170)))));
            this.chooseSecondTableButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.chooseSecondTableButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.chooseSecondTableButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(144)))), ((int)(((byte)(221)))));
            this.chooseSecondTableButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(195)))), ((int)(((byte)(172)))));
            this.chooseSecondTableButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.chooseSecondTableButton.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(163)))), ((int)(((byte)(95)))));
            this.chooseSecondTableButton.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(99)))), ((int)(((byte)(58)))));
            this.chooseSecondTableButton.ButtonPressedForeColor = System.Drawing.Color.White;
            this.chooseSecondTableButton.ButtonRoundRadius = 20;
            this.chooseSecondTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseSecondTableButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseSecondTableButton.Location = new System.Drawing.Point(260, 36);
            this.chooseSecondTableButton.Name = "chooseSecondTableButton";
            this.chooseSecondTableButton.Size = new System.Drawing.Size(117, 28);
            this.chooseSecondTableButton.TabIndex = 3;
            this.chooseSecondTableButton.Text = "Отделы цеха";
            this.chooseSecondTableButton.Click += new System.EventHandler(this.ChooseSecondTableButton_Click);
            // 
            // chooseFirstTableButton
            // 
            this.chooseFirstTableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(110)))), ((int)(((byte)(170)))));
            this.chooseFirstTableButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.chooseFirstTableButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.chooseFirstTableButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(144)))), ((int)(((byte)(221)))));
            this.chooseFirstTableButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(195)))), ((int)(((byte)(172)))));
            this.chooseFirstTableButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.chooseFirstTableButton.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(163)))), ((int)(((byte)(95)))));
            this.chooseFirstTableButton.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(99)))), ((int)(((byte)(58)))));
            this.chooseFirstTableButton.ButtonPressedForeColor = System.Drawing.Color.White;
            this.chooseFirstTableButton.ButtonRoundRadius = 20;
            this.chooseFirstTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseFirstTableButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseFirstTableButton.Location = new System.Drawing.Point(114, 36);
            this.chooseFirstTableButton.Name = "chooseFirstTableButton";
            this.chooseFirstTableButton.Size = new System.Drawing.Size(117, 28);
            this.chooseFirstTableButton.TabIndex = 4;
            this.chooseFirstTableButton.Text = "Работники";
            this.chooseFirstTableButton.Click += new System.EventHandler(this.ChooseFirstTableButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(110)))), ((int)(((byte)(170)))));
            this.searchButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.searchButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(37)))), ((int)(((byte)(57)))));
            this.searchButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(144)))), ((int)(((byte)(221)))));
            this.searchButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(195)))), ((int)(((byte)(172)))));
            this.searchButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.searchButton.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(163)))), ((int)(((byte)(95)))));
            this.searchButton.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(99)))), ((int)(((byte)(58)))));
            this.searchButton.ButtonPressedForeColor = System.Drawing.Color.White;
            this.searchButton.ButtonRoundRadius = 20;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(671, 410);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(117, 28);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Найти";
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(110)))), ((int)(((byte)(170)))));
            this.saveButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.saveButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(37)))), ((int)(((byte)(57)))));
            this.saveButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(144)))), ((int)(((byte)(221)))));
            this.saveButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(195)))), ((int)(((byte)(172)))));
            this.saveButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.saveButton.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(163)))), ((int)(((byte)(95)))));
            this.saveButton.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(99)))), ((int)(((byte)(58)))));
            this.saveButton.ButtonPressedForeColor = System.Drawing.Color.White;
            this.saveButton.ButtonRoundRadius = 20;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(12, 410);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(117, 28);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // firstTableDataGridView
            // 
            this.firstTableDataGridView.AutoGenerateColumns = false;
            this.firstTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firstTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.табельныйНомерDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.отделЦехаDataGridViewTextBoxColumn,
            this.режимРаботыDataGridViewTextBoxColumn});
            this.firstTableDataGridView.DataSource = this.работникиBindingSource;
            this.firstTableDataGridView.Location = new System.Drawing.Point(12, 88);
            this.firstTableDataGridView.Name = "firstTableDataGridView";
            this.firstTableDataGridView.Size = new System.Drawing.Size(776, 307);
            this.firstTableDataGridView.TabIndex = 3;
            this.firstTableDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.FirstTableDataGridView_DataError);
            this.firstTableDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.FirstTableDataGridView_UserDeletingRow);
            // 
            // табельныйНомерDataGridViewTextBoxColumn
            // 
            this.табельныйНомерDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.табельныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Табельный номер";
            this.табельныйНомерDataGridViewTextBoxColumn.HeaderText = "Табельный номер";
            this.табельныйНомерDataGridViewTextBoxColumn.Name = "табельныйНомерDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // отделЦехаDataGridViewTextBoxColumn
            // 
            this.отделЦехаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.отделЦехаDataGridViewTextBoxColumn.DataPropertyName = "Отдел цеха";
            this.отделЦехаDataGridViewTextBoxColumn.HeaderText = "Отдел цеха";
            this.отделЦехаDataGridViewTextBoxColumn.Name = "отделЦехаDataGridViewTextBoxColumn";
            // 
            // режимРаботыDataGridViewTextBoxColumn
            // 
            this.режимРаботыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.режимРаботыDataGridViewTextBoxColumn.DataPropertyName = "Режим работы";
            this.режимРаботыDataGridViewTextBoxColumn.HeaderText = "Режим работы";
            this.режимРаботыDataGridViewTextBoxColumn.Name = "режимРаботыDataGridViewTextBoxColumn";
            // 
            // работникиBindingSource
            // 
            this.работникиBindingSource.DataMember = "Работники";
            this.работникиBindingSource.DataSource = this.vikaDBDataSet;
            // 
            // vikaDBDataSet
            // 
            this.vikaDBDataSet.DataSetName = "VikaDBDataSet";
            this.vikaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // secondTableDataGridView
            // 
            this.secondTableDataGridView.AutoGenerateColumns = false;
            this.secondTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secondTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn});
            this.secondTableDataGridView.DataSource = this.отделыЦехаBindingSource;
            this.secondTableDataGridView.Location = new System.Drawing.Point(12, 88);
            this.secondTableDataGridView.Name = "secondTableDataGridView";
            this.secondTableDataGridView.Size = new System.Drawing.Size(776, 307);
            this.secondTableDataGridView.TabIndex = 4;
            this.secondTableDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.SecondTableDataGridView_DataError);
            this.secondTableDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.SecondTableDataGridView_UserDeletingRow);
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // отделыЦехаBindingSource
            // 
            this.отделыЦехаBindingSource.DataMember = "Отделы цеха";
            this.отделыЦехаBindingSource.DataSource = this.vikaDBDataSet;
            // 
            // thirdTableDataGridView
            // 
            this.thirdTableDataGridView.AutoGenerateColumns = false;
            this.thirdTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thirdTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерРаботникаDataGridViewTextBoxColumn,
            this.годDataGridViewTextBoxColumn,
            this.месяцDataGridViewTextBoxColumn,
            this.всегоЧасовПоПлануЗаМесяцDataGridViewTextBoxColumn,
            this.всегоЧасовПоФактуЗаМесяцDataGridViewTextBoxColumn});
            this.thirdTableDataGridView.DataSource = this.учётРабочегоВремениBindingSource;
            this.thirdTableDataGridView.Location = new System.Drawing.Point(12, 88);
            this.thirdTableDataGridView.Name = "thirdTableDataGridView";
            this.thirdTableDataGridView.Size = new System.Drawing.Size(776, 307);
            this.thirdTableDataGridView.TabIndex = 5;
            this.thirdTableDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ThirdTableDataGridView_DataError);
            this.thirdTableDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ThirdTableDataGridView_UserDeletingRow);
            // 
            // номерРаботникаDataGridViewTextBoxColumn
            // 
            this.номерРаботникаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.номерРаботникаDataGridViewTextBoxColumn.DataPropertyName = "Номер работника";
            this.номерРаботникаDataGridViewTextBoxColumn.HeaderText = "Номер работника";
            this.номерРаботникаDataGridViewTextBoxColumn.Name = "номерРаботникаDataGridViewTextBoxColumn";
            // 
            // годDataGridViewTextBoxColumn
            // 
            this.годDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.годDataGridViewTextBoxColumn.DataPropertyName = "Год";
            this.годDataGridViewTextBoxColumn.HeaderText = "Год";
            this.годDataGridViewTextBoxColumn.Name = "годDataGridViewTextBoxColumn";
            // 
            // месяцDataGridViewTextBoxColumn
            // 
            this.месяцDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.месяцDataGridViewTextBoxColumn.DataPropertyName = "Месяц";
            this.месяцDataGridViewTextBoxColumn.HeaderText = "Месяц";
            this.месяцDataGridViewTextBoxColumn.Name = "месяцDataGridViewTextBoxColumn";
            // 
            // всегоЧасовПоПлануЗаМесяцDataGridViewTextBoxColumn
            // 
            this.всегоЧасовПоПлануЗаМесяцDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.всегоЧасовПоПлануЗаМесяцDataGridViewTextBoxColumn.DataPropertyName = "Всего часов по плану за месяц";
            this.всегоЧасовПоПлануЗаМесяцDataGridViewTextBoxColumn.HeaderText = "Всего часов по плану за месяц";
            this.всегоЧасовПоПлануЗаМесяцDataGridViewTextBoxColumn.Name = "всегоЧасовПоПлануЗаМесяцDataGridViewTextBoxColumn";
            // 
            // всегоЧасовПоФактуЗаМесяцDataGridViewTextBoxColumn
            // 
            this.всегоЧасовПоФактуЗаМесяцDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.всегоЧасовПоФактуЗаМесяцDataGridViewTextBoxColumn.DataPropertyName = "Всего часов по факту за месяц";
            this.всегоЧасовПоФактуЗаМесяцDataGridViewTextBoxColumn.HeaderText = "Всего часов по факту за месяц";
            this.всегоЧасовПоФактуЗаМесяцDataGridViewTextBoxColumn.Name = "всегоЧасовПоФактуЗаМесяцDataGridViewTextBoxColumn";
            // 
            // учётРабочегоВремениBindingSource
            // 
            this.учётРабочегоВремениBindingSource.DataMember = "Учёт рабочего времени";
            this.учётРабочегоВремениBindingSource.DataSource = this.vikaDBDataSet;
            // 
            // fourthTableDataGridView
            // 
            this.fourthTableDataGridView.AutoGenerateColumns = false;
            this.fourthTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fourthTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.табельныйНомерDataGridViewTextBoxColumn1,
            this.годDataGridViewTextBoxColumn1,
            this.месяцDataGridViewTextBoxColumn1,
            this.количествоОтработанныхДнейDataGridViewTextBoxColumn,
            this.больничныеДниDataGridViewTextBoxColumn,
            this.командировочныеДниDataGridViewTextBoxColumn,
            this.заработнаяПлатаDataGridViewTextBoxColumn,
            this.премияDataGridViewTextBoxColumn});
            this.fourthTableDataGridView.DataSource = this.начислениеЗаработнойПлатыBindingSource;
            this.fourthTableDataGridView.Location = new System.Drawing.Point(12, 88);
            this.fourthTableDataGridView.Name = "fourthTableDataGridView";
            this.fourthTableDataGridView.Size = new System.Drawing.Size(776, 307);
            this.fourthTableDataGridView.TabIndex = 6;
            this.fourthTableDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.FourthTableDataGridView_DataError);
            this.fourthTableDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.FourthTableDataGridView_UserDeletingRow);
            // 
            // табельныйНомерDataGridViewTextBoxColumn1
            // 
            this.табельныйНомерDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.табельныйНомерDataGridViewTextBoxColumn1.DataPropertyName = "Табельный номер";
            this.табельныйНомерDataGridViewTextBoxColumn1.HeaderText = "Табельный номер";
            this.табельныйНомерDataGridViewTextBoxColumn1.Name = "табельныйНомерDataGridViewTextBoxColumn1";
            // 
            // годDataGridViewTextBoxColumn1
            // 
            this.годDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.годDataGridViewTextBoxColumn1.DataPropertyName = "Год";
            this.годDataGridViewTextBoxColumn1.HeaderText = "Год";
            this.годDataGridViewTextBoxColumn1.Name = "годDataGridViewTextBoxColumn1";
            // 
            // месяцDataGridViewTextBoxColumn1
            // 
            this.месяцDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.месяцDataGridViewTextBoxColumn1.DataPropertyName = "Месяц";
            this.месяцDataGridViewTextBoxColumn1.HeaderText = "Месяц";
            this.месяцDataGridViewTextBoxColumn1.Name = "месяцDataGridViewTextBoxColumn1";
            // 
            // количествоОтработанныхДнейDataGridViewTextBoxColumn
            // 
            this.количествоОтработанныхДнейDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.количествоОтработанныхДнейDataGridViewTextBoxColumn.DataPropertyName = "Количество отработанных дней";
            this.количествоОтработанныхДнейDataGridViewTextBoxColumn.HeaderText = "Количество отработанных дней";
            this.количествоОтработанныхДнейDataGridViewTextBoxColumn.Name = "количествоОтработанныхДнейDataGridViewTextBoxColumn";
            // 
            // больничныеДниDataGridViewTextBoxColumn
            // 
            this.больничныеДниDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.больничныеДниDataGridViewTextBoxColumn.DataPropertyName = "Больничные дни";
            this.больничныеДниDataGridViewTextBoxColumn.HeaderText = "Больничные дни";
            this.больничныеДниDataGridViewTextBoxColumn.Name = "больничныеДниDataGridViewTextBoxColumn";
            // 
            // командировочныеДниDataGridViewTextBoxColumn
            // 
            this.командировочныеДниDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.командировочныеДниDataGridViewTextBoxColumn.DataPropertyName = "Командировочные дни";
            this.командировочныеДниDataGridViewTextBoxColumn.HeaderText = "Командировочные дни";
            this.командировочныеДниDataGridViewTextBoxColumn.Name = "командировочныеДниDataGridViewTextBoxColumn";
            // 
            // заработнаяПлатаDataGridViewTextBoxColumn
            // 
            this.заработнаяПлатаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.заработнаяПлатаDataGridViewTextBoxColumn.DataPropertyName = "Заработная плата";
            this.заработнаяПлатаDataGridViewTextBoxColumn.HeaderText = "Заработная плата";
            this.заработнаяПлатаDataGridViewTextBoxColumn.Name = "заработнаяПлатаDataGridViewTextBoxColumn";
            // 
            // премияDataGridViewTextBoxColumn
            // 
            this.премияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.премияDataGridViewTextBoxColumn.DataPropertyName = "Премия";
            this.премияDataGridViewTextBoxColumn.HeaderText = "Премия";
            this.премияDataGridViewTextBoxColumn.Name = "премияDataGridViewTextBoxColumn";
            // 
            // начислениеЗаработнойПлатыBindingSource
            // 
            this.начислениеЗаработнойПлатыBindingSource.DataMember = "Начисление заработной платы";
            this.начислениеЗаработнойПлатыBindingSource.DataSource = this.vikaDBDataSet;
            // 
            // работникиTableAdapter
            // 
            this.работникиTableAdapter.ClearBeforeFill = true;
            // 
            // отделы_цехаTableAdapter
            // 
            this.отделы_цехаTableAdapter.ClearBeforeFill = true;
            // 
            // учёт_рабочего_времениTableAdapter
            // 
            this.учёт_рабочего_времениTableAdapter.ClearBeforeFill = true;
            // 
            // начисление_заработной_платыTableAdapter
            // 
            this.начисление_заработной_платыTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(37)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fourthTableDataGridView);
            this.Controls.Add(this.thirdTableDataGridView);
            this.Controls.Add(this.secondTableDataGridView);
            this.Controls.Add(this.firstTableDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vikaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыЦехаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учётРабочегоВремениBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.начислениеЗаработнойПлатыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RoundButton chooseThirdTableButton;
        private System.Windows.Forms.Label label;
        private RoundButton chooseFourthTableButton;
        private RoundButton chooseSecondTableButton;
        private RoundButton chooseFirstTableButton;
        private RoundButton saveButton;
        private RoundButton searchButton;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.DataGridView firstTableDataGridView;
        public System.Windows.Forms.DataGridView secondTableDataGridView;
        public System.Windows.Forms.DataGridView thirdTableDataGridView;
        public System.Windows.Forms.DataGridView fourthTableDataGridView;
        private VikaDBDataSet vikaDBDataSet;
        private System.Windows.Forms.BindingSource работникиBindingSource;
        private VikaDBDataSetTableAdapters.РаботникиTableAdapter работникиTableAdapter;
        private System.Windows.Forms.BindingSource отделыЦехаBindingSource;
        private VikaDBDataSetTableAdapters.Отделы_цехаTableAdapter отделы_цехаTableAdapter;
        private System.Windows.Forms.BindingSource учётРабочегоВремениBindingSource;
        private VikaDBDataSetTableAdapters.Учёт_рабочего_времениTableAdapter учёт_рабочего_времениTableAdapter;
        private System.Windows.Forms.BindingSource начислениеЗаработнойПлатыBindingSource;
        private VikaDBDataSetTableAdapters.Начисление_заработной_платыTableAdapter начисление_заработной_платыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn табельныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отделЦехаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn режимРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерРаботникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn месяцDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn всегоЧасовПоПлануЗаМесяцDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn всегоЧасовПоФактуЗаМесяцDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn табельныйНомерDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn годDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn месяцDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоОтработанныхДнейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn больничныеДниDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn командировочныеДниDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заработнаяПлатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn премияDataGridViewTextBoxColumn;
    }
}

