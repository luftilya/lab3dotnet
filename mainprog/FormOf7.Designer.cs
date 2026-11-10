namespace mainprog
{
    partial class FormOf7
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
            textBox = new TextBox();
            button = new Button();
            ave_label = new Label();
            SuspendLayout();
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            history_label.Location = new Point(138, 39);
            history_label.Name = "history_label";
            history_label.Size = new Size(541, 82);
            history_label.TabIndex = 0;
            history_label.Text = "Найти среднее арифметическое \r\nчётных цифр числа";
            history_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox.Location = new Point(240, 135);
            textBox.Name = "textBox";
            textBox.Size = new Size(332, 47);
            textBox.TabIndex = 1;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button.Location = new Point(285, 205);
            button.Name = "button";
            button.Size = new Size(245, 77);
            button.TabIndex = 2;
            button.Text = "найти";
            button.TextAlign = ContentAlignment.TopCenter;
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // ave_label
            // 
            ave_label.AutoSize = true;
            ave_label.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ave_label.Location = new Point(58, 309);
            ave_label.MinimumSize = new Size(700, 81);
            ave_label.Name = "ave_label";
            ave_label.Size = new Size(700, 81);
            ave_label.TabIndex = 3;
            ave_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormOf7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ave_label);
            Controls.Add(button);
            Controls.Add(textBox);
            Controls.Add(history_label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormOf7";
            Text = "Найти среднее арифметическое чётных цифр числа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label history_label;
        private TextBox textBox;
        private Button button;
        private Label ave_label;
    }
}