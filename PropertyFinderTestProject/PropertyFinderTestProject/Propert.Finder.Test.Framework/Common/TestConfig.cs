using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace Property.Finder.Test.Framework.Common
{
    /// <summary>
    /// Test Configuraiton URLs to be configured here
    /// </summary>
    public class TestConfig
    {
        public string HomeUrl { get; private set; }
        public string PostUrl { get; }

        public TestConfig()
        {
            HomeUrl = GetDataFromTestConfiguraiton("/Config/HomeURL");
        }
        private string GetDataFromTestConfiguraiton(string node)
        {
            XmlDocument testCon = new XmlDocument();
            testCon.Load("Common\\TestConfiguration.xml");
            return testCon.SelectSingleNode(node).InnerText;
        }

    }
}
