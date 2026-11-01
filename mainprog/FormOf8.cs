using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mainprog;

public partial class FormOf8 : Form
{
    public FormOf8() 
        => InitializeComponent();

    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(textBox.Text)
            && int.TryParse(textBox.Text, out int n)
            && n > 0)
        {
            int sum = 0, mem = 1;

            for (int i = 1; i <= n; i++)
                sum += mem *= i;

            sum_label.Text = sum.ToString();
        }
    }
}
