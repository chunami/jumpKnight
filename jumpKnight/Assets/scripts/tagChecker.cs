using UnityEngine;
using System.Collections;

public class tagChecker : MonoBehaviour {

	public string currentTag;

	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log(currentTag);

	}

	void OnTriggerEnter2D(Collider2D other){
	
		string someTag = other.tag;	

		switch (someTag) {
		case "blue":
			currentTag = "blue";
			//Debug.Log(currentTag);
			break;
		
		case "red":
			currentTag = "red";
			//Debug.Log("red");
			break;
		
		case "yellow":
			//Debug.Log("yellow");
			break;
		
		case "green":
			//Debug.Log("green");
			break;

		default:
			currentTag = currentTag;
			break;


		}

	}
	



}
