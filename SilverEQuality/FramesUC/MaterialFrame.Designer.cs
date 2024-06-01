namespace SilverEQuality.FramesUC
{
    partial class MaterialFrame
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
            buttonAdd = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            flowLayoutPanelSilver = new FlowLayoutPanel();
            panel2.SuspendLayout();
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
            panel2.Controls.Add(buttonAdd);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 381);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 67);
            panel2.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.SteelBlue;
            buttonAdd.DialogResult = DialogResult.OK;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.ForeColor = SystemColors.ControlLightLight;
            buttonAdd.Location = new Point(389, 17);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(249, 30);
            buttonAdd.TabIndex = 25;
            buttonAdd.Text = "Редактировать";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(145, 359);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(864, 22);
            panel4.Name = "panel4";
            panel4.Size = new Size(145, 359);
            panel4.TabIndex = 3;
            // 
            // flowLayoutPanelSilver
            // 
            flowLayoutPanelSilver.Dock = DockStyle.Fill;
            flowLayoutPanelSilver.Location = new Point(145, 22);
            flowLayoutPanelSilver.Name = "flowLayoutPanelSilver";
            flowLayoutPanelSilver.Size = new Size(719, 359);
            flowLayoutPanelSilver.TabIndex = 4;
            // 
            // MaterialFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanelSilver);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1009, 448);
            MinimumSize = new Size(841, 448);
            Name = "MaterialFrame";
            Size = new Size(1009, 448);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanelSilver;
        private Button buttonAdd;
    }
}
