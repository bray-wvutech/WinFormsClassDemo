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
    // it is a naming convention that we usually put an underscore before
    // private field names
    private Person _person;

    // we can pass things into our forms constructor just like any other class
    public ChildForm(Person p)
    {
        _person = p;
        InitializeComponent();
    }

    private void ChildForm_Load(object sender, EventArgs e)
    {
        nameLabel.Text = _person.Name;
        ageLabel.Text = _person.Age.ToString();
        adultCheckBox.Checked = _person.IsAdult;
        seniorCheckBox.Checked = _person.IsSeniorCitizen;
    }
}
