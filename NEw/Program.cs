// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace NEw
{
    internal class Program
    {
        public void First()
        {
            Console.WriteLine("bobw bow");
            Console.ReadLine();
        }
    }

    internal class Secd : Program
    {
        public void Crow()
        {
            Console.WriteLine("cow cow");
            Console.ReadLine();
        }
    }

    internal class Newc()
    {
        public static void Main(string[] args)
        {
            Secd s = new Secd();
            s.Crow();
            s.First();
        }
    }
}
