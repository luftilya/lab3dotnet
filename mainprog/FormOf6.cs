using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using wonderful_numbers_tools;

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
            listBox.Items.Clear();
            sum_label.Text = NumbersTools.TabulateFunc(step, listBox).ToString("F6");
        }
    }
}
