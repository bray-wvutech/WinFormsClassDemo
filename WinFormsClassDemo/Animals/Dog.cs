using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClassDemo.Animals;
internal class Dog : Animal
{
    public override string Speak()
    {
        return "woof";
    }

    // NOTE: we CAN but do not HAVE to implement Type
}
