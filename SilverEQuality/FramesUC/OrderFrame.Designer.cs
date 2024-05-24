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
            SuspendLayout();
            // 
            // panel1
            // 
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanelOrder;
    }
}
