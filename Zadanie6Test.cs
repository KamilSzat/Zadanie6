using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie51
{
    [TestClass]
    public class Zadanie6Test
    {
        [TestMethod]

        public void CountOccurrences_ElementExistsMultipleTimes()
        {
            var z = new Zadanie6();
            Assert.AreEqual(3, z.CountOccurrences(new[] { 1, 2, 2, 2, 3 }, 2));
        }

        [TestMethod]
        public void CountOccurrences_ElementDoesNotExist()
        {
            var z = new Zadanie6();
            Assert.AreEqual(3, z.CountOccurrences(new[] { 1, 2, 3 }, 5));
        }
    }
}
