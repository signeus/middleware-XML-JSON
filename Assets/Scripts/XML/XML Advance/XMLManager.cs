using System.Collections.Generic;
using UnityEngine;

using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class XMLManager : MonoBehaviour {

    public static XMLManager instance;

    private void Awake()
    {
        instance = this;
    }

    //List of items
    public ItemDatabase itemDB;

}

[System.Serializable]
    public class ItemEntry
    {
        public string itemName;
        public Material material;
        public int value;
    }

    [System.Serializable]
    public class ItemDatabase
    {
        public List<ItemEntry> list = new List<ItemEntry>();
    }

    public enum Material
    {
        Wood,
        Copper,
        Iron,
        Steel,
        Obsidian
    }
