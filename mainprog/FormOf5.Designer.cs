namespace mainprog
{
    partial class FormOf5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOf5));
            pictureBox = new PictureBox();
            history1_label = new Label();
            history2_label = new Label();
            textBox = new TextBox();
            eps_textlabel = new Label();
            button = new Button();
            sum_textlabel = new Label();
            sum_label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(191, 53);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(424, 177);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // history1_label
            // 
            history1_label.AutoSize = true;
            history1_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            history1_label.Location = new Point(170, 41);
            history1_label.Name = "history1_label";
            history1_label.Size = new Size(468, 41);
            history1_label.TabIndex = 1;
            history1_label.Text = "Найти сумму бесконечного ряда";
            // 
            // history2_label
            // 
            history2_label.AutoSize = true;
            history2_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            history2_label.Location = new Point(78, 200);
            history2_label.Name = "history2_label";
            history2_label.Size = new Size(675, 82);
            history2_label.TabIndex = 2;
            history2_label.Text = "Суммировать до тех про, пока \r\nчлены ряда не станут меньше заданного eps>0.";
            history2_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox.Location = new Point(200, 298);
            textBox.Name = "textBox";
            textBox.Size = new Size(81, 47);
            textBox.TabIndex = 3;
            // 
            // eps_textlabel
            // 
            eps_textlabel.AutoSize = true;
            eps_textlabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            eps_textlabel.Location = new Point(122, 298);
            eps_textlabel.Name = "eps_textlabel";
            eps_textlabel.Size = new Size(72, 41);
            eps_textlabel.TabIndex = 4;
            eps_textlabel.Text = "eps:";
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button.Location = new Point(92, 351);
            button.Name = "button";
            button.Size = new Size(218, 52);
            button.TabIndex = 5;
            button.Text = "Суммировать";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // sum_textlabel
            // 
            sum_textlabel.AutoSize = true;
            sum_textlabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sum_textlabel.Location = new Point(331, 298);
            sum_textlabel.Name = "sum_textlabel";
            sum_textlabel.Size = new Size(134, 41);
            sum_textlabel.TabIndex = 6;
            sum_textlabel.Text = "СУММА:";
            // 
            // sum_label
            // 
            sum_label.AutoSize = true;
            sum_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sum_label.Location = new Point(471, 298);
            sum_label.Name = "sum_label";
            sum_label.Size = new Size(299, 41);
            sum_label.TabIndex = 7;
            sum_label.Text = "Не проссумировано";
            // 
            // FormOf5
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(sum_label);
            Controls.Add(sum_textlabel);
            Controls.Add(button);
            Controls.Add(eps_textlabel);
            Controls.Add(textBox);
            Controls.Add(history2_label);
            Controls.Add(history1_label);
            Controls.Add(pictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormOf5";
            RightToLeft = RightToLeft.No;
            Text = "Найти сумму бесконечного ряда";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label history1_label;
        private Label history2_label;
        private TextBox textBox;
        private Label eps_textlabel;
        private Button button;
        private Label sum_textlabel;
        private Label sum_label;
    }
}