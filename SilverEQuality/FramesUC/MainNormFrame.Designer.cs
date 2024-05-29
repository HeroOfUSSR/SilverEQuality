namespace SilverEQuality.FramesUC
{
    partial class MainNormFrame
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
            buttonDocuments = new Button();
            buttonNormView = new Button();
            panelBody = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(buttonDocuments);
            panel2.Controls.Add(buttonNormView);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 24);
            panel2.TabIndex = 3;
            // 
            // buttonDocuments
            // 
            buttonDocuments.BackColor = Color.SteelBlue;
            buttonDocuments.Dock = DockStyle.Left;
            buttonDocuments.FlatAppearance.BorderSize = 0;
            buttonDocuments.FlatStyle = FlatStyle.Flat;
            buttonDocuments.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDocuments.ForeColor = SystemColors.ControlLightLight;
            buttonDocuments.Location = new Point(121, 0);
            buttonDocuments.Name = "buttonDocuments";
            buttonDocuments.Size = new Size(121, 24);
            buttonDocuments.TabIndex = 5;
            buttonDocuments.Text = "Документы";
            buttonDocuments.UseVisualStyleBackColor = false;
            buttonDocuments.Click += buttonDocuments_Click;
            // 
            // buttonNormView
            // 
            buttonNormView.BackColor = Color.SteelBlue;
            buttonNormView.Dock = DockStyle.Left;
            buttonNormView.FlatAppearance.BorderSize = 0;
            buttonNormView.FlatStyle = FlatStyle.Flat;
            buttonNormView.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNormView.ForeColor = SystemColors.ControlLightLight;
            buttonNormView.Location = new Point(0, 0);
            buttonNormView.Name = "buttonNormView";
            buttonNormView.Size = new Size(121, 24);
            buttonNormView.TabIndex = 4;
            buttonNormView.Text = "Список";
            buttonNormView.UseVisualStyleBackColor = false;
            buttonNormView.Click += buttonNormView_Click;
            // 
            // panelBody
            // 
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 24);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1009, 448);
            panelBody.TabIndex = 4;
            // 
            // MainNormFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panel2);
            Name = "MainNormFrame";
            Size = new Size(1009, 472);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button buttonDocuments;
        private Button buttonNormView;
        private Panel panelBody;
    }
}
