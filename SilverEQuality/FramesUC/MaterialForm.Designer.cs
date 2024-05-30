namespace SilverEQuality.FramesUC
{
    partial class MaterialForm
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
            flowLayoutPanelSilver = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 22);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 410);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 38);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanelSilver
            // 
            flowLayoutPanelSilver.Dock = DockStyle.Fill;
            flowLayoutPanelSilver.Location = new Point(0, 22);
            flowLayoutPanelSilver.Name = "flowLayoutPanelSilver";
            flowLayoutPanelSilver.Size = new Size(1009, 388);
            flowLayoutPanelSilver.TabIndex = 2;
            // 
            // MaterialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanelSilver);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1009, 448);
            MinimumSize = new Size(841, 448);
            Name = "MaterialForm";
            Size = new Size(1009, 448);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanelSilver;
    }
}
