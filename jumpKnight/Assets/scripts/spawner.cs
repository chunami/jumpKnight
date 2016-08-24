using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

	private float defX = 0f;
	private float defY = 7.0086f;
	int index;
	public GameObject[] randomObjs;

	private GameObject test;
	// Use this for initialization
	void Start () {
		InvokeRepeating("timedSpawn", 0, 0.5f);
	
	}
	
	// Update is called once per frame
	void Update () {

//		defY += 2.558558f;
//		index = Random.Range (0, randomObjs.Length);
//		test = randomObjs [index];
//		Instantiate (test, new Vector3 (defX,defY , 0), Quaternion.identity);
	
	}

	void timedSpawn(){
		defY += 2.558558f;
		index = Random.Range (0, randomObjs.Length);
		test = randomObjs [index];
		Instantiate (test, new Vector3 (defX,defY , 0), Quaternion.identity);

	}
}
