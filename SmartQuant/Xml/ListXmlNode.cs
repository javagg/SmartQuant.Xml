using System.Collections;

namespace SmartQuant.Xml
{
    public abstract class ListXmlNode<T> : XmlNodeBase, IEnumerable where T : XmlNodeBase, new()
    {
        protected ListXmlNode()
        {
        }

        protected T AppendChildNode()
        {
            return base.AppendChildNode<T>();
        }
           
        public IEnumerator GetEnumerator()
        {
            return this.GetChildNodes<T>().GetEnumerator();
        }
    }
}
