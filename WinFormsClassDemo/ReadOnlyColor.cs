using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClassDemo;
public class ReadOnlyColor
{
    public static readonly ReadOnlyColor Red = new ReadOnlyColor(255, 0, 0);
    public static readonly ReadOnlyColor Green = new ReadOnlyColor(0, 255, 0);
    public static readonly ReadOnlyColor Blue = new ReadOnlyColor(0, 0, 255);
    public static ReadOnlyColor Black { get; } = new ReadOnlyColor(0, 0, 0);

    public ReadOnlyColor(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
    }

    public virtual byte R { get; init; }
    public virtual byte G { get; init; }
    public virtual byte B { get; init; }

    // all classes automatically inherit from Object
    // which has a ToString
    // so you need to override to use it
    public override string ToString()
    {
        return $"R:{R} G:{G} B:{B}";
    }
}
