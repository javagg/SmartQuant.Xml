using System;

namespace SmartQuant.Xml
{
	public class PropertyXmlNode : XmlNodeBase
	{
		private const string NAME_ATTRIBUTE = "name";
		private const string TYPE_ATTRIBUTE = "type";

		public override string NodeName {
			get {
				return "NodeName";
			}
		}

		public string Name {
			get {
				return this.GetStringAttribute (NAME_ATTRIBUTE);
			}
			set {
				this.SetAttribute (NAME_ATTRIBUTE, value);
			}
		}

		public Type Type {
			get {
				return this.GetTypeAttribute (TYPE_ATTRIBUTE);
			}
			set {
				this.SetAttribute (TYPE_ATTRIBUTE, value);
			}
		}

		public string Value {
			get {
				return this.GetStringValue ();
			}
			set {
				this.SetValue (value);
			}
		}

		public PropertyXmlNode ()
		{
		}
	}
}
