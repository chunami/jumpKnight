using UnityEngine;
using System.Collections;

public class randomColor : MonoBehaviour {

	private GameObject randomHeader, anotherHeader, someObj;
	public GameObject[] headers;
	private int index, index2;
	private GameObject creator;

	void Start () {
		//instantiates a random header at start
		index2 = Random.Range (0, headers.Length);
		anotherHeader = headers [index2];
		creator = Instantiate (anotherHeader, anotherHeader.transform.position, Quaternion.identity) as GameObject;
		creator.transform.parent = gameObject.transform;

	
	}

	void Update () {

	
	}
	

}
