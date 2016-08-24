using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class refresh : Button {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame	
	void Update () {

		if (IsPressed ()) {
			Application.LoadLevel(Application.loadedLevel);
		}
	
	}
}
