using System;

namespace SmartQuant.Xml
{
    public class TypeValueXmlNode : ValueXmlNode
    {
        public Type Value
        {
            get
            {
                return this.GetTypeValue();
            }
            set
            {
                this.SetValue(value);
            }
        }

        public TypeValueXmlNode()
        {
        }
    }
}
