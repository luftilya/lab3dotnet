namespace mainprog
{
    partial class FormOf8
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
            history_label = new Label();
            n_textlabel = new Label();
            textBox = new TextBox();
            button = new Button();
            sum_label = new Label();
            help_label = new Label();
            SuspendLayout();
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            history_label.Location = new Point(71, 27);
            history_label.Name = "history_label";
            history_label.Size = new Size(680, 124);
            history_label.TabIndex = 0;
            history_label.Text = "Найти сумму факториалов\r\n1! + 2! + 3! + ... + N!";
            history_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // n_textlabel
            // 
            n_textlabel.AutoSize = true;
            n_textlabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            n_textlabel.Location = new Point(250, 193);
            n_textlabel.Name = "n_textlabel";
            n_textlabel.Size = new Size(77, 62);
            n_textlabel.TabIndex = 1;
            n_textlabel.Text = "N:";
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox.Location = new Point(316, 193);
            textBox.Name = "textBox";
            textBox.Size = new Size(181, 70);
            textBox.TabIndex = 2;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button.Location = new Point(316, 269);
            button.Name = "button";
            button.Size = new Size(181, 60);
            button.TabIndex = 3;
            button.Text = "найти";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // sum_label
            // 
            sum_label.AutoSize = true;
            sum_label.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            sum_label.Location = new Point(56, 363);
            sum_label.MinimumSize = new Size(700, 62);
            sum_label.Name = "sum_label";
            sum_label.Size = new Size(700, 62);
            sum_label.TabIndex = 4;
            sum_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // help_label
            // 
            help_label.AutoSize = true;
            help_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            help_label.Location = new Point(250, 159);
            help_label.Name = "help_label";
            help_label.Size = new Size(290, 31);
            help_label.TabIndex = 5;
            help_label.Text = "N является натуральным";
            // 
            // FormOf8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(help_label);
            Controls.Add(sum_label);
            Controls.Add(button);
            Controls.Add(textBox);
            Controls.Add(n_textlabel);
            Controls.Add(history_label);
            Name = "FormOf8";
            Text = "Найти сумму факториалов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label history_label;
        private Label n_textlabel;
        private TextBox textBox;
        private Button button;
        private Label sum_label;
        private Label help_label;
    }
}