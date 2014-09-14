using System;

namespace SmartQuant.Xml
{
    public class GuidValueXmlNode : ValueXmlNode
    {
        public Guid Value
        {
            get
            {
                return this.GetGuidValue();
            }
            set
            {
                this.SetValue(value);
            }
        }

        public Guid GetValue(Guid defaultValue)
        {
            return this.GetGuidValue(defaultValue);
        }
    }
}
