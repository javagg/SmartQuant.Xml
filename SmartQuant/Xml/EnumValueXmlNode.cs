namespace SmartQuant.Xml
{
    public class EnumValueXmlNode<T> : ValueXmlNode where T : struct
    {
        public T Value
        {
            get
            {
                return (T)this.GetEnumValue(typeof(T));
            }
            set
            {
                this.SetValue(value.ToString());
            }
        }

        public T GetValue(T defaultValue)
        {
            return this.GetEnumValue<T>(defaultValue);
        }
    }
}
