namespace SilverEQuality.Forms
{
    partial class CheckFrame
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            checkBoxNorm = new CheckBox();
            comboBoxSortDate = new ComboBox();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            panel3 = new Panel();
            buttonReportCreate = new Button();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerUntil = new DateTimePicker();
            dateTimePickerFrom = new DateTimePicker();
            dataGridCheck = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCheck).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxNorm);
            panel1.Controls.Add(comboBoxSortDate);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(textBoxSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 83);
            panel1.TabIndex = 0;
            // 
            // checkBoxNorm
            // 
            checkBoxNorm.Anchor = AnchorStyles.Left;
            checkBoxNorm.AutoSize = true;
            checkBoxNorm.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxNorm.Location = new Point(255, 54);
            checkBoxNorm.Name = "checkBoxNorm";
            checkBoxNorm.Size = new Size(296, 20);
            checkBoxNorm.TabIndex = 8;
            checkBoxNorm.Text = "Выделить некорректные нормы";
            checkBoxNorm.UseVisualStyleBackColor = true;
            checkBoxNorm.CheckedChanged += checkBoxNorm_CheckedChanged;
            // 
            // comboBoxSortDate
            // 
            comboBoxSortDate.Anchor = AnchorStyles.Right;
            comboBoxSortDate.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSortDate.FormattingEnabled = true;
            comboBoxSortDate.Location = new Point(573, 25);
            comboBoxSortDate.Name = "comboBoxSortDate";
            comboBoxSortDate.Size = new Size(190, 24);
            comboBoxSortDate.TabIndex = 7;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Right;
            buttonSearch.BackColor = Color.SteelBlue;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.ForeColor = SystemColors.ControlLightLight;
            buttonSearch.Location = new Point(769, 22);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(121, 29);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Применить";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(105, 25);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Чеки за всё время";
            textBoxSearch.Size = new Size(462, 23);
            textBoxSearch.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonReportCreate);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dateTimePickerUntil);
            panel3.Controls.Add(dateTimePickerFrom);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 372);
            panel3.Name = "panel3";
            panel3.Size = new Size(1009, 76);
            panel3.TabIndex = 1;
            // 
            // buttonReportCreate
            // 
            buttonReportCreate.Anchor = AnchorStyles.Right;
            buttonReportCreate.BackColor = Color.SteelBlue;
            buttonReportCreate.FlatAppearance.BorderSize = 0;
            buttonReportCreate.FlatStyle = FlatStyle.Flat;
            buttonReportCreate.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReportCreate.ForeColor = SystemColors.ControlLightLight;
            buttonReportCreate.Location = new Point(761, 25);
            buttonReportCreate.Name = "buttonReportCreate";
            buttonReportCreate.Size = new Size(214, 34);
            buttonReportCreate.TabIndex = 9;
            buttonReportCreate.Text = "Сформировать отчёт";
            buttonReportCreate.UseVisualStyleBackColor = false;
            buttonReportCreate.Click += buttonReportCreate_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(381, 36);
            label2.Name = "label2";
            label2.Size = new Size(37, 16);
            label2.TabIndex = 8;
            label2.Text = "По:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 36);
            label1.Name = "label1";
            label1.Size = new Size(27, 16);
            label1.TabIndex = 7;
            label1.Text = "С:";
            // 
            // dateTimePickerUntil
            // 
            dateTimePickerUntil.Anchor = AnchorStyles.None;
            dateTimePickerUntil.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerUntil.Location = new Point(424, 31);
            dateTimePickerUntil.Name = "dateTimePickerUntil";
            dateTimePickerUntil.Size = new Size(210, 23);
            dateTimePickerUntil.TabIndex = 6;
            dateTimePickerUntil.ValueChanged += dateTimePickerUntil_ValueChanged;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Anchor = AnchorStyles.Left;
            dateTimePickerFrom.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerFrom.Location = new Point(54, 31);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(210, 23);
            dateTimePickerFrom.TabIndex = 5;
            dateTimePickerFrom.ValueChanged += dateTimePickerFrom_ValueChanged;
            // 
            // dataGridCheck
            // 
            dataGridCheck.AllowUserToAddRows = false;
            dataGridCheck.AllowUserToDeleteRows = false;
            dataGridCheck.BackgroundColor = Color.White;
            dataGridCheck.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCheck.Dock = DockStyle.Fill;
            dataGridCheck.Location = new Point(0, 83);
            dataGridCheck.Name = "dataGridCheck";
            dataGridCheck.ReadOnly = true;
            dataGridCheck.RowTemplate.Height = 25;
            dataGridCheck.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCheck.Size = new Size(1009, 289);
            dataGridCheck.TabIndex = 2;
            // 
            // CheckFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridCheck);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MaximumSize = new Size(1009, 448);
            MinimumSize = new Size(841, 448);
            Name = "CheckFrame";
            Size = new Size(1009, 448);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCheck).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private DataGridView dataGridCheck;
        private DateTimePicker dateTimePickerFrom;
        private Label label1;
        private DateTimePicker dateTimePickerUntil;
        private ComboBox comboBoxSortDate;
        private CheckBox checkBoxNorm;
        private Label label2;
        private Button buttonReportCreate;
    }
}
