using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClassDemo.Utilities;
internal static class IntHelper
{
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // NOTE the "this" in front of the int parameter number
    // that makes IsOdd an extension function
    // which means you can call it as if it was part of an int class
    public static bool IsOdd(this int number)
    {
        return number % 2 == 1;
    }
}
