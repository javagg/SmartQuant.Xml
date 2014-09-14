namespace SmartQuant.Xml
{
    public class Int64ValueXmlNode : ValueXmlNode
    {
        public long Value
        {
            get
            {
                return this.GetInt64Value();
            }
            set
            {
                this.SetValue(value);
            }
        }

        public long GetValue(long defaultValue)
        {
            return this.GetInt64Value(defaultValue);
        }
    }
}
