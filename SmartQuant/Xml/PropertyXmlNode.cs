using System;

namespace SmartQuant.Xml
{
    public class PropertyXmlNode : XmlNodeBase
    {
        private const string F3jtR3HrU = "name";
        private const string no6OoCty6 = "type";

        public override string NodeName
        {
            get
            {
                return Vau4EkONyhQVGwxidg.hrqvXeKlE(64);
            }
        }

        public string Name
        {
            get
            {
                return this.GetStringAttribute(Vau4EkONyhQVGwxidg.hrqvXeKlE(84));
            }
            set
            {
                this.SetAttribute(Vau4EkONyhQVGwxidg.hrqvXeKlE(96), value);
            }
        }

        public Type Type
        {
            get
            {
                return this.GetTypeAttribute(Vau4EkONyhQVGwxidg.hrqvXeKlE(108));
            }
            set
            {
                this.SetAttribute(Vau4EkONyhQVGwxidg.hrqvXeKlE(120), value);
            }
        }

        public string Value
        {
            get
            {
                return this.GetStringValue();
            }
            set
            {
                this.SetValue(value);
            }
        }

        public PropertyXmlNode()
        {
        }
    }
}
