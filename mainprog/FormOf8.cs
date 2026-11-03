using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using wonderful_numbers_tools;

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
            sum_label.Text = NumbersTools.SumFacts(n).ToString();
    }
}
