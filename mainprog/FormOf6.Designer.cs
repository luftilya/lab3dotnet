namespace mainprog
{
    partial class FormOf6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOf6));
            pictureBox1 = new PictureBox();
            history_label = new Label();
            textBox = new TextBox();
            step_textlabel = new Label();
            pictureBox2 = new PictureBox();
            button = new Button();
            listBox = new ListBox();
            sum_textlabel = new Label();
            sum_label = new Label();
            help_label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(235, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            history_label.Location = new Point(212, 44);
            history_label.Name = "history_label";
            history_label.Size = new Size(541, 41);
            history_label.TabIndex = 1;
            history_label.Text = "Табулирование функции на отрезке";
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox.Location = new Point(449, 201);
            textBox.Name = "textBox";
            textBox.Size = new Size(168, 47);
            textBox.TabIndex = 2;
            // 
            // step_textlabel
            // 
            step_textlabel.AutoSize = true;
            step_textlabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            step_textlabel.Location = new Point(361, 201);
            step_textlabel.Name = "step_textlabel";
            step_textlabel.Size = new Size(82, 41);
            step_textlabel.TabIndex = 3;
            step_textlabel.Text = "Шаг:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(618, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button.Location = new Point(373, 264);
            button.Name = "button";
            button.Size = new Size(235, 51);
            button.TabIndex = 5;
            button.Text = "Табулировать";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // listBox
            // 
            listBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(113, 355);
            listBox.Name = "listBox";
            listBox.Size = new Size(330, 274);
            listBox.TabIndex = 6;
            // 
            // sum_textlabel
            // 
            sum_textlabel.AutoSize = true;
            sum_textlabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            sum_textlabel.Location = new Point(517, 436);
            sum_textlabel.Name = "sum_textlabel";
            sum_textlabel.Size = new Size(445, 41);
            sum_textlabel.TabIndex = 7;
            sum_textlabel.Text = "Сумма полученных значений:";
            // 
            // sum_label
            // 
            sum_label.AutoSize = true;
            sum_label.Font = new Font("Segoe UI Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sum_label.Location = new Point(521, 513);
            sum_label.MinimumSize = new Size(450, 62);
            sum_label.Name = "sum_label";
            sum_label.Size = new Size(450, 62);
            sum_label.TabIndex = 8;
            sum_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // help_label
            // 
            help_label.AutoSize = true;
            help_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            help_label.Location = new Point(410, 167);
            help_label.Name = "help_label";
            help_label.Size = new Size(247, 31);
            help_label.TabIndex = 9;
            help_label.Text = "Шаг должен быть > 0";
            // 
            // FormOf6
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1033, 682);
            Controls.Add(help_label);
            Controls.Add(sum_label);
            Controls.Add(sum_textlabel);
            Controls.Add(listBox);
            Controls.Add(button);
            Controls.Add(pictureBox2);
            Controls.Add(step_textlabel);
            Controls.Add(textBox);
            Controls.Add(history_label);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormOf6";
            Text = "Табулирование функции";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label history_label;
        private TextBox textBox;
        private Label step_textlabel;
        private PictureBox pictureBox2;
        private Button button;
        private ListBox listBox;
        private Label sum_textlabel;
        private Label sum_label;
        private Label help_label;
    }
}