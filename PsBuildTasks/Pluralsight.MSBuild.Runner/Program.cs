using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Build.Framework;
using Pluralsight.MSBuild.Tasks;

namespace Pluralsight.MSBuild.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Add2Numbers ourAdder = new Add2Numbers();
            ourAdder.Number1 = 2;
            ourAdder.Number2 = 3;

            Console.WriteLine("Result is:" + ourAdder.Result);
            Console.ReadLine();
        }
    }
}
