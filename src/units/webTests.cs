using configs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.Tests
{
    [TestClass()]
    public class webTests
    {
        [TestMethod()]
        [TestCategory("Web")]
        public void getTest()
        {
            web w = new web();
            string members_url = (new endpoints()).members;
            string t = w.get(members_url);

            Assert.IsTrue(t.Contains("id"));
            Assert.IsTrue(t.Contains("name"));
            Assert.IsTrue(t.Contains("value"));
        }
    }
}