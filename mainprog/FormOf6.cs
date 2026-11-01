using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mainprog;

public partial class FormOf6 : Form
{
    public FormOf6() 
        => InitializeComponent();
    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(textBox.Text)
            && double.TryParse(textBox.Text, out double step)
            && step <= 6
            && step > 0)
        {
            double sum = 0;

            for (double i = 0; i <= 6; i += step)
            {
                if (Math.Abs(i - 2) < 1e-9)
                    continue;

                double expr = 2 * Math.Pow(i - 2, 2) * (8 - i) - 1;

                if (expr < 0)
                    continue;

                double mem = Math.Sqrt(expr);

                sum += Math.Sqrt(expr);

                listBox.Items.Add("x(" + (listBox.Items.Count + 1) + ") = " + mem.ToString());
            }

            sum_label.Text = sum.ToString("F6");
        }
    }
}
