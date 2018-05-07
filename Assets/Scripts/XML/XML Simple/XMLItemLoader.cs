using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XMLItemLoader : MonoBehaviour {

    public const string path = "xmlItems";
    
	void Start () {
        XMLItemContainer _ic = XMLItemContainer.Load(path);

        // This is the simple version, in the Editor you can check the Advance version.
        print("Simple version");
        foreach(XMLItem item in _ic.items)
        {
            print(item.name);
        }
	}
	
}
