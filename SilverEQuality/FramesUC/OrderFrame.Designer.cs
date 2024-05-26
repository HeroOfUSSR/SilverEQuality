namespace SilverEQuality.Forms
{
    partial class OrderFrame
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
            comboBoxManuf = new ComboBox();
            comboBoxSortDate = new ComboBox();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            flowLayoutPanelOrder = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxPriority);
            panel1.Controls.Add(comboBoxStatus);
            panel1.Controls.Add(comboBoxManuf);
            panel1.Controls.Add(comboBoxSortDate);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 100);
            panel1.TabIndex = 0;
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.Anchor = AnchorStyles.Right;
            comboBoxPriority.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.Location = new Point(575, 63);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(190, 24);
            comboBoxPriority.TabIndex = 9;
            comboBoxPriority.SelectedIndexChanged += comboBoxPriority_SelectedIndexChanged;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Anchor = AnchorStyles.Right;
            comboBoxStatus.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(379, 63);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(190, 24);
            comboBoxStatus.TabIndex = 8;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // comboBoxManuf
            // 
            comboBoxManuf.Anchor = AnchorStyles.Right;
            comboBoxManuf.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxManuf.FormattingEnabled = true;
            comboBoxManuf.Location = new Point(183, 63);
            comboBoxManuf.Name = "comboBoxManuf";
            comboBoxManuf.Size = new Size(190, 24);
            comboBoxManuf.TabIndex = 7;
            comboBoxManuf.SelectedIndexChanged += comboBoxManuf_SelectedIndexChanged;
            // 
            // comboBoxSortDate
            // 
            comboBoxSortDate.Anchor = AnchorStyles.Right;
            comboBoxSortDate.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSortDate.FormattingEnabled = true;
            comboBoxSortDate.Location = new Point(613, 34);
            comboBoxSortDate.Name = "comboBoxSortDate";
            comboBoxSortDate.Size = new Size(190, 24);
            comboBoxSortDate.TabIndex = 6;
            comboBoxSortDate.SelectedIndexChanged += comboBoxSortDate_SelectedIndexChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Right;
            buttonSearch.BackColor = SystemColors.ActiveCaption;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.ForeColor = SystemColors.ControlLightLight;
            buttonSearch.Location = new Point(809, 31);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(121, 29);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "Применить";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(72, 35);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Поиск по номеру заказа";
            textBoxSearch.Size = new Size(535, 23);
            textBoxSearch.TabIndex = 4;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1009, 28);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 438);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 34);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanelOrder
            // 
            flowLayoutPanelOrder.AutoScroll = true;
            flowLayoutPanelOrder.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelOrder.Dock = DockStyle.Fill;
            flowLayoutPanelOrder.Location = new Point(0, 100);
            flowLayoutPanelOrder.Name = "flowLayoutPanelOrder";
            flowLayoutPanelOrder.Size = new Size(1009, 338);
            flowLayoutPanelOrder.TabIndex = 2;
            // 
            // OrderFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanelOrder);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1009, 472);
            MinimumSize = new Size(841, 472);
            Name = "OrderFrame";
            Size = new Size(1009, 472);
            Load += OrderFrame_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanelOrder;
        private Panel panel3;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private ComboBox comboBoxSortDate;
        private ComboBox comboBoxPriority;
        private ComboBox comboBoxStatus;
        private ComboBox comboBoxManuf;
    }
}
