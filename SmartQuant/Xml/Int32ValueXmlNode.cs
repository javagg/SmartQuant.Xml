namespace SmartQuant.Xml
{
    public class Int32ValueXmlNode : ValueXmlNode
    {
        public int Value
        {
            get
            {
                return this.GetInt32Value();
            }
            set
            {
                this.SetValue(value);
            }
        }

        public int GetValue(int defaultValue)
        {
            return this.GetInt32Value(defaultValue);
        }
    }
}
