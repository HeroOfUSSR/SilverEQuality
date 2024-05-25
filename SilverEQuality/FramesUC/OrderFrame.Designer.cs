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
            panel2 = new Panel();
            flowLayoutPanelOrder = new FlowLayoutPanel();
            panel3 = new Panel();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 100);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 421);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 51);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanelOrder
            // 
            flowLayoutPanelOrder.AutoScroll = true;
            flowLayoutPanelOrder.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelOrder.Dock = DockStyle.Fill;
            flowLayoutPanelOrder.Location = new Point(0, 100);
            flowLayoutPanelOrder.Name = "flowLayoutPanelOrder";
            flowLayoutPanelOrder.Size = new Size(1009, 321);
            flowLayoutPanelOrder.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1009, 28);
            panel3.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.ActiveCaption;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.ForeColor = SystemColors.ControlLightLight;
            buttonSearch.Location = new Point(715, 58);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(121, 29);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "Применить";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(154, 61);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Чеки за всё время";
            textBoxSearch.Size = new Size(555, 23);
            textBoxSearch.TabIndex = 4;
            // 
            // OrderFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanelOrder);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
    }
}
