namespace SilverEQuality.FramesUC
{
    partial class MainOrderFrame
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
            buttonEditAdd = new Button();
            buttonView = new Button();
            panelBody = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(buttonEditAdd);
            panel2.Controls.Add(buttonView);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 24);
            panel2.TabIndex = 3;
            // 
            // buttonEditAdd
            // 
            buttonEditAdd.BackColor = Color.SteelBlue;
            buttonEditAdd.Dock = DockStyle.Left;
            buttonEditAdd.FlatAppearance.BorderSize = 0;
            buttonEditAdd.FlatStyle = FlatStyle.Flat;
            buttonEditAdd.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditAdd.ForeColor = SystemColors.ControlLightLight;
            buttonEditAdd.Location = new Point(121, 0);
            buttonEditAdd.Name = "buttonEditAdd";
            buttonEditAdd.Size = new Size(121, 24);
            buttonEditAdd.TabIndex = 5;
            buttonEditAdd.Text = "Добавление";
            buttonEditAdd.UseVisualStyleBackColor = false;
            buttonEditAdd.Click += buttonEditAdd_Click;
            // 
            // buttonView
            // 
            buttonView.BackColor = Color.SteelBlue;
            buttonView.Dock = DockStyle.Left;
            buttonView.FlatAppearance.BorderSize = 0;
            buttonView.FlatStyle = FlatStyle.Flat;
            buttonView.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonView.ForeColor = SystemColors.ControlLightLight;
            buttonView.Location = new Point(0, 0);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(121, 24);
            buttonView.TabIndex = 4;
            buttonView.Text = "Список";
            buttonView.UseVisualStyleBackColor = false;
            buttonView.Click += buttonView_Click;
            // 
            // panelBody
            // 
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 24);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1009, 448);
            panelBody.TabIndex = 4;
            // 
            // MainOrderFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panel2);
            Name = "MainOrderFrame";
            Size = new Size(1009, 472);
            Resize += MainOrderFrame_Resize;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button buttonEditAdd;
        private Button buttonView;
        private Panel panelBody;
    }
}
