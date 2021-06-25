using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitDemoConsole;
using NUnit.Framework;


namespace NUnitDemo
{
    [TestFixture]
    public class Class1
    {

        Fibonacci fObj = null;

        public Class1()
        {

            fObj = new Fibonacci();

        }

        [Test]
        public void FibonacciPass()
        {
            List<int> ExpectedResult = new List<int>();
            var result = fObj.GetFibonacci(1);
            ExpectedResult.Add(0);
            ExpectedResult.Add(1);
            ExpectedResult.Add(1);
            CollectionAssert.AreEqual(ExpectedResult, result);
        }
        [Test]
        public void FibonacciFail()
        {
            List<int> ExpectedResult = new List<int>();
            var result = fObj.GetFibonacci(1);
            ExpectedResult.Add(0);
            ExpectedResult.Add(1);
            ExpectedResult.Add(1);
            ExpectedResult.Add(2);
            CollectionAssert.AreEqual(ExpectedResult, result);
        }
    }
}
    

