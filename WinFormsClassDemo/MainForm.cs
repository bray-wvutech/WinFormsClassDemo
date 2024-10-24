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
        // we are passing date from DateTimePicker into constructor
        ChildForm childForm = new(mainDateTimePicker.Value);

        // note we can also set the date through the forms property we added
        //childForm.DisplayDate = new DateTime(2032, 11, 1);

        // modal window - blocks input
        childForm.ShowDialog(); 
    }

    private void modelessButton_Click(object sender, EventArgs e)
    {
        // we are passing date from DateTimePicker into constructor
        ChildForm childForm = new(mainDateTimePicker.Value);

        // note we can also set the date through the forms property we added
        //childForm.DisplayDate = DateTime.Now.AddDays(7);

        // modeless window - does not block
        childForm.Show();
    }
}
