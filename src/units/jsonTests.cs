using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace units
{
    [TestClass]
    public class jsonTests
    {
        [TestMethod]
        [TestCategory("Web")]
        public void TestJSONData()
        {
            //string url = configs.configurations.endpoints.members;

            //web w = new web();
            //string members = w.get(url);

            //List<idv> list = JsonConvert.DeserializeObject<List<idv>>(members);

            members m = new members();
            List<idv> list = m.all();

            //Assert.IsTrue(list.Count > 0);
            Assert.IsTrue(list.Count == 3);
        }
    }
}
