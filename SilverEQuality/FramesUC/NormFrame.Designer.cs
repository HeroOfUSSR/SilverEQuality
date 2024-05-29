namespace SilverEQuality.FramesUC
{
    partial class NormFrame
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
            panel2 = new Panel();
            panel3 = new Panel();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox3 = new TextBox();
            textBoxSearch = new TextBox();
            dataGridViewNorm = new DataGridView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNorm).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 24);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 422);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 26);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonAdd);
            panel3.Controls.Add(buttonEdit);
            panel3.Controls.Add(buttonDelete);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBoxSearch);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(705, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(304, 398);
            panel3.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.SteelBlue;
            buttonAdd.DialogResult = DialogResult.OK;
            buttonAdd.Dock = DockStyle.Bottom;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.ForeColor = SystemColors.ControlLightLight;
            buttonAdd.Location = new Point(0, 302);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(304, 32);
            buttonAdd.TabIndex = 30;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = SystemColors.ActiveBorder;
            buttonEdit.DialogResult = DialogResult.OK;
            buttonEdit.Dock = DockStyle.Bottom;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.ForeColor = SystemColors.ControlLightLight;
            buttonEdit.Location = new Point(0, 334);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(304, 32);
            buttonEdit.TabIndex = 29;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.DialogResult = DialogResult.OK;
            buttonDelete.Dock = DockStyle.Bottom;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = SystemColors.ControlLightLight;
            buttonDelete.Location = new Point(0, 366);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(304, 32);
            buttonDelete.TabIndex = 28;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 217);
            label4.Name = "label4";
            label4.Size = new Size(157, 16);
            label4.TabIndex = 27;
            label4.Text = "Норма обработки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 157);
            label3.Name = "label3";
            label3.Size = new Size(117, 16);
            label3.TabIndex = 26;
            label3.Text = "Вид серебра";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 96);
            label2.Name = "label2";
            label2.Size = new Size(177, 16);
            label2.TabIndex = 25;
            label2.Text = "Децимальный номер";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(41, 176);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(223, 27);
            comboBox2.TabIndex = 24;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(41, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 27);
            comboBox1.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 12);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 22;
            label1.Text = "Поиск";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(41, 236);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(223, 26);
            textBox3.TabIndex = 21;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(41, 34);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(223, 26);
            textBoxSearch.TabIndex = 18;
            // 
            // dataGridViewNorm
            // 
            dataGridViewNorm.BackgroundColor = SystemColors.Control;
            dataGridViewNorm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNorm.Dock = DockStyle.Fill;
            dataGridViewNorm.Location = new Point(0, 24);
            dataGridViewNorm.Name = "dataGridViewNorm";
            dataGridViewNorm.RowTemplate.Height = 25;
            dataGridViewNorm.Size = new Size(705, 398);
            dataGridViewNorm.TabIndex = 3;
            // 
            // NormFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewNorm);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1009, 448);
            Name = "NormFrame";
            Size = new Size(1009, 448);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNorm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridViewNorm;
        private TextBox textBoxSearch;
        private Label label1;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
    }
}
