﻿using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using NUnit;

namespace CSharpKatas
{
    public class Calculator
    {
        public int SumNumbers(int start, int count)
        {
            // todo #1: Remove the Ignore attribute and get all the tests passing
            // todo #2: Refactor so there are no loops or if statements (this is the functional approach and is idiomatic for C#)
            // todo #3: Refactor to use the Aggregate() LINQ method (see 101 Linq Samples: http://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b)

            int decr = 1;

            //int sum = (2*start + decr*(count-1))*count/2;

            int sum = (start + count - 1) * count / 2;

            //IEnumerable<int> arr = Enumerable.Range(start, count);//.Select(x => x++);
            //int sum = (count == 0) ? 0 : arr.Aggregate((x, y) => x + y);
            return sum;
        }
    }

    [TestFixture]

    public class Test
    {
        [Test]
        public void SumNumbers_StartAt100SumNext1_TotalIs100()
        {
            var kata = new Calculator();
            Assert.AreEqual(100, kata.SumNumbers(100, 1));
        }

        [Test]
        public void SumNumbers_StartAt100SumNext2_TotalIs201()
        {
            var kata = new Calculator();
            Assert.AreEqual(201, kata.SumNumbers(100, 2));
        }
        [Test]
        public void SumNumbers_StartAt100SumNext0_TotalIs0()
        {
            var kata = new Calculator();
            Assert.AreEqual(0, kata.SumNumbers(100, 0));
        }

        [Test]
        public void SumNumbers_StartAt0SumNext0_TotalIs0()
        {
            var kata = new Calculator();
            Assert.AreEqual(0, kata.SumNumbers(0, 0));
        }

        [Test]
        public void SumNumbers_StartAt0SumNext3_TotalIs3()
        {
            var kata = new Calculator();
            Assert.AreEqual(3, kata.SumNumbers(0, 3));
        }

        [Test]
        public void SumNumbers_StartAt0SumNext100_TotalIs5050()
        {
            var kata = new Calculator();
            Assert.AreEqual(5050, kata.SumNumbers(1, 100));
        }
    }
}