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
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dataGridCheck = new DataGridView();
            buttonGrid = new Button();
            buttonGraphs = new Button();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerUntil = new DateTimePicker();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCheck).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 83);
            panel1.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.ActiveCaption;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.ForeColor = SystemColors.ControlLightLight;
            buttonSearch.Location = new Point(707, 42);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(121, 29);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Применить";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(146, 45);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Чеки за всё время";
            textBoxSearch.Size = new Size(555, 23);
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
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dateTimePickerUntil);
            panel3.Controls.Add(dateTimePickerFrom);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 396);
            panel3.Name = "panel3";
            panel3.Size = new Size(1009, 76);
            panel3.TabIndex = 1;
            // 
            // dataGridCheck
            // 
            dataGridCheck.BackgroundColor = SystemColors.ControlLight;
            dataGridCheck.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCheck.Dock = DockStyle.Fill;
            dataGridCheck.Location = new Point(0, 83);
            dataGridCheck.Name = "dataGridCheck";
            dataGridCheck.RowTemplate.Height = 25;
            dataGridCheck.Size = new Size(1009, 313);
            dataGridCheck.TabIndex = 2;
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
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerFrom.Location = new Point(212, 22);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(210, 23);
            dateTimePickerFrom.TabIndex = 5;
            // 
            // dateTimePickerUntil
            // 
            dateTimePickerUntil.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerUntil.Location = new Point(590, 22);
            dateTimePickerUntil.Name = "dateTimePickerUntil";
            dateTimePickerUntil.Size = new Size(210, 23);
            dateTimePickerUntil.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(173, 27);
            label1.Name = "label1";
            label1.Size = new Size(17, 16);
            label1.TabIndex = 7;
            label1.Text = "С";
            // 
            // CheckFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridCheck);
            Controls.Add(panel3);
            Controls.Add(panel1);
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
        private Panel panel4;
        private DataGridView dataGridCheck;
        private Button buttonGraphs;
        private Button buttonGrid;
        private DateTimePicker dateTimePickerFrom;
        private Label label1;
        private DateTimePicker dateTimePickerUntil;
    }
}
