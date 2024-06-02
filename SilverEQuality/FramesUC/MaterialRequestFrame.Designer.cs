namespace SilverEQuality.FramesUC
{
    partial class MaterialRequestFrame
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
            comboBoxPriority = new ComboBox();
            comboBoxStatus = new ComboBox();
            comboBoxSilverType = new ComboBox();
            comboBoxSortDate = new ComboBox();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            flowLayoutPanelRequests = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxPriority);
            panel1.Controls.Add(comboBoxStatus);
            panel1.Controls.Add(comboBoxSilverType);
            panel1.Controls.Add(comboBoxSortDate);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(textBoxSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 80);
            panel1.TabIndex = 0;
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.Anchor = AnchorStyles.Right;
            comboBoxPriority.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.Location = new Point(395, 44);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(190, 24);
            comboBoxPriority.TabIndex = 15;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Anchor = AnchorStyles.Right;
            comboBoxStatus.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(591, 44);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(190, 24);
            comboBoxStatus.TabIndex = 14;
            // 
            // comboBoxSilverType
            // 
            comboBoxSilverType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSilverType.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSilverType.FormattingEnabled = true;
            comboBoxSilverType.Location = new Point(50, 44);
            comboBoxSilverType.Name = "comboBoxSilverType";
            comboBoxSilverType.Size = new Size(339, 24);
            comboBoxSilverType.TabIndex = 13;
            // 
            // comboBoxSortDate
            // 
            comboBoxSortDate.Anchor = AnchorStyles.Right;
            comboBoxSortDate.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSortDate.FormattingEnabled = true;
            comboBoxSortDate.Location = new Point(591, 15);
            comboBoxSortDate.Name = "comboBoxSortDate";
            comboBoxSortDate.Size = new Size(190, 24);
            comboBoxSortDate.TabIndex = 12;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Right;
            buttonSearch.BackColor = Color.SteelBlue;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.ForeColor = SystemColors.ControlLightLight;
            buttonSearch.Location = new Point(787, 14);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(160, 54);
            buttonSearch.TabIndex = 11;
            buttonSearch.Text = "Применить";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(50, 15);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Поиск по пользователю";
            textBoxSearch.Size = new Size(535, 23);
            textBoxSearch.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 416);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 32);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(84, 336);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(925, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(84, 336);
            panel4.TabIndex = 3;
            // 
            // flowLayoutPanelRequests
            // 
            flowLayoutPanelRequests.AutoScroll = true;
            flowLayoutPanelRequests.Dock = DockStyle.Fill;
            flowLayoutPanelRequests.Location = new Point(84, 80);
            flowLayoutPanelRequests.Name = "flowLayoutPanelRequests";
            flowLayoutPanelRequests.Size = new Size(841, 336);
            flowLayoutPanelRequests.TabIndex = 4;
            // 
            // MaterialRequestFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanelRequests);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1009, 448);
            MinimumSize = new Size(841, 448);
            Name = "MaterialRequestFrame";
            Size = new Size(1009, 448);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBoxPriority;
        private ComboBox comboBoxStatus;
        private ComboBox comboBoxSilverType;
        private ComboBox comboBoxSortDate;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Panel panel3;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanelRequests;
    }
}
