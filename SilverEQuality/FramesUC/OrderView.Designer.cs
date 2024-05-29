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
            components = new System.ComponentModel.Container();
            pictureBoxAvatar = new PictureBox();
            labelOrderNumber = new Label();
            labelStatus = new Label();
            labelPriority = new Label();
            buttonMore = new Button();
            timerExpand = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            buttonComments = new Button();
            buttonEdit = new Button();
            buttonImageMan = new Button();
            openFileDialogImageChange = new OpenFileDialog();
            textBoxDesc = new TextBox();
            labelManufacturer = new Label();
            flowLayoutPanelOrderParts = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Dock = DockStyle.Top;
            pictureBoxAvatar.Location = new Point(0, 0);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(158, 134);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar.TabIndex = 0;
            pictureBoxAvatar.TabStop = false;
            // 
            // labelOrderNumber
            // 
            labelOrderNumber.AutoSize = true;
            labelOrderNumber.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelOrderNumber.Location = new Point(164, 15);
            labelOrderNumber.Name = "labelOrderNumber";
            labelOrderNumber.Size = new Size(86, 19);
            labelOrderNumber.TabIndex = 1;
            labelOrderNumber.Text = "Заказ №";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatus.Location = new Point(164, 50);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(67, 16);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Статус";
            // 
            // labelPriority
            // 
            labelPriority.AutoSize = true;
            labelPriority.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPriority.Location = new Point(164, 34);
            labelPriority.Name = "labelPriority";
            labelPriority.Size = new Size(97, 16);
            labelPriority.TabIndex = 3;
            labelPriority.Text = "Приоритет";
            // 
            // buttonMore
            // 
            buttonMore.BackColor = Color.SteelBlue;
            buttonMore.Dock = DockStyle.Bottom;
            buttonMore.FlatAppearance.BorderSize = 0;
            buttonMore.FlatStyle = FlatStyle.Flat;
            buttonMore.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMore.ForeColor = SystemColors.ControlLightLight;
            buttonMore.Location = new Point(0, 262);
            buttonMore.Name = "buttonMore";
            buttonMore.Size = new Size(130, 36);
            buttonMore.TabIndex = 4;
            buttonMore.Text = "Подробнее";
            buttonMore.UseVisualStyleBackColor = false;
            buttonMore.Click += buttonMore_Click;
            // 
            // timerExpand
            // 
            timerExpand.Interval = 5;
            timerExpand.Tick += timerExpand_Tick;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonMore);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(848, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(130, 298);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonComments);
            panel2.Controls.Add(buttonEdit);
            panel2.Controls.Add(buttonImageMan);
            panel2.Controls.Add(pictureBoxAvatar);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 298);
            panel2.TabIndex = 6;
            // 
            // buttonComments
            // 
            buttonComments.BackColor = Color.SteelBlue;
            buttonComments.Dock = DockStyle.Top;
            buttonComments.FlatAppearance.BorderSize = 0;
            buttonComments.FlatStyle = FlatStyle.Flat;
            buttonComments.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonComments.ForeColor = SystemColors.ControlLightLight;
            buttonComments.Location = new Point(0, 206);
            buttonComments.Name = "buttonComments";
            buttonComments.Size = new Size(158, 36);
            buttonComments.TabIndex = 7;
            buttonComments.Text = "Комментарии";
            buttonComments.UseVisualStyleBackColor = false;
            buttonComments.Visible = false;
            buttonComments.Click += buttonComments_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.SteelBlue;
            buttonEdit.Dock = DockStyle.Top;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.ForeColor = SystemColors.ControlLightLight;
            buttonEdit.Location = new Point(0, 170);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(158, 36);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Visible = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonImageMan
            // 
            buttonImageMan.BackColor = Color.SteelBlue;
            buttonImageMan.Dock = DockStyle.Top;
            buttonImageMan.FlatAppearance.BorderSize = 0;
            buttonImageMan.FlatStyle = FlatStyle.Flat;
            buttonImageMan.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonImageMan.ForeColor = SystemColors.ControlLightLight;
            buttonImageMan.Location = new Point(0, 134);
            buttonImageMan.Name = "buttonImageMan";
            buttonImageMan.Size = new Size(158, 36);
            buttonImageMan.TabIndex = 5;
            buttonImageMan.Text = "Изменить фото";
            buttonImageMan.UseVisualStyleBackColor = false;
            buttonImageMan.Visible = false;
            buttonImageMan.Click += buttonImageMan_Click;
            // 
            // openFileDialogImageChange
            // 
            openFileDialogImageChange.FileName = "openFileDialog1";
            // 
            // textBoxDesc
            // 
            textBoxDesc.BackColor = Color.White;
            textBoxDesc.BorderStyle = BorderStyle.None;
            textBoxDesc.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDesc.Location = new Point(164, 134);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.ReadOnly = true;
            textBoxDesc.Size = new Size(326, 161);
            textBoxDesc.TabIndex = 8;
            textBoxDesc.Text = "ОЧЕНЬ КРУТОE ОПИСАНИЕ. ТУТ КЛАССНЕНЬКИЕ ВЕЩИ ОПИСАНЫ, Например: что я сегодня покушал, где я сегодня гулял";
            // 
            // labelManufacturer
            // 
            labelManufacturer.AutoSize = true;
            labelManufacturer.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelManufacturer.Location = new Point(164, 104);
            labelManufacturer.Name = "labelManufacturer";
            labelManufacturer.Size = new Size(137, 16);
            labelManufacturer.TabIndex = 9;
            labelManufacturer.Text = "Производитель";
            // 
            // flowLayoutPanelOrderParts
            // 
            flowLayoutPanelOrderParts.AutoScroll = true;
            flowLayoutPanelOrderParts.Dock = DockStyle.Right;
            flowLayoutPanelOrderParts.Enabled = false;
            flowLayoutPanelOrderParts.Location = new Point(838, 0);
            flowLayoutPanelOrderParts.MaximumSize = new Size(358, 298);
            flowLayoutPanelOrderParts.MinimumSize = new Size(10, 146);
            flowLayoutPanelOrderParts.Name = "flowLayoutPanelOrderParts";
            flowLayoutPanelOrderParts.Size = new Size(10, 298);
            flowLayoutPanelOrderParts.TabIndex = 7;
            // 
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(flowLayoutPanelOrderParts);
            Controls.Add(labelManufacturer);
            Controls.Add(textBoxDesc);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(labelPriority);
            Controls.Add(labelStatus);
            Controls.Add(labelOrderNumber);
            MaximumSize = new Size(980, 300);
            MinimumSize = new Size(480, 148);
            Name = "OrderView";
            Size = new Size(978, 298);
            Load += OrderView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
    }
}
