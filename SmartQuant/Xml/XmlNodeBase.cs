using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace SmartQuant.Xml
{
    public abstract class XmlNodeBase
    {
        private XmlNode xmlNode;

        public abstract string NodeName { get; }

        public static implicit operator XmlNode(XmlNodeBase xmlNodeBase)
        {
            return xmlNodeBase.xmlNode;
        }

    
        internal static T cg2X6kuxg<T>(XmlNode obj0) where T : XmlNodeBase, new()
        {
            T instance = Activator.CreateInstance<T>();
            instance.xmlNode = obj0;
            return instance;
        }

    
        internal static T fpeCaawxg<T>(XmlNode obj0, string obj1) where T : ValueXmlNode, new()
        {
            T instance = Activator.CreateInstance<T>();
            instance.xmlNode = obj0;
            instance.nodeName = obj1;
            return instance;
        }

    
        protected bool ContainsAttribute(string name)
        {
            return this.xmlNode.Attributes[name] != null;
        }

    
        protected string GetStringAttribute(string name)
        {
            XmlAttribute xmlAttribute = this.xmlNode.Attributes[name];
            if (xmlAttribute != null)
                return xmlAttribute.Value;
            else
                return null;
        }

    
        protected int GetInt32Attribute(string name)
        {
            return int.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
        }

    
        protected uint GetUInt32Attribute(string name)
        {
            return uint.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
        }

    
        protected long GetInt64Attribute(string name)
        {
            return long.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
        }

    
        protected ulong GetUInt64Attribute(string name)
        {
            return ulong.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
        }

    
        protected short GetInt16Attribute(string name)
        {
            return short.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
        }

    
        protected ushort GetUInt16Attribute(string name)
        {
            return ushort.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
        }

    
        protected byte GetByteAttribute(string name)
        {
            return byte.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
        }

    
        protected sbyte GetSByteAttribute(string name)
        {
            return sbyte.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
        }

    
        protected float GetFloatAttribute(string name)
        {
            return float.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
        }

    
        protected double GetDoubleAttribute(string name)
        {
            return double.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
        }

    
        protected Decimal GetDecimalAttribute(string name)
        {
            return Decimal.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
        }

    
        protected DateTime GetDateTimeAttribute(string name)
        {
            return DateTime.Parse(this.GetStringAttribute(name), CultureInfo.InvariantCulture);
        }

    
        protected bool GetBooleanAttribute(string name)
        {
            return bool.Parse(this.GetStringAttribute(name));
        }

    
        protected object GetEnumAttribute(string name, Type type)
        {
            return Enum.Parse(type, this.GetStringAttribute(name));
        }

    
        protected Type GetTypeAttribute(string name)
        {
            return Type.GetType(this.GetStringAttribute(name));
        }

    
        protected Guid GetGuidAttribute(string name)
        {
            return new Guid(this.GetStringAttribute(name));
        }

    
        protected void SetAttribute(string name, string value)
        {
            XmlAttribute node = this.xmlNode.Attributes[name];
            if (node == null)
            {
                node = this.xmlNode.OwnerDocument.CreateAttribute(name);
                this.xmlNode.Attributes.Append(node);
            }
            node.Value = value;
        }

    
        protected void SetAttribute(string name, int value)
        {
            this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
        }

    
        protected void SetAttribute(string name, uint value)
        {
            this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
        }

    
        protected void SetAttribute(string name, long value)
        {
            this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
        }

    
        protected void SetAttribute(string name, ulong value)
        {
            this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
        }

    
        protected void SetAttribute(string name, short value)
        {
            this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
        }

    
        protected void SetAttribute(string name, ushort value)
        {
            this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
        }

    
        protected void SetAttribute(string name, byte value)
        {
            this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
        }

    
        protected void SetAttribute(string name, sbyte value)
        {
            this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
        }

    
        protected void SetAttribute(string name, float value)
        {
            this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
        }

    
        protected void SetAttribute(string name, double value)
        {
            this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
        }

    
        protected void SetAttribute(string name, Decimal value)
        {
            this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
        }

    
        protected void SetAttribute(string name, DateTime value)
        {
            this.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));
        }

    
        protected void SetAttribute(string name, bool value)
        {
            this.SetAttribute(name, value.ToString());
        }

    
        protected void SetAttribute(string name, Enum value)
        {
            this.SetAttribute(name, ((object)value).ToString());
        }

    
        protected void SetAttribute(string name, Type value)
        {
            if (value.Assembly.GlobalAssemblyCache)
                this.SetAttribute(name, value.AssemblyQualifiedName);
            else
                this.SetAttribute(name, string.Format("{0}, {1}", value.FullName, value.Assembly.GetName().Name));
        }

    
        protected void SetAttribute(string name, Guid value)
        {
            this.SetAttribute(name, value.ToString(null, CultureInfo.InvariantCulture));
        }

    
        protected string GetStringValue()
        {
            return this.xmlNode.InnerText;
        }

    
        protected int GetInt32Value()
        {
            return int.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
        }

    
        protected int GetInt32Value(int defaultValue)
        {
            int result;
            if (int.TryParse(this.GetStringValue(), NumberStyles.Integer, CultureInfo.InvariantCulture, out result))
                return result;
            else
                return defaultValue;
        }

    
        protected uint GetUInt32Value()
        {
            return uint.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
        }

    
        protected uint GetUInt32Value(uint defaultValue)
        {
            uint result;
            if (uint.TryParse(this.GetStringValue(), NumberStyles.Integer, CultureInfo.InvariantCulture, out result))
                return result;
            else
                return defaultValue;
        }

    
        protected long GetInt64Value()
        {
            return long.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
        }

    
        protected long GetInt64Value(long defaultValue)
        {
            long result;
            if (long.TryParse(this.GetStringValue(), NumberStyles.Integer, CultureInfo.InvariantCulture, out result))
                return result;
            else
                return defaultValue;
        }

    
        protected ulong GetUInt64Value()
        {
            return ulong.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
        }

    
        protected ulong GetUInt64Value(ulong defaultValue)
        {
            ulong result;
            if (ulong.TryParse(this.GetStringValue(), NumberStyles.Integer, CultureInfo.InvariantCulture, out result))
                return result;
            else
                return defaultValue;
        }

    
        protected short GetInt16Value()
        {
            return short.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
        }

    
        protected short GetInt16Value(short defaultValue)
        {
            short result;
            if (short.TryParse(this.GetStringValue(), NumberStyles.Integer, CultureInfo.InvariantCulture, out result))
                return result;
            else
                return defaultValue;
        }

    
        protected ushort GetUInt16Value()
        {
            return ushort.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
        }

    
        protected ushort GetUInt16Value(ushort defaultValue)
        {
            ushort result;
            if (ushort.TryParse(this.GetStringValue(), NumberStyles.Integer, CultureInfo.InvariantCulture, out result))
                return result;
            else
                return defaultValue;
        }

    
        protected byte GetByteValue()
        {
            return byte.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
        }

    
        protected byte GetByteValue(byte defaultValue)
        {
            byte result;
            if (byte.TryParse(this.GetStringValue(), NumberStyles.Integer, CultureInfo.InvariantCulture, out result))
                return result;
            else
                return defaultValue;
        }

    
        protected sbyte GetSByteValue()
        {
            return sbyte.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
        }

    
        protected sbyte GetSByteValue(sbyte defaultValue)
        {
            sbyte result;
            if (sbyte.TryParse(this.GetStringValue(), NumberStyles.Integer, CultureInfo.InvariantCulture, out result))
                return result;
            else
                return defaultValue;
        }

    
        protected float GetFloatValue()
        {
            return float.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
        }

    
        protected float GetFloatValue(float defaultValue)
        {
            float result;
            if (float.TryParse(this.GetStringValue(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out result))
                return result;
            else
                return defaultValue;
        }

    
        protected double GetDoubleValue()
        {
            return double.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
        }

    
        protected double GetDoubleValue(double defaultValue)
        {
            double result;
            if (double.TryParse(this.GetStringValue(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out result))
                return result;
            else
                return defaultValue;
        }

    
        protected Decimal GetDecimalValue()
        {
            return Decimal.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
        }

    
        protected Decimal GetDecimalValue(Decimal defaultValue)
        {
            Decimal result;
            if (Decimal.TryParse(this.GetStringValue(), NumberStyles.Number, CultureInfo.InvariantCulture, out result))
                return result;
            else
                return defaultValue;
        }

    
        protected DateTime GetDateTimeValue()
        {
            return DateTime.Parse(this.GetStringValue(), CultureInfo.InvariantCulture);
        }

    
        protected DateTime GetDateTimeValue(DateTime defaultValue)
        {
            DateTime result;
            if (DateTime.TryParse(this.GetStringValue(), CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
                return result;
            else
                return defaultValue;
        }

    
        protected bool GetBooleanValue()
        {
            return bool.Parse(this.GetStringValue());
        }

    
        protected bool GetBooleanValue(bool defaultValue)
        {
            bool result;
            if (bool.TryParse(this.GetStringValue(), out result))
                return result;
            else
                return defaultValue;
        }

    
        protected object GetEnumValue(Type type)
        {
            return Enum.Parse(type, this.GetStringValue());
        }

    
        protected T GetEnumValue<T>(T defaultValue) where T : struct
        {
            T result;
            if (Enum.TryParse<T>(this.GetStringValue(), out result))
                return result;
            else
                return defaultValue;
        }

    
        protected Type GetTypeValue()
        {
            return Type.GetType(this.GetStringValue());
        }

    
        protected Guid GetGuidValue()
        {
            return new Guid(this.GetStringValue());
        }

    
        protected Guid GetGuidValue(Guid defaultValue)
        {
            Guid result;
            if (Guid.TryParse(this.GetStringValue(), out result))
                return result;
            else
                return defaultValue;
        }

    
        protected void SetValue(string value)
        {
            this.xmlNode.InnerText = value;
        }

    
        protected void SetValue(int value)
        {
            this.SetValue(value.ToString());
        }

    
        protected void SetValue(uint value)
        {
            this.SetValue(value.ToString());
        }

    
        protected void SetValue(long value)
        {
            this.SetValue(value.ToString());
        }

    
        protected void SetValue(ulong value)
        {
            this.SetValue(value.ToString());
        }

    
        protected void SetValue(short value)
        {
            this.SetValue(value.ToString());
        }

    
        protected void SetValue(ushort value)
        {
            this.SetValue(value.ToString());
        }

    
        protected void SetValue(byte value)
        {
            this.SetValue(value.ToString());
        }

    
        protected void SetValue(sbyte value)
        {
            this.SetValue(value.ToString());
        }

    
        protected void SetValue(double value)
        {
            this.SetValue(value.ToString(CultureInfo.InvariantCulture));
        }

    
        protected void SetValue(float value)
        {
            this.SetValue(value.ToString(CultureInfo.InvariantCulture));
        }

    
        protected void SetValue(Decimal value)
        {
            this.SetValue(value.ToString(CultureInfo.InvariantCulture));
        }

    
        protected void SetValue(DateTime value)
        {
            this.SetValue(value.ToString(CultureInfo.InvariantCulture));
        }

    
        protected void SetValue(bool value)
        {
            this.SetValue(value.ToString());
        }

    
        protected void SetValue(Enum value)
        {
            this.SetValue(((object)value).ToString());
        }

    
        protected void SetValue(Type value)
        {
            if (value.Assembly.GlobalAssemblyCache)
                this.SetValue(value.AssemblyQualifiedName);
            else
                this.SetValue(string.Format("{0}, {1}", value.FullName, value.Assembly.GetName().Name));
        }

    
        protected void SetValue(Guid value)
        {
            this.SetValue(value.ToString(null, CultureInfo.InvariantCulture));
        }

    
        protected List<T> GetChildNodes<T>() where T : XmlNodeBase, new()
        {
            string nodeName = Activator.CreateInstance<T>().NodeName;
            List<T> list = new List<T>();
            foreach (XmlNode xmlNode in this.xmlNode)
            {
                if (xmlNode.Name == nodeName)
                    list.Add(XmlNodeBase.cg2X6kuxg<T>(xmlNode));
            }
            return list;
        }

    
        protected T GetChildNode<T>() where T : XmlNodeBase, new()
        {
            string nodeName = Activator.CreateInstance<T>().NodeName;
            foreach (XmlNode xmlNode in this.xmlNode)
            {
                if (xmlNode.Name == nodeName)
                    return XmlNodeBase.cg2X6kuxg<T>(xmlNode);
            }
            return this.AppendChildNode<T>();
        }

    
        protected T GetChildNode<T>(string name) where T : ValueXmlNode, new()
        {
            foreach (XmlNode xmlNode in this.xmlNode)
            {
                if (xmlNode.Name == name)
                    return XmlNodeBase.fpeCaawxg<T>(xmlNode, name);
            }
            return this.AppendChildNode<T>(name);
        }

    
        protected T AppendChildNode<T>() where T : XmlNodeBase, new()
        {
            T obj = XmlNodeBase.cg2X6kuxg<T>((XmlNode)this.xmlNode.OwnerDocument.CreateElement(Activator.CreateInstance<T>().NodeName));
            this.xmlNode.AppendChild((XmlNode)((XmlNodeBase)obj));
            return obj;
        }

    
        protected T AppendChildNode<T>(string name) where T : ValueXmlNode, new()
        {
            T obj = XmlNodeBase.cg2X6kuxg<T>((XmlNode)this.xmlNode.OwnerDocument.CreateElement(name));
            this.xmlNode.AppendChild((XmlNode)((XmlNodeBase)obj));
            return obj;
        }

    
        protected StringValueXmlNode GetStringValueNode(string name)
        {
            return this.GetChildNode<StringValueXmlNode>(name);
        }

    
        protected BooleanValueXmlNode GetBooleanValueNode(string name)
        {
            return this.GetChildNode<BooleanValueXmlNode>(name);
        }

    
        protected ByteValueXmlNode GetByteValueNode(string name)
        {
            return this.GetChildNode<ByteValueXmlNode>(name);
        }

    
        protected DateTimeValueXmlNode GetDateTimeValueNode(string name)
        {
            return this.GetChildNode<DateTimeValueXmlNode>(name);
        }

    
        protected DecimalValueXmlNode GetDecimalValueNode(string name)
        {
            return this.GetChildNode<DecimalValueXmlNode>(name);
        }

    
        protected DoubleValueXmlNode GetDoubleValueNode(string name)
        {
            return this.GetChildNode<DoubleValueXmlNode>(name);
        }

    
        protected FloatValueXmlNode GetFloatValueNode(string name)
        {
            return this.GetChildNode<FloatValueXmlNode>(name);
        }

    
        protected GuidValueXmlNode GetGuidValueNode(string name)
        {
            return this.GetChildNode<GuidValueXmlNode>(name);
        }

    
        protected Int16ValueXmlNode GetInt16ValueNode(string name)
        {
            return this.GetChildNode<Int16ValueXmlNode>(name);
        }

    
        protected Int32ValueXmlNode GetInt32ValueNode(string name)
        {
            return this.GetChildNode<Int32ValueXmlNode>(name);
        }

    
        protected Int64ValueXmlNode GetInt64ValueNode(string name)
        {
            return this.GetChildNode<Int64ValueXmlNode>(name);
        }

    
        protected TypeValueXmlNode GetTypeValueNode(string name)
        {
            return this.GetChildNode<TypeValueXmlNode>(name);
        }

    
        protected EnumValueXmlNode<T> GetEnumValueXmlNode<T>(string name) where T : struct
        {
            return this.GetChildNode<EnumValueXmlNode<T>>(name);
        }
    }
}
