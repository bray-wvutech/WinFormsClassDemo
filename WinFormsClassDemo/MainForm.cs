namespace WinFormsClassDemo;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        // creating a Person object with parameterized constructor
        Person p1 = new Person(0, "Steve", 22);
        // creating a Person object with default constructor and initializer
        Person p2 = new Person()
        {
            ID = 1,
            Name = "Mary",
            Age = 32
        };
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
        }
        catch
        {
            MessageBox.Show("ERROR: Not a valid person.");
        }
    }

    private void modelessButton_Click(object sender, EventArgs e)
    {
        try
        {
            // we are going to make a new person and pass it in through forms constructor
            Person p = new Person(0, nameTextBox.Text, int.Parse(ageTextBox.Text));
            ChildForm childForm = new(p);

            // modeless window - does not block input
            childForm.Show();
        }
        catch
        {
            MessageBox.Show("ERROR: Not a valid person.");
        }
    }
}
