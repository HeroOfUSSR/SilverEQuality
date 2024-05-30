namespace SilverEQuality.FramesUC
{
    partial class MainCheckFrame
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
            panel2 = new Panel();
            buttonGraphs = new Button();
            buttonGrid = new Button();
            panelBody = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(buttonGraphs);
            panel2.Controls.Add(buttonGrid);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 24);
            panel2.TabIndex = 2;
            // 
            // buttonGraphs
            // 
            buttonGraphs.BackColor = Color.SteelBlue;
            buttonGraphs.Dock = DockStyle.Left;
            buttonGraphs.FlatAppearance.BorderSize = 0;
            buttonGraphs.FlatStyle = FlatStyle.Flat;
            buttonGraphs.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGraphs.ForeColor = SystemColors.ControlLightLight;
            buttonGraphs.Location = new Point(121, 0);
            buttonGraphs.Name = "buttonGraphs";
            buttonGraphs.Size = new Size(121, 24);
            buttonGraphs.TabIndex = 5;
            buttonGraphs.Text = "Графики";
            buttonGraphs.UseVisualStyleBackColor = false;
            buttonGraphs.Click += buttonGraphs_Click;
            // 
            // buttonGrid
            // 
            buttonGrid.BackColor = Color.SteelBlue;
            buttonGrid.Dock = DockStyle.Left;
            buttonGrid.FlatAppearance.BorderSize = 0;
            buttonGrid.FlatStyle = FlatStyle.Flat;
            buttonGrid.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGrid.ForeColor = SystemColors.ControlLightLight;
            buttonGrid.Location = new Point(0, 0);
            buttonGrid.Name = "buttonGrid";
            buttonGrid.Size = new Size(121, 24);
            buttonGrid.TabIndex = 4;
            buttonGrid.Text = "Таблица";
            buttonGrid.UseVisualStyleBackColor = false;
            buttonGrid.Click += buttonGrid_Click;
            // 
            // panelBody
            // 
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 24);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1009, 448);
            panelBody.TabIndex = 3;
            // 
            // MainCheckFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelBody);
            Controls.Add(panel2);
            MaximumSize = new Size(1009, 472);
            MinimumSize = new Size(841, 472);
            Name = "MainCheckFrame";
            Size = new Size(1009, 472);
            Resize += MainCheckFrame_Resize;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button buttonGraphs;
        private Button buttonGrid;
        private Panel panelBody;
    }
}
