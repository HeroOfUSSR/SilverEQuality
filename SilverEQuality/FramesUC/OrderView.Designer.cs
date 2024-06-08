namespace SilverEQuality.FramesUC
{
    partial class OrderView
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.buttonMore = new System.Windows.Forms.Button();
            this.timerExpand = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonComments = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonImageMan = new System.Windows.Forms.Button();
            this.openFileDialogImageChange = new System.Windows.Forms.OpenFileDialog();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.flowLayoutPanelOrderParts = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonNotFound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanelOrderParts.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxAvatar.Image = global::SilverEQuality.Properties.Resources.company_placeholder;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Padding = new System.Windows.Forms.Padding(20, 30, 20, 30);
            this.pictureBoxAvatar.Size = new System.Drawing.Size(158, 147);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 0;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOrderNumber.Location = new System.Drawing.Point(164, 15);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(86, 19);
            this.labelOrderNumber.TabIndex = 1;
            this.labelOrderNumber.Text = "Заказ №";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.Location = new System.Drawing.Point(164, 50);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(67, 16);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Статус";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriority.Location = new System.Drawing.Point(164, 34);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(97, 16);
            this.labelPriority.TabIndex = 3;
            this.labelPriority.Text = "Приоритет";
            // 
            // buttonMore
            // 
            this.buttonMore.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonMore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonMore.FlatAppearance.BorderSize = 0;
            this.buttonMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMore.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMore.Location = new System.Drawing.Point(0, 110);
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.Size = new System.Drawing.Size(130, 36);
            this.buttonMore.TabIndex = 4;
            this.buttonMore.Text = "Подробнее";
            this.buttonMore.UseVisualStyleBackColor = false;
            // 
            // timerExpand
            // 
            this.timerExpand.Interval = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Controls.Add(this.buttonMore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(348, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 146);
            this.panel1.TabIndex = 5;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCheck.FlatAppearance.BorderSize = 0;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCheck.Location = new System.Drawing.Point(0, 74);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(130, 36);
            this.buttonCheck.TabIndex = 5;
            this.buttonCheck.Text = "Отчёт";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonComments);
            this.panel2.Controls.Add(this.buttonEdit);
            this.panel2.Controls.Add(this.buttonImageMan);
            this.panel2.Controls.Add(this.pictureBoxAvatar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 146);
            this.panel2.TabIndex = 6;
            // 
            // buttonComments
            // 
            this.buttonComments.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonComments.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonComments.FlatAppearance.BorderSize = 0;
            this.buttonComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComments.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonComments.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonComments.Location = new System.Drawing.Point(0, 219);
            this.buttonComments.Name = "buttonComments";
            this.buttonComments.Size = new System.Drawing.Size(158, 36);
            this.buttonComments.TabIndex = 7;
            this.buttonComments.Text = "Комментарии";
            this.buttonComments.UseVisualStyleBackColor = false;
            this.buttonComments.Visible = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Location = new System.Drawing.Point(0, 183);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(158, 36);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Visible = false;
            // 
            // buttonImageMan
            // 
            this.buttonImageMan.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonImageMan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonImageMan.FlatAppearance.BorderSize = 0;
            this.buttonImageMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImageMan.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonImageMan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonImageMan.Location = new System.Drawing.Point(0, 147);
            this.buttonImageMan.Name = "buttonImageMan";
            this.buttonImageMan.Size = new System.Drawing.Size(158, 36);
            this.buttonImageMan.TabIndex = 5;
            this.buttonImageMan.Text = "Изменить фото";
            this.buttonImageMan.UseVisualStyleBackColor = false;
            this.buttonImageMan.Visible = false;
            // 
            // openFileDialogImageChange
            // 
            this.openFileDialogImageChange.FileName = "openFileDialog1";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.BackColor = System.Drawing.Color.White;
            this.textBoxDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDesc.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDesc.Location = new System.Drawing.Point(164, 146);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.ReadOnly = true;
            this.textBoxDesc.Size = new System.Drawing.Size(321, 149);
            this.textBoxDesc.TabIndex = 8;
            this.textBoxDesc.Text = "ОЧЕНЬ КРУТОE ОПИСАНИЕ. ТУТ КЛАССНЕНЬКИЕ ВЕЩИ ОПИСАНЫ, Например: что я сегодня пок" +
    "ушал, где я сегодня гулял";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelManufacturer.Location = new System.Drawing.Point(164, 123);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(111, 14);
            this.labelManufacturer.TabIndex = 9;
            this.labelManufacturer.Text = "Производитель";
            // 
            // flowLayoutPanelOrderParts
            // 
            this.flowLayoutPanelOrderParts.AutoScroll = true;
            this.flowLayoutPanelOrderParts.Controls.Add(this.buttonNotFound);
            this.flowLayoutPanelOrderParts.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelOrderParts.Location = new System.Drawing.Point(338, 0);
            this.flowLayoutPanelOrderParts.MaximumSize = new System.Drawing.Size(362, 298);
            this.flowLayoutPanelOrderParts.MinimumSize = new System.Drawing.Size(10, 146);
            this.flowLayoutPanelOrderParts.Name = "flowLayoutPanelOrderParts";
            this.flowLayoutPanelOrderParts.Size = new System.Drawing.Size(10, 146);
            this.flowLayoutPanelOrderParts.TabIndex = 7;
            this.flowLayoutPanelOrderParts.Visible = false;
            // 
            // buttonNotFound
            // 
            this.buttonNotFound.Enabled = false;
            this.buttonNotFound.FlatAppearance.BorderSize = 0;
            this.buttonNotFound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotFound.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNotFound.Location = new System.Drawing.Point(3, 3);
            this.buttonNotFound.Name = "buttonNotFound";
            this.buttonNotFound.Size = new System.Drawing.Size(353, 292);
            this.buttonNotFound.TabIndex = 0;
            this.buttonNotFound.Text = "Детали не найдены";
            this.buttonNotFound.UseVisualStyleBackColor = true;
            this.buttonNotFound.Visible = false;
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanelOrderParts);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelOrderNumber);
            this.MaximumSize = new System.Drawing.Size(980, 300);
            this.MinimumSize = new System.Drawing.Size(480, 148);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(478, 146);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanelOrderParts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxAvatar;
        private Label labelOrderNumber;
        private Label labelStatus;
        private Label labelPriority;
        private Button buttonMore;
        private System.Windows.Forms.Timer timerExpand;
        private Panel panel1;
        private Panel panel2;
        private Button buttonImageMan;
        private OpenFileDialog openFileDialogImageChange;
        private Button buttonComments;
        private Button buttonEdit;
        private TextBox textBoxDesc;
        private Label labelManufacturer;
        private FlowLayoutPanel flowLayoutPanelOrderParts;
        private Button buttonNotFound;
        private Button buttonCheck;
    }
}
