using System;

namespace SmartQuant.Xml
{
    public class PropertyListXmlNode : ListXmlNode<PropertyXmlNode>
    {
        public override string NodeName
        {
            get
            {
                return "properties";
            }
        }

        public PropertyXmlNode Add(string name, Type type, string value)
        {
            PropertyXmlNode node = this.AppendChildNode();
            node.Name = name;
            node.Type = type;
            node.Value = value;
            return node;
        }
    }
}
