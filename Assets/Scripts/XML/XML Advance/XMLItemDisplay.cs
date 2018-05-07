using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XMLItemDisplay : MonoBehaviour {
    
    public XMLItemBlock blockPrefab;

	void Start () {
        Display();		
	}
	
	public void Display () {
		foreach(ItemEntry item in XMLManager.instance.itemDB.list)
        {
            XMLItemBlock newBlock = Instantiate(blockPrefab) as XMLItemBlock;
            newBlock.transform.SetParent(transform, false);
            newBlock.Display(item);
        }
	}
}
