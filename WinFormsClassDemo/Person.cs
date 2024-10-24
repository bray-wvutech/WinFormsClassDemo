using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClassDemo;
public class Person
{
    public Person()
    {
        CreatedCount++;
    }

    // lets go ahead and add some parameters to our constructor
    public Person(int id, string name, int age)
    {
        // these call the setters for the properties below
        ID = id;
        Name = name;
        Age = age;
        // static property
        CreatedCount++;
    }

    // this is an automatic property for Name
    // that gets and sets it just like it was a string field	
    // notice we are also allowed to initialize the value
    // here we are initializing to empty string but it could be "John Doe", etc.
    public string Name { get; set; } = "";

    // this is an example of a private backing field
    // which we will use in the Age property below
    private int _age;

    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            // value is what the property was set to
            // so: Age = value
            _age = value;
            // we can anything else we want
            // like setting another property
            IsSeniorCitizen = _age > 65;
        }
    }

    // this is an example of a read only property
    // NOTE there is not set
    public bool IsAdult
    {
        get
        {
            return _age > 17;
        }
    }

    // private get/set
    // usually you will see this as a regular get and a private set
    // so the property is read only outside of the class but can be set internally
    public bool IsSeniorCitizen { get; private set; }

    // init
    // usually you will see this as a regular get and an init
    // so the property is read only outside of the class and can only be set
    // when initializing the class
    // this is useful for things you want to be immutable
    // for example an ID of some kind read from a database
    public int ID { get; init; }

    // a static property used to keep track of how many Person objects
    // have been created
    public static int CreatedCount { get; private set; } = 0;
}
