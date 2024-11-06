using System.Diagnostics;
using WinFormsClassDemo.Animals;
using WinFormsClassDemo.Interfaces;
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
        listBox1.Items.Add(new Person(0, "person 4", 12));
        listBox1.Items.Add(new Person(0, "person 5", 21));
        listBox1.Items.Add(new Person(0, "person 3", 89));
        listBox1.Items.Add(new Person(0, "person 1", 67));
        listBox1.Items.Add(new Person(0, "person 2", 32));
    }

    private void showButton_Click(object sender, EventArgs e)
    {
        try
        {
            // we are going to make a new person and pass it in through forms constructor
            Person p = new Person(0, nameTextBox.Text, int.Parse(ageTextBox.Text));
            childForm = new(p);

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

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Person p = (Person)listBox1.SelectedItem;
        staticTestLabel.Text = p.Age.ToString();
    }

    private void animalButton_Click(object sender, EventArgs e)
    {
        // NOTE the using statement at the top that imports the animal classes
        List<Animal> animals = new List<Animal>();

        // trying to add a new Animal will give you an error
        // because you can't instantiate an abstract class
        // animals.Add(new Animal());

        animals.Add(new Cat());
        animals.Add(new Dog());

        foreach (Animal animal in animals)
        {
            MessageBox.Show($"The {animal.Type} says {animal.Speak()}");
        }
    }

    private void InterfaceParamTest(ILogger logger)
    {
        logger.Log("this is a test");
    }

    private void interfaceButton_Click(object sender, EventArgs e)
    {
        ILogger logger = new TraceLogger();
        InterfaceParamTest(logger);
    }

    private void interface2Button_Click(object sender, EventArgs e)
    {
        ILogger logger = new MessageBoxLogger();
        InterfaceParamTest(logger);
    }
}
