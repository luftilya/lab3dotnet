using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mainprog;

public partial class FormOf7 : Form
{
    public FormOf7() 
        => InitializeComponent();
    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(textBox.Text))
        {
            var digits = new List<int>();

            foreach (var digit in textBox.Text)
                if (char.IsDigit(digit)
                    && digit % 2 == 0)
                    digits.Add(digit);

            ave_label.Text = digits.Average().ToString();
        }
    }
}
