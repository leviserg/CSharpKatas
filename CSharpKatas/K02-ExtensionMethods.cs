using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CSharpKatas
{
    // todo #0: Uncomment everything (Ctrl-A, Ctrl-KU)
    // todo #1: Without modifying SomeoneElsesClass add a new class that makes the unit tests pass
    // todo #2: Refactor so that there are no loops or if statements.
    // todo #3: (see below)

    public class Program
    {
        public static void Main()
        {

            var someoneElsesClass = new SomeoneElsesClass
            {
                Numbers = new List<int> { 1, 2, 3 }
            };

            // SomeoneElsesClass someoneElsesClass = null;
            var objresult = someoneElsesClass.FindNumberOrDefault(4);
            string result = (objresult == null) ? "null" : objresult.Value.ToString();
            Console.WriteLine(result);
        }
    }


    #region DoNotModify
    // DO NOT MODIFY THIS FILE FOR THIS CLASS FOR THIS KATA
    public class SomeoneElsesClass
    {
        public List<int> Numbers { get; set; }
    }
    #endregion

    public static class ExtensionClass
    {
        public static int? FindNumberOrDefault(this SomeoneElsesClass someoneElsesClass, int num)
        {
            return someoneElsesClass?.Numbers.Select(n => (int?)n).FirstOrDefault(n => n == num);
        }
    }




    [TestFixture]
    public class TestExtensionMethods
    {
        [Test]
        public void FindNumberOrDefault_NumberExists_ReturnIt()
        {
            var someoneElsesClass = new SomeoneElsesClass
            {
                Numbers = new List<int> { 1, 2, 3 }
            };
            Assert.AreEqual(1, someoneElsesClass.FindNumberOrDefault(1));
        }

        [Test]
        public void FindNumberOrDefault_NumberDoesNotExist_ReturnNull()
        {
            var someoneElsesClass = new SomeoneElsesClass
            {
                Numbers = new List<int> { 1, 2, 3 }
            };
            var v = someoneElsesClass.FindNumberOrDefault(4);
            Assert.IsNull(v);
        }

        [Test]
        public void FindNumberOrDefault_SomeoneElsesClassIsNull_CheckForNull()
        {
            // todo #3: What's bizarre about the following test? Why is there no error? Consider reverse engineering the code with a tool like Just Decompile to get the answer.
            SomeoneElsesClass someoneElsesClass = null;
            Assert.IsNull(someoneElsesClass.FindNumberOrDefault(4));
        }
    }
}

