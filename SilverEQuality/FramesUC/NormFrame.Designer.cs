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
            panelWork = new Panel();
            buttonAdd = new Button();
            buttonEdit = new Button();
            checkBoxEditMode = new CheckBox();
            buttonDelete = new Button();
            maskedTextBoxNorm = new MaskedTextBox();
            comboBoxDecimal = new ComboBox();
            comboBoxSilverType = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBoxSearch = new TextBox();
            dataGridViewNorm = new DataGridView();
            panel3.SuspendLayout();
            panelWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNorm).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 18);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 426);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 22);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panelWork);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBoxSearch);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(703, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(306, 408);
            panel3.TabIndex = 2;
            // 
            // panelWork
            // 
            panelWork.Controls.Add(buttonAdd);
            panelWork.Controls.Add(buttonEdit);
            panelWork.Controls.Add(checkBoxEditMode);
            panelWork.Controls.Add(buttonDelete);
            panelWork.Controls.Add(maskedTextBoxNorm);
            panelWork.Controls.Add(comboBoxDecimal);
            panelWork.Controls.Add(comboBoxSilverType);
            panelWork.Controls.Add(label2);
            panelWork.Controls.Add(label4);
            panelWork.Controls.Add(label3);
            panelWork.Dock = DockStyle.Bottom;
            panelWork.Location = new Point(0, 66);
            panelWork.Name = "panelWork";
            panelWork.Size = new Size(306, 342);
            panelWork.TabIndex = 33;
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
            buttonAdd.Location = new Point(0, 246);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(306, 32);
            buttonAdd.TabIndex = 30;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
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
            buttonEdit.Location = new Point(0, 278);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(306, 32);
            buttonEdit.TabIndex = 29;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Visible = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // checkBoxEditMode
            // 
            checkBoxEditMode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxEditMode.AutoSize = true;
            checkBoxEditMode.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxEditMode.Location = new Point(30, 210);
            checkBoxEditMode.Name = "checkBoxEditMode";
            checkBoxEditMode.Size = new Size(248, 23);
            checkBoxEditMode.TabIndex = 32;
            checkBoxEditMode.Text = "Режим редактирования";
            checkBoxEditMode.UseVisualStyleBackColor = true;
            checkBoxEditMode.CheckedChanged += checkBoxEditMode_CheckedChanged;
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
            buttonDelete.Location = new Point(0, 310);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(306, 32);
            buttonDelete.TabIndex = 31;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Visible = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // maskedTextBoxNorm
            // 
            maskedTextBoxNorm.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxNorm.Location = new Point(41, 146);
            maskedTextBoxNorm.Mask = "0.000000";
            maskedTextBoxNorm.Name = "maskedTextBoxNorm";
            maskedTextBoxNorm.Size = new Size(223, 26);
            maskedTextBoxNorm.TabIndex = 31;
            // 
            // comboBoxDecimal
            // 
            comboBoxDecimal.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDecimal.FormattingEnabled = true;
            comboBoxDecimal.Location = new Point(41, 33);
            comboBoxDecimal.Name = "comboBoxDecimal";
            comboBoxDecimal.Size = new Size(223, 27);
            comboBoxDecimal.TabIndex = 23;
            // 
            // comboBoxSilverType
            // 
            comboBoxSilverType.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSilverType.FormattingEnabled = true;
            comboBoxSilverType.Location = new Point(41, 88);
            comboBoxSilverType.Name = "comboBoxSilverType";
            comboBoxSilverType.Size = new Size(223, 27);
            comboBoxSilverType.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 14);
            label2.Name = "label2";
            label2.Size = new Size(177, 16);
            label2.TabIndex = 25;
            label2.Text = "Децимальный номер";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 127);
            label4.Name = "label4";
            label4.Size = new Size(157, 16);
            label4.TabIndex = 27;
            label4.Text = "Норма обработки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 69);
            label3.Name = "label3";
            label3.Size = new Size(117, 16);
            label3.TabIndex = 26;
            label3.Text = "Вид серебра";
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
            dataGridViewNorm.Location = new Point(0, 18);
            dataGridViewNorm.Name = "dataGridViewNorm";
            dataGridViewNorm.RowTemplate.Height = 25;
            dataGridViewNorm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewNorm.Size = new Size(703, 408);
            dataGridViewNorm.TabIndex = 3;
            dataGridViewNorm.SelectionChanged += dataGridViewNorm_SelectionChanged;
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
            MinimumSize = new Size(841, 448);
            Name = "NormFrame";
            Size = new Size(1009, 448);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelWork.ResumeLayout(false);
            panelWork.PerformLayout();
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
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxSilverType;
        private ComboBox comboBoxDecimal;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private MaskedTextBox maskedTextBoxNorm;
        private CheckBox checkBoxEditMode;
        private Panel panelWork;
    }
}
