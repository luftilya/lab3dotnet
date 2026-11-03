using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using wonderful_numbers_tools;

namespace mainprog;

public partial class FormOf7 : Form
{
    public FormOf7() 
        => InitializeComponent();
    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(textBox.Text))
            ave_label.Text = NumbersTools.AverangeEvenNumbers(textBox.Text).ToString();
    }
}
