namespace SilverEQuality.FramesUC
{
    partial class GraphFrame
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
            panel5 = new Panel();
            panel4 = new Panel();
            panelGraph = new Panel();
            graphView = new OxyPlot.WindowsForms.PlotView();
            panelNorm = new Panel();
            panelActual = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel3.SuspendLayout();
            panelGraph.SuspendLayout();
            panelNorm.SuspendLayout();
            panelActual.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 27);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 413);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 35);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panelActual);
            panel3.Controls.Add(panelNorm);
            panel3.Controls.Add(panelGraph);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(1009, 386);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(200, 121, 121);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(68, 43);
            panel5.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(200, 220, 255);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(68, 43);
            panel4.TabIndex = 1;
            // 
            // panelGraph
            // 
            panelGraph.Controls.Add(graphView);
            panelGraph.Location = new Point(38, 55);
            panelGraph.Name = "panelGraph";
            panelGraph.Size = new Size(576, 270);
            panelGraph.TabIndex = 0;
            // 
            // graphView
            // 
            graphView.Location = new Point(3, 3);
            graphView.Name = "graphView";
            graphView.PanCursor = Cursors.Hand;
            graphView.Size = new Size(570, 264);
            graphView.TabIndex = 0;
            graphView.Text = "plotView1";
            graphView.ZoomHorizontalCursor = Cursors.SizeWE;
            graphView.ZoomRectangleCursor = Cursors.SizeNWSE;
            graphView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // panelNorm
            // 
            panelNorm.Controls.Add(label1);
            panelNorm.Controls.Add(panel4);
            panelNorm.Location = new Point(652, 58);
            panelNorm.Name = "panelNorm";
            panelNorm.Size = new Size(263, 43);
            panelNorm.TabIndex = 3;
            // 
            // panelActual
            // 
            panelActual.Controls.Add(label2);
            panelActual.Controls.Add(panel5);
            panelActual.Location = new Point(652, 117);
            panelActual.Name = "panelActual";
            panelActual.Size = new Size(280, 43);
            panelActual.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 19);
            label1.Name = "label1";
            label1.Size = new Size(177, 16);
            label1.TabIndex = 2;
            label1.Text = "Затраты по нормам";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 18);
            label2.Name = "label2";
            label2.Size = new Size(197, 16);
            label2.TabIndex = 3;
            label2.Text = "Фактические затраты";
            // 
            // GraphFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1009, 448);
            MinimumSize = new Size(841, 448);
            Name = "GraphFrame";
            Size = new Size(1009, 448);
            Load += GraphFrame_Load;
            panel3.ResumeLayout(false);
            panelGraph.ResumeLayout(false);
            panelNorm.ResumeLayout(false);
            panelNorm.PerformLayout();
            panelActual.ResumeLayout(false);
            panelActual.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panelGraph;
        private OxyPlot.WindowsForms.PlotView graphView;
        private Panel panel4;
        private Panel panel5;
        private Panel panelActual;
        private Panel panelNorm;
        private Label label1;
        private Label label2;
    }
}
