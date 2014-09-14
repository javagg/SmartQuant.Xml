using System;

namespace SmartQuant.Xml
{
    public class DateTimeValueXmlNode : ValueXmlNode
    {
        public DateTime Value
        {
            get
            {
                return this.GetDateTimeValue();
            }
            set
            {
                this.SetValue(value);
            }
        }

        public DateTime GetValue(DateTime defaultValue)
        {
            return this.GetDateTimeValue(defaultValue);
        }
    }
}
