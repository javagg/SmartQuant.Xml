namespace SmartQuant.Xml
{
    public class BooleanValueXmlNode : ValueXmlNode
    {
        public bool Value
        {
            get
            {
                return this.GetBooleanValue();
            }
            set
            {
                this.SetValue(value);
            }
        }
    
        public BooleanValueXmlNode()
        {
        }

        public bool GetValue(bool defaultValue)
        {
            return this.GetBooleanValue(defaultValue);
        }
    }
}
