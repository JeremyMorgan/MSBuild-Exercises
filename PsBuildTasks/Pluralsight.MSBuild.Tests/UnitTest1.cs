using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pluralsight.MSBuild;
using Pluralsight.MSBuild.Tasks;


namespace Pluralsight.MSBuild.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Add2Numbers ourAdder = new Add2Numbers();

            ourAdder.Number1 = 3;
            ourAdder.Number2 = 3;

            double expected = 6;
            
            Debug.WriteLine("Result: " + ourAdder.Result);

            Assert.AreEqual(ourAdder.Result, expected);

        }
    }
}
