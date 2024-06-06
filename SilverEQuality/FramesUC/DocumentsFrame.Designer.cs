namespace SilverEQuality.FramesUC
{
    partial class DocumentsFrame
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
            panel4 = new Panel();
            label4 = new Label();
            buttonDownloadPZ = new Button();
            flowLayoutPanelDocuments = new FlowLayoutPanel();
            panel3 = new Panel();
            label1 = new Label();
            buttonDownloadNorm = new Button();
            panel4.SuspendLayout();
            flowLayoutPanelDocuments.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 19);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 428);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 20);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(buttonDownloadPZ);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(441, 95);
            panel4.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 14);
            label4.Name = "label4";
            label4.Size = new Size(240, 19);
            label4.TabIndex = 30;
            label4.Text = "Пояснительная записка";
            // 
            // buttonDownloadPZ
            // 
            buttonDownloadPZ.Anchor = AnchorStyles.None;
            buttonDownloadPZ.BackColor = Color.SteelBlue;
            buttonDownloadPZ.DialogResult = DialogResult.OK;
            buttonDownloadPZ.FlatAppearance.BorderSize = 0;
            buttonDownloadPZ.FlatStyle = FlatStyle.Flat;
            buttonDownloadPZ.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDownloadPZ.ForeColor = SystemColors.ControlLightLight;
            buttonDownloadPZ.Location = new Point(13, 46);
            buttonDownloadPZ.Name = "buttonDownloadPZ";
            buttonDownloadPZ.Size = new Size(412, 37);
            buttonDownloadPZ.TabIndex = 29;
            buttonDownloadPZ.Text = "Скачать";
            buttonDownloadPZ.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanelDocuments
            // 
            flowLayoutPanelDocuments.Controls.Add(panel4);
            flowLayoutPanelDocuments.Controls.Add(panel3);
            flowLayoutPanelDocuments.Dock = DockStyle.Left;
            flowLayoutPanelDocuments.Location = new Point(0, 19);
            flowLayoutPanelDocuments.Name = "flowLayoutPanelDocuments";
            flowLayoutPanelDocuments.Size = new Size(451, 409);
            flowLayoutPanelDocuments.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(buttonDownloadNorm);
            panel3.Location = new Point(3, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(441, 95);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(251, 19);
            label1.TabIndex = 30;
            label1.Text = "Нормативный акт №20088";
            // 
            // buttonDownloadNorm
            // 
            buttonDownloadNorm.Anchor = AnchorStyles.None;
            buttonDownloadNorm.BackColor = Color.SteelBlue;
            buttonDownloadNorm.DialogResult = DialogResult.OK;
            buttonDownloadNorm.FlatAppearance.BorderSize = 0;
            buttonDownloadNorm.FlatStyle = FlatStyle.Flat;
            buttonDownloadNorm.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDownloadNorm.ForeColor = SystemColors.ControlLightLight;
            buttonDownloadNorm.Location = new Point(13, 45);
            buttonDownloadNorm.Name = "buttonDownloadNorm";
            buttonDownloadNorm.Size = new Size(412, 37);
            buttonDownloadNorm.TabIndex = 29;
            buttonDownloadNorm.Text = "Скачать";
            buttonDownloadNorm.UseVisualStyleBackColor = false;
            // 
            // DocumentsFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanelDocuments);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1009, 448);
            MinimumSize = new Size(841, 448);
            Name = "DocumentsFrame";
            Size = new Size(1009, 448);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            flowLayoutPanelDocuments.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Label label4;
        private Button buttonDownloadPZ;
        private FlowLayoutPanel flowLayoutPanelDocuments;
        private Panel panel3;
        private Label label1;
        private Button buttonDownloadNorm;
    }
}
