using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace EntityFrameworkDemo.Utils
{
    public class XmlReader
    {
        public static string GetConnString(string contextName)
        {
            var xml = XDocument.Load(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/app.config");
            if (xml.Root != null)
            {
                var connStringElements = xml.Root.Descendants("connectionStrings").Descendants("add");
                foreach (var connElement in connStringElements)
                {
                    if(connElement.Attribute("name").Value == contextName)
                    {
                        return connElement.Attribute("connectionString").Value;
                    }
                }
            }
            return null;
        }
    }
}
