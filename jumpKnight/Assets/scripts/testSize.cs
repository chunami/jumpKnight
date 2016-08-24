using UnityEngine;
using System.Collections;

public class testSize : MonoBehaviour {

	public float speed;
	public bool begin = false;




	// Use this for initialization
	void Start () {

	
	
	}
	
	// Update is called once per frame
	void Update () {
		if (begin == true) {
			Camera.main.transform.position += Vector3.up * speed * Time.deltaTime;
		}

	
	}

	void OnMouseDown(){

		begin = true;

	}
}
