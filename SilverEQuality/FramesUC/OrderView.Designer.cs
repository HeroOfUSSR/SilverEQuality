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
            button = new Button();
            buttonEdit = new Button();
            buttonImageMan = new Button();
            openFileDialogImageChange = new OpenFileDialog();
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
            pictureBoxAvatar.Size = new Size(171, 134);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar.TabIndex = 0;
            pictureBoxAvatar.TabStop = false;
            // 
            // labelOrderNumber
            // 
            labelOrderNumber.AutoSize = true;
            labelOrderNumber.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelOrderNumber.Location = new Point(177, 15);
            labelOrderNumber.Name = "labelOrderNumber";
            labelOrderNumber.Size = new Size(86, 19);
            labelOrderNumber.TabIndex = 1;
            labelOrderNumber.Text = "Заказ №";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatus.Location = new Point(177, 118);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(67, 16);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Статус";
            // 
            // labelPriority
            // 
            labelPriority.AutoSize = true;
            labelPriority.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPriority.Location = new Point(177, 102);
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
            buttonMore.Location = new Point(0, 110);
            buttonMore.Name = "buttonMore";
            buttonMore.Size = new Size(115, 36);
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
            panel1.Location = new Point(363, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(115, 146);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(button);
            panel2.Controls.Add(buttonEdit);
            panel2.Controls.Add(buttonImageMan);
            panel2.Controls.Add(pictureBoxAvatar);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 146);
            panel2.TabIndex = 6;
            // 
            // button
            // 
            button.BackColor = Color.SteelBlue;
            button.Dock = DockStyle.Top;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button.ForeColor = SystemColors.ControlLightLight;
            button.Location = new Point(0, 206);
            button.Name = "button";
            button.Size = new Size(171, 36);
            button.TabIndex = 7;
            button.Text = "Изменить";
            button.UseVisualStyleBackColor = false;
            button.Visible = false;
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
            buttonEdit.Size = new Size(171, 36);
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
            buttonImageMan.Size = new Size(171, 36);
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
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(labelPriority);
            Controls.Add(labelStatus);
            Controls.Add(labelOrderNumber);
            MaximumSize = new Size(980, 300);
            MinimumSize = new Size(480, 148);
            Name = "OrderView";
            Size = new Size(478, 146);
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
        private Button button;
        private Button buttonEdit;
    }
}
