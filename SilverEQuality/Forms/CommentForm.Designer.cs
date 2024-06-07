namespace SilverEQuality.Forms
{
    partial class CommentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentForm));
            panelHeader = new Panel();
            labelTitle = new Label();
            buttonHide = new Button();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            checkBoxSendEmail = new CheckBox();
            labelSymbolsLeft = new Label();
            buttonDone = new Button();
            textBoxComment = new TextBox();
            flowLayoutPanelComments = new FlowLayoutPanel();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(50, 50, 56);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Controls.Add(buttonHide);
            panelHeader.Controls.Add(buttonExit);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(841, 39);
            panelHeader.TabIndex = 3;
            panelHeader.MouseDown += panelHeader_MouseDown;
            panelHeader.MouseMove += panelHeader_MouseMove;
            panelHeader.MouseUp += panelHeader_MouseUp;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(56, 11);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(130, 19);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Комментарии";
            // 
            // buttonHide
            // 
            buttonHide.Dock = DockStyle.Right;
            buttonHide.FlatAppearance.BorderSize = 0;
            buttonHide.FlatStyle = FlatStyle.Flat;
            buttonHide.Font = new Font("Lucida Console", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHide.ForeColor = SystemColors.ControlLightLight;
            buttonHide.Location = new Point(772, 0);
            buttonHide.Name = "buttonHide";
            buttonHide.Size = new Size(34, 39);
            buttonHide.TabIndex = 0;
            buttonHide.Text = "_";
            buttonHide.UseVisualStyleBackColor = true;
            buttonHide.Click += buttonHide_Click;
            // 
            // buttonExit
            // 
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Lucida Console", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.ForeColor = SystemColors.ControlLightLight;
            buttonExit.Location = new Point(806, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(35, 39);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(8, 5, 10, 5);
            pictureBox1.Size = new Size(50, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxSendEmail);
            panel1.Controls.Add(labelSymbolsLeft);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(textBoxComment);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 328);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 172);
            panel1.TabIndex = 4;
            // 
            // checkBoxSendEmail
            // 
            checkBoxSendEmail.AutoSize = true;
            checkBoxSendEmail.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSendEmail.Location = new Point(243, 70);
            checkBoxSendEmail.Name = "checkBoxSendEmail";
            checkBoxSendEmail.Size = new Size(336, 23);
            checkBoxSendEmail.TabIndex = 7;
            checkBoxSendEmail.Text = "Отправить сообщение на почту";
            checkBoxSendEmail.UseVisualStyleBackColor = true;
            // 
            // labelSymbolsLeft
            // 
            labelSymbolsLeft.AutoSize = true;
            labelSymbolsLeft.BackColor = Color.Transparent;
            labelSymbolsLeft.FlatStyle = FlatStyle.Flat;
            labelSymbolsLeft.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSymbolsLeft.ForeColor = SystemColors.ControlDarkDark;
            labelSymbolsLeft.Location = new Point(769, 48);
            labelSymbolsLeft.Name = "labelSymbolsLeft";
            labelSymbolsLeft.Size = new Size(37, 16);
            labelSymbolsLeft.TabIndex = 6;
            labelSymbolsLeft.Text = "100";
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.SteelBlue;
            buttonDone.DialogResult = DialogResult.OK;
            buttonDone.FlatAppearance.BorderSize = 0;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDone.ForeColor = SystemColors.ControlLightLight;
            buttonDone.Location = new Point(226, 104);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(368, 37);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Оставить комментарий";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxComment
            // 
            textBoxComment.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxComment.Location = new Point(43, 6);
            textBoxComment.Multiline = true;
            textBoxComment.Name = "textBoxComment";
            textBoxComment.Size = new Size(763, 58);
            textBoxComment.TabIndex = 0;
            textBoxComment.TextChanged += textBoxComment_TextChanged;
            // 
            // flowLayoutPanelComments
            // 
            flowLayoutPanelComments.Dock = DockStyle.Fill;
            flowLayoutPanelComments.Location = new Point(0, 39);
            flowLayoutPanelComments.Name = "flowLayoutPanelComments";
            flowLayoutPanelComments.Size = new Size(841, 289);
            flowLayoutPanelComments.TabIndex = 5;
            // 
            // CommentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 500);
            Controls.Add(flowLayoutPanelComments);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CommentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CommentForm";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitle;
        private Button buttonHide;
        private Button buttonExit;
        private PictureBox pictureBox1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanelComments;
        private TextBox textBoxComment;
        private Label labelSymbolsLeft;
        private Button buttonDone;
        private CheckBox checkBoxSendEmail;
    }
}