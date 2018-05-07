using UnityEngine;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using System.IO;

[XmlRoot("ItemCollection")]
public class XMLItemContainer
{

    [XmlArray("Items")]
    [XmlArrayItem("Item")]
    public List<XMLItem> items = new List<XMLItem>();

    public static XMLItemContainer Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);

        XmlSerializer _serializer = new XmlSerializer(typeof(XMLItemContainer));

        StringReader reader = new StringReader(_xml.text);

        XMLItemContainer _items = _serializer.Deserialize(reader) as XMLItemContainer;

        reader.Close();

        return _items;
    }
}
