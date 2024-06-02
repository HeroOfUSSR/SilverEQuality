namespace SilverEQuality.FramesUC
{
    partial class MaterialView
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
            labelSilverName = new Label();
            labelAmount = new Label();
            labelCost = new Label();
            buttonEdit = new Button();
            buttonNorm = new Button();
            buttonRequest = new Button();
            SuspendLayout();
            // 
            // labelSilverName
            // 
            labelSilverName.AutoSize = true;
            labelSilverName.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelSilverName.Location = new Point(14, 15);
            labelSilverName.Name = "labelSilverName";
            labelSilverName.Size = new Size(229, 19);
            labelSilverName.TabIndex = 0;
            labelSilverName.Text = "Наименование серебра";
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAmount.Location = new Point(14, 45);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(107, 16);
            labelAmount.TabIndex = 1;
            labelAmount.Text = "Количество";
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCost.Location = new Point(547, 32);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(97, 16);
            labelCost.TabIndex = 2;
            labelCost.Text = "Стоимость";
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.SteelBlue;
            buttonEdit.DialogResult = DialogResult.OK;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.ForeColor = SystemColors.ControlLightLight;
            buttonEdit.Location = new Point(481, 77);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(223, 30);
            buttonEdit.TabIndex = 24;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonNorm
            // 
            buttonNorm.BackColor = Color.SteelBlue;
            buttonNorm.DialogResult = DialogResult.OK;
            buttonNorm.FlatAppearance.BorderSize = 0;
            buttonNorm.FlatStyle = FlatStyle.Flat;
            buttonNorm.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNorm.ForeColor = SystemColors.ControlLightLight;
            buttonNorm.Location = new Point(14, 77);
            buttonNorm.Name = "buttonNorm";
            buttonNorm.Size = new Size(232, 30);
            buttonNorm.TabIndex = 25;
            buttonNorm.Text = "Открыть норму";
            buttonNorm.UseVisualStyleBackColor = false;
            // 
            // buttonRequest
            // 
            buttonRequest.BackColor = Color.SteelBlue;
            buttonRequest.DialogResult = DialogResult.OK;
            buttonRequest.FlatAppearance.BorderSize = 0;
            buttonRequest.FlatStyle = FlatStyle.Flat;
            buttonRequest.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRequest.ForeColor = SystemColors.ControlLightLight;
            buttonRequest.Location = new Point(252, 77);
            buttonRequest.Name = "buttonRequest";
            buttonRequest.Size = new Size(223, 30);
            buttonRequest.TabIndex = 26;
            buttonRequest.Text = "Запрос";
            buttonRequest.UseVisualStyleBackColor = false;
            // 
            // MaterialView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonRequest);
            Controls.Add(buttonNorm);
            Controls.Add(buttonEdit);
            Controls.Add(labelCost);
            Controls.Add(labelAmount);
            Controls.Add(labelSilverName);
            MaximumSize = new Size(719, 110);
            MinimumSize = new Size(719, 78);
            Name = "MaterialView";
            Size = new Size(719, 110);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSilverName;
        private Label labelAmount;
        private Label labelCost;
        private Button buttonEdit;
        private Button buttonNorm;
        private Button buttonRequest;
    }
}
