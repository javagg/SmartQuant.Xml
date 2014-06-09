﻿namespace SmartQuant.Xml
{
    public class StringValueXmlNode : ValueXmlNode
    {
        public string Value
        {
            get
            {
                return this.GetStringValue();
            }
            set
            {
                this.SetValue(value);
            }
        }

        public StringValueXmlNode()
        {
        }
    }
}
