﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClassDemo.Animals;
public abstract class Animal
{
    public abstract string Speak();

    public virtual string Type { get; } = "animal";
}
