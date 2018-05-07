using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class XMLItem {

    [XmlAttribute("name")]
    public string name;

    [XmlElement("damage")]
    public float damage;

    [XmlElement("durability")]
    public float durability;
}
