﻿using UnityEngine;
using System.Collections;

public abstract class ComponentPoolBase : MonoBehaviour {
	[SerializeField] string _id;

    public bool copyOnEmpty = true;
    public int copyOnStart = 0;
    public int copyRate = 5;
    public bool activateOnGet = true;
    
    
	public string id {
		get { return _id; }
	}
	
	protected void Reset() {
		_id = name;
        copyOnEmpty = true;
        copyOnStart = 0;
        copyRate = 5;
        activateOnGet = true;
	}
}
