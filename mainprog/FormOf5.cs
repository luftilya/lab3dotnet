using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using wonderful_numbers_tools;

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
            sum_label.Text = NumbersTools.FindRowSum(eps).ToString();
    }
}
