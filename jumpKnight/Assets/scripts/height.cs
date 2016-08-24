using UnityEngine;
using System.Collections;

public class height : MonoBehaviour {

	public GameObject obj;

	// Use this for initialization
	void Start () {

		Debug.Log ((obj.GetComponent<Renderer> ().bounds.size.x).ToString());
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
