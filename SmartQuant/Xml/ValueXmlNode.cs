namespace SmartQuant.Xml
{
    public class ValueXmlNode : XmlNodeBase
    {
        internal string nodeName;

        public override sealed string NodeName
        {
            get
            {
                return this.nodeName;
            }
        }
    }
}
