using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClassDemo.Animals;
internal class Cat : Animal
{
    public override string Speak() => "meow";

    public override string Type => "cat";
}
