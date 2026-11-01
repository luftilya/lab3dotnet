using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mainprog;

public partial class FormOf5 : Form
{
    public FormOf5() 
        => InitializeComponent();
    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(textBox.Text) 
            && double.TryParse(textBox.Text, out double eps)
            && eps > 0)
        {
            double sum = 0, 
                mem = 1, 
                
                f = 1;
            int n = 2;

            while (mem >= eps)
                sum += mem = 1.0 / Math.Sqrt(f *= n++);

            sum_label.Text = sum.ToString();
        }
    }
}
