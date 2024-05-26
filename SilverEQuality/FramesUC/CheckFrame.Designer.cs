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
            panel2 = new Panel();
            buttonGraphs = new Button();
            buttonGrid = new Button();
            panel3 = new Panel();
            label1 = new Label();
            dateTimePickerUntil = new DateTimePicker();
            dateTimePickerFrom = new DateTimePicker();
            dataGridCheck = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 83);
            panel1.TabIndex = 0;
            // 
            // checkBoxNorm
            // 
            checkBoxNorm.Anchor = AnchorStyles.Right;
            checkBoxNorm.AutoSize = true;
            checkBoxNorm.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxNorm.Location = new Point(167, 57);
            checkBoxNorm.Name = "checkBoxNorm";
            checkBoxNorm.Size = new Size(296, 20);
            checkBoxNorm.TabIndex = 8;
            checkBoxNorm.Text = "Выделить некорректные нормы";
            checkBoxNorm.UseVisualStyleBackColor = true;
            // 
            // comboBoxSortDate
            // 
            comboBoxSortDate.Anchor = AnchorStyles.Right;
            comboBoxSortDate.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSortDate.FormattingEnabled = true;
            comboBoxSortDate.Location = new Point(556, 30);
            comboBoxSortDate.Name = "comboBoxSortDate";
            comboBoxSortDate.Size = new Size(190, 24);
            comboBoxSortDate.TabIndex = 7;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Right;
            buttonSearch.BackColor = SystemColors.ActiveCaption;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.ForeColor = SystemColors.ControlLightLight;
            buttonSearch.Location = new Point(752, 27);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(121, 29);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Применить";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Right;
            textBoxSearch.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(88, 30);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Чеки за всё время";
            textBoxSearch.Size = new Size(462, 23);
            textBoxSearch.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonGraphs);
            panel2.Controls.Add(buttonGrid);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 24);
            panel2.TabIndex = 1;
            // 
            // buttonGraphs
            // 
            buttonGraphs.BackColor = SystemColors.ActiveCaption;
            buttonGraphs.Dock = DockStyle.Left;
            buttonGraphs.FlatAppearance.BorderSize = 0;
            buttonGraphs.FlatStyle = FlatStyle.Flat;
            buttonGraphs.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGraphs.ForeColor = SystemColors.ControlLightLight;
            buttonGraphs.Location = new Point(121, 0);
            buttonGraphs.Name = "buttonGraphs";
            buttonGraphs.Size = new Size(121, 24);
            buttonGraphs.TabIndex = 5;
            buttonGraphs.Text = "Графики";
            buttonGraphs.UseVisualStyleBackColor = false;
            // 
            // buttonGrid
            // 
            buttonGrid.BackColor = SystemColors.ActiveCaption;
            buttonGrid.Dock = DockStyle.Left;
            buttonGrid.FlatAppearance.BorderSize = 0;
            buttonGrid.FlatStyle = FlatStyle.Flat;
            buttonGrid.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGrid.ForeColor = SystemColors.ControlLightLight;
            buttonGrid.Location = new Point(0, 0);
            buttonGrid.Name = "buttonGrid";
            buttonGrid.Size = new Size(121, 24);
            buttonGrid.TabIndex = 4;
            buttonGrid.Text = "Таблица";
            buttonGrid.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dateTimePickerUntil);
            panel3.Controls.Add(dateTimePickerFrom);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 396);
            panel3.Name = "panel3";
            panel3.Size = new Size(1009, 76);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(179, 32);
            label1.Name = "label1";
            label1.Size = new Size(27, 16);
            label1.TabIndex = 7;
            label1.Text = "С:";
            // 
            // dateTimePickerUntil
            // 
            dateTimePickerUntil.Anchor = AnchorStyles.Right;
            dateTimePickerUntil.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerUntil.Location = new Point(556, 27);
            dateTimePickerUntil.Name = "dateTimePickerUntil";
            dateTimePickerUntil.Size = new Size(210, 23);
            dateTimePickerUntil.TabIndex = 6;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Anchor = AnchorStyles.Right;
            dateTimePickerFrom.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerFrom.Location = new Point(212, 27);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(210, 23);
            dateTimePickerFrom.TabIndex = 5;
            // 
            // dataGridCheck
            // 
            dataGridCheck.BackgroundColor = SystemColors.ControlLight;
            dataGridCheck.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCheck.Dock = DockStyle.Fill;
            dataGridCheck.Location = new Point(0, 83);
            dataGridCheck.Name = "dataGridCheck";
            dataGridCheck.RowTemplate.Height = 25;
            dataGridCheck.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCheck.Size = new Size(1009, 313);
            dataGridCheck.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(513, 32);
            label2.Name = "label2";
            label2.Size = new Size(37, 16);
            label2.TabIndex = 8;
            label2.Text = "По:";
            // 
            // CheckFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridCheck);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MaximumSize = new Size(1009, 472);
            MinimumSize = new Size(841, 472);
            Name = "CheckFrame";
            Size = new Size(1009, 472);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCheck).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private DataGridView dataGridCheck;
        private Button buttonGraphs;
        private Button buttonGrid;
        private DateTimePicker dateTimePickerFrom;
        private Label label1;
        private DateTimePicker dateTimePickerUntil;
        private ComboBox comboBoxSortDate;
        private CheckBox checkBoxNorm;
        private Label label2;
    }
}
