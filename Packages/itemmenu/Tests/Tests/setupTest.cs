using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class setupTest
    {
        setupItem help;
         int amount = 99;
        [Test]
        public void TestgetAmount()
        {
            

            int expected = amount;
            int output = help.getAmount(); 
           // CollectionAssert.AreEqual(expected, output);
        }
    }
}


