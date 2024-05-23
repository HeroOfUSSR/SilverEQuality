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
            panel1.SuspendLayout();
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
            panel1.Size = new Size(841, 83);
            panel1.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.Location = new Point(639, 46);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(121, 29);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Применить";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(78, 49);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Чеки за всё время";
            textBoxSearch.Size = new Size(555, 23);
            textBoxSearch.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(841, 24);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 405);
            panel3.Name = "panel3";
            panel3.Size = new Size(841, 76);
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
            dataGridCheck.Size = new Size(841, 322);
            dataGridCheck.TabIndex = 2;
            // 
            // CheckFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridCheck);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CheckFrame";
            Size = new Size(841, 481);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}
