using System;

namespace SmartQuant.Xml
{
    public class PropertyListXmlNode : ListXmlNode<PropertyXmlNode>
    {
        public override string NodeName
        {
            get
            {
                return Vau4EkONyhQVGwxidg.hrqvXeKlE(40);
            }
        }

        public PropertyListXmlNode()
        {
        }

        public PropertyXmlNode Add(string name, Type type, string value)
        {
            PropertyXmlNode propertyXmlNode = this.AppendChildNode();
            propertyXmlNode.Name = name;
            propertyXmlNode.Type = type;
            propertyXmlNode.Value = value;
            return propertyXmlNode;
        }
    }
}
