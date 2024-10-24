using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClassDemo;
public partial class ChildForm : Form
{
    // we can add properties to our form just like any other class
    // in this case an auto property for DateTime
    public DateTime DisplayDate { get; set; }

    // we can pass things into our forms constructor just like any other class
    public ChildForm(DateTime dt)
    {
        DisplayDate = dt;
        InitializeComponent();
    }

    private void ChildForm_Load(object sender, EventArgs e)
    {
        childLabel.Text = DisplayDate.ToString();
    }
}
