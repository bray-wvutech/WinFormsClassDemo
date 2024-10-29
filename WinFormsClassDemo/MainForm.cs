using WinFormsClassDemo.Utilities;

namespace WinFormsClassDemo;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
    }

    private void showButton_Click(object sender, EventArgs e)
    {
        try
        {
            // we are going to make a new person and pass it in through forms constructor
            Person p = new Person(0, nameTextBox.Text, int.Parse(ageTextBox.Text));
            ChildForm childForm = new(p);

            // modal window - blocks input
            childForm.ShowDialog();

            staticTestLabel.Text = $"Person created: {Person.CreatedCount}";
        }
        catch
        {
            MessageBox.Show("ERROR: Not a valid person.");
        }
    }

    private ChildForm childForm;

    private void modelessButton_Click(object sender, EventArgs e)
    {
        try
        {
           // we are going to make a new person with an initalizer
           Person p = new Person()
           {
               ID = 1,
               Name = nameTextBox.Text,
               Age = int.Parse(ageTextBox.Text)
           };

            if ((childForm == null) || !childForm.Visible)
            {
                childForm = new(p);

                // modeless window - does not block input
                childForm.Show();
            }

            staticTestLabel.Text = $"Person created: {Person.CreatedCount}";
        }
        catch
        {
            MessageBox.Show("ERROR: Not a valid person.");
        }
    }

    private void ageTextBox_TextChanged(object sender, EventArgs e)
    {
        int age;
        if (int.TryParse(ageTextBox.Text, out age))
        {
            // static IntHelper class used like a library of utility functions
            evenCheckBox.Checked = IntHelper.IsEven(age);
            // extension method from static IntHelper class
            // that looks like it is a built-in int function
            oddCheckBox.Checked = age.IsOdd();
        }
    }

    private void colorButton_Click(object sender, EventArgs e)
    {
        ReadOnlyColor myColor = new(255, 255, 255); // white
        MessageBox.Show(myColor.ToString());

        myColor = ReadOnlyColor.Black;
        MessageBox.Show(myColor.ToString());

        myColor = ReadOnlyColor.Blue;
        MessageBox.Show(myColor.ToString());
    }
}
