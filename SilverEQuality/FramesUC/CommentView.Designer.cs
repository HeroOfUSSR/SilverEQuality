namespace SilverEQuality.FramesUC
{
    partial class CommentView
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
            labelAuthorName = new Label();
            pictureBoxAuthor = new PictureBox();
            panel2 = new Panel();
            labelCommentTitle = new Label();
            textBoxComment = new TextBox();
            labelDateCom = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAuthor).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelAuthorName);
            panel1.Controls.Add(pictureBoxAuthor);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 148);
            panel1.TabIndex = 0;
            // 
            // labelAuthorName
            // 
            labelAuthorName.AutoSize = true;
            labelAuthorName.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAuthorName.Location = new Point(18, 126);
            labelAuthorName.Name = "labelAuthorName";
            labelAuthorName.Size = new Size(117, 16);
            labelAuthorName.TabIndex = 3;
            labelAuthorName.Text = "Иванов А.А.";
            // 
            // pictureBoxAuthor
            // 
            pictureBoxAuthor.Dock = DockStyle.Top;
            pictureBoxAuthor.Image = Properties.Resources.profileMain;
            pictureBoxAuthor.Location = new Point(0, 0);
            pictureBoxAuthor.Margin = new Padding(10);
            pictureBoxAuthor.Name = "pictureBoxAuthor";
            pictureBoxAuthor.Padding = new Padding(25, 10, 25, 10);
            pictureBoxAuthor.Size = new Size(153, 116);
            pictureBoxAuthor.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAuthor.TabIndex = 0;
            pictureBoxAuthor.TabStop = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(715, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(85, 148);
            panel2.TabIndex = 1;
            // 
            // labelCommentTitle
            // 
            labelCommentTitle.AutoSize = true;
            labelCommentTitle.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCommentTitle.Location = new Point(174, 11);
            labelCommentTitle.Name = "labelCommentTitle";
            labelCommentTitle.Size = new Size(251, 19);
            labelCommentTitle.TabIndex = 2;
            labelCommentTitle.Text = "Комментарий к заказу №";
            // 
            // textBoxComment
            // 
            textBoxComment.BackColor = Color.White;
            textBoxComment.BorderStyle = BorderStyle.None;
            textBoxComment.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxComment.Location = new Point(173, 36);
            textBoxComment.Multiline = true;
            textBoxComment.Name = "textBoxComment";
            textBoxComment.ReadOnly = true;
            textBoxComment.Size = new Size(525, 80);
            textBoxComment.TabIndex = 3;
            textBoxComment.Text = "ОЧЕНЬ КРУТОЙ КОММЕНТАРИЙ. ВАШЕ МНЕНИЕ НАМ ОЧЕНЬ ВАЖНО, СПАСИБО ЗА ОБРАЩЕНИЕ";
            // 
            // labelDateCom
            // 
            labelDateCom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDateCom.AutoSize = true;
            labelDateCom.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDateCom.Location = new Point(582, 126);
            labelDateCom.Name = "labelDateCom";
            labelDateCom.Size = new Size(127, 16);
            labelDateCom.TabIndex = 4;
            labelDateCom.Text = "25 июня 2023";
            // 
            // CommentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelDateCom);
            Controls.Add(textBoxComment);
            Controls.Add(labelCommentTitle);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 150);
            Name = "CommentView";
            Size = new Size(800, 148);
            Load += CommentView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAuthor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxAuthor;
        private Panel panel2;
        private Label labelCommentTitle;
        private TextBox textBoxComment;
        private Label labelDateCom;
        private Label labelAuthorName;
    }
}
