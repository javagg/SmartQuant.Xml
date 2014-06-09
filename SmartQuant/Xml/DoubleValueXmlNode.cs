namespace SmartQuant.Xml
{
    public class DoubleValueXmlNode : ValueXmlNode
    {
        public double Value
        {
            get
            {
                return this.GetDoubleValue();
            }
            set
            {
                this.SetValue(value);
            }
        }
    
        public DoubleValueXmlNode()
        {
        }

        public double GetValue(double defaultValue)
        {
            return this.GetDoubleValue(defaultValue);
        }
    }
}
