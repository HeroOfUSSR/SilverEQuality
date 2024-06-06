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
            panelLeftSide = new Panel();
            panelRightSide = new Panel();
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
            buttonAdd.Anchor = AnchorStyles.None;
            buttonAdd.BackColor = Color.SteelBlue;
            buttonAdd.DialogResult = DialogResult.OK;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.ForeColor = SystemColors.ControlLightLight;
            buttonAdd.Location = new Point(314, 11);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(379, 45);
            buttonAdd.TabIndex = 25;
            buttonAdd.Text = "Добавить новый материал";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panelLeftSide
            // 
            panelLeftSide.Dock = DockStyle.Left;
            panelLeftSide.Location = new Point(0, 22);
            panelLeftSide.Name = "panelLeftSide";
            panelLeftSide.Size = new Size(120, 359);
            panelLeftSide.TabIndex = 2;
            panelLeftSide.Visible = false;
            // 
            // panelRightSide
            // 
            panelRightSide.Dock = DockStyle.Right;
            panelRightSide.Location = new Point(889, 22);
            panelRightSide.Name = "panelRightSide";
            panelRightSide.Size = new Size(120, 359);
            panelRightSide.TabIndex = 3;
            panelRightSide.Visible = false;
            // 
            // flowLayoutPanelSilver
            // 
            flowLayoutPanelSilver.AutoScroll = true;
            flowLayoutPanelSilver.Dock = DockStyle.Fill;
            flowLayoutPanelSilver.Location = new Point(120, 22);
            flowLayoutPanelSilver.Name = "flowLayoutPanelSilver";
            flowLayoutPanelSilver.Size = new Size(769, 359);
            flowLayoutPanelSilver.TabIndex = 4;
            flowLayoutPanelSilver.MouseEnter += flowLayoutPanelSilver_MouseEnter;
            flowLayoutPanelSilver.MouseLeave += flowLayoutPanelSilver_MouseLeave;
            // 
            // MaterialFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanelSilver);
            Controls.Add(panelRightSide);
            Controls.Add(panelLeftSide);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1009, 448);
            MinimumSize = new Size(841, 448);
            Name = "MaterialFrame";
            Size = new Size(1009, 448);
            SizeChanged += MaterialFrame_SizeChanged;
            Resize += MaterialFrame_Resize;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelLeftSide;
        private Panel panelRightSide;
        private FlowLayoutPanel flowLayoutPanelSilver;
        private Button buttonAdd;
    }
}
