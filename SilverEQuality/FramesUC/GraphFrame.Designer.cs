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
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            label10 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBoxUnits = new ComboBox();
            buttonApply = new Button();
            panelActual = new Panel();
            buttonOffActual = new Button();
            label2 = new Label();
            panel5 = new Panel();
            panelNorm = new Panel();
            buttonOffNorms = new Button();
            label1 = new Label();
            panel4 = new Panel();
            panelGraph = new Panel();
            graphView = new OxyPlot.WindowsForms.PlotView();
            panel3.SuspendLayout();
            panelActual.SuspendLayout();
            panelNorm.SuspendLayout();
            panelGraph.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 10);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 438);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 10);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(dateTimePickerEnd);
            panel3.Controls.Add(dateTimePickerStart);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(comboBoxUnits);
            panel3.Controls.Add(buttonApply);
            panel3.Controls.Add(panelActual);
            panel3.Controls.Add(panelNorm);
            panel3.Controls.Add(panelGraph);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(1009, 428);
            panel3.TabIndex = 2;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Anchor = AnchorStyles.Right;
            dateTimePickerEnd.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEnd.Format = DateTimePickerFormat.Short;
            dateTimePickerEnd.Location = new Point(557, 382);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(140, 23);
            dateTimePickerEnd.TabIndex = 45;
            dateTimePickerEnd.ValueChanged += dateTimePickerEnd_ValueChanged;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Anchor = AnchorStyles.Right;
            dateTimePickerStart.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStart.Format = DateTimePickerFormat.Short;
            dateTimePickerStart.Location = new Point(389, 382);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(139, 23);
            dateTimePickerStart.TabIndex = 44;
            dateTimePickerStart.ValueChanged += dateTimePickerStart_ValueChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(534, 389);
            label10.Name = "label10";
            label10.Size = new Size(17, 16);
            label10.TabIndex = 46;
            label10.Text = "-";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(389, 359);
            label4.Name = "label4";
            label4.Size = new Size(47, 16);
            label4.TabIndex = 12;
            label4.Text = "Даты";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(394, 296);
            label3.Name = "label3";
            label3.Size = new Size(177, 16);
            label3.TabIndex = 10;
            label3.Text = "Единицы измерения";
            // 
            // comboBoxUnits
            // 
            comboBoxUnits.Anchor = AnchorStyles.Right;
            comboBoxUnits.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUnits.FormattingEnabled = true;
            comboBoxUnits.Location = new Point(389, 317);
            comboBoxUnits.Name = "comboBoxUnits";
            comboBoxUnits.Size = new Size(308, 24);
            comboBoxUnits.TabIndex = 9;
            // 
            // buttonApply
            // 
            buttonApply.Anchor = AnchorStyles.Right;
            buttonApply.BackColor = Color.SteelBlue;
            buttonApply.FlatAppearance.BorderSize = 0;
            buttonApply.FlatStyle = FlatStyle.Flat;
            buttonApply.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonApply.ForeColor = SystemColors.ControlLightLight;
            buttonApply.Location = new Point(739, 356);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(237, 48);
            buttonApply.TabIndex = 8;
            buttonApply.Text = "Применить";
            buttonApply.UseVisualStyleBackColor = false;
            buttonApply.Click += buttonApply_Click;
            // 
            // panelActual
            // 
            panelActual.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelActual.BorderStyle = BorderStyle.FixedSingle;
            panelActual.Controls.Add(buttonOffActual);
            panelActual.Controls.Add(label2);
            panelActual.Controls.Add(panel5);
            panelActual.Location = new Point(26, 362);
            panelActual.Name = "panelActual";
            panelActual.Size = new Size(338, 43);
            panelActual.TabIndex = 4;
            // 
            // buttonOffActual
            // 
            buttonOffActual.Dock = DockStyle.Right;
            buttonOffActual.FlatStyle = FlatStyle.Flat;
            buttonOffActual.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOffActual.Location = new Point(277, 0);
            buttonOffActual.Name = "buttonOffActual";
            buttonOffActual.Size = new Size(59, 41);
            buttonOffActual.TabIndex = 4;
            buttonOffActual.Text = "ВКЛ";
            buttonOffActual.UseVisualStyleBackColor = true;
            buttonOffActual.Click += buttonOffActual_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(66, 12);
            label2.Name = "label2";
            label2.Size = new Size(197, 16);
            label2.TabIndex = 3;
            label2.Text = "Фактические затраты";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(200, 121, 121);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(60, 41);
            panel5.TabIndex = 2;
            // 
            // panelNorm
            // 
            panelNorm.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelNorm.BorderStyle = BorderStyle.FixedSingle;
            panelNorm.Controls.Add(buttonOffNorms);
            panelNorm.Controls.Add(label1);
            panelNorm.Controls.Add(panel4);
            panelNorm.Location = new Point(26, 303);
            panelNorm.Name = "panelNorm";
            panelNorm.Size = new Size(338, 43);
            panelNorm.TabIndex = 3;
            // 
            // buttonOffNorms
            // 
            buttonOffNorms.Dock = DockStyle.Right;
            buttonOffNorms.FlatStyle = FlatStyle.Flat;
            buttonOffNorms.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOffNorms.Location = new Point(277, 0);
            buttonOffNorms.Name = "buttonOffNorms";
            buttonOffNorms.Size = new Size(59, 41);
            buttonOffNorms.TabIndex = 3;
            buttonOffNorms.Text = "ВКЛ";
            buttonOffNorms.UseVisualStyleBackColor = true;
            buttonOffNorms.Click += buttonOffNorms_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 12);
            label1.Name = "label1";
            label1.Size = new Size(177, 16);
            label1.TabIndex = 2;
            label1.Text = "Затраты по нормам";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(200, 220, 255);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(60, 41);
            panel4.TabIndex = 1;
            // 
            // panelGraph
            // 
            panelGraph.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelGraph.Controls.Add(graphView);
            panelGraph.Location = new Point(93, 6);
            panelGraph.Name = "panelGraph";
            panelGraph.Size = new Size(823, 270);
            panelGraph.TabIndex = 0;
            // 
            // graphView
            // 
            graphView.Dock = DockStyle.Fill;
            graphView.Location = new Point(0, 0);
            graphView.Name = "graphView";
            graphView.PanCursor = Cursors.Hand;
            graphView.Size = new Size(823, 270);
            graphView.TabIndex = 0;
            graphView.Text = "Затраты";
            graphView.ZoomHorizontalCursor = Cursors.SizeWE;
            graphView.ZoomRectangleCursor = Cursors.SizeNWSE;
            graphView.ZoomVerticalCursor = Cursors.SizeNS;
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
            panel3.PerformLayout();
            panelActual.ResumeLayout(false);
            panelActual.PerformLayout();
            panelNorm.ResumeLayout(false);
            panelNorm.PerformLayout();
            panelGraph.ResumeLayout(false);
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
        private ComboBox comboBoxUnits;
        private Button buttonApply;
        private Label label4;
        private Label label3;
        private Button buttonOffActual;
        private Button buttonOffNorms;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private Label label10;
    }
}
