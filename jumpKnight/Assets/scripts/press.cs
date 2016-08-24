using UnityEngine;
using System.Collections;


public class press : MonoBehaviour{

	public Sprite[] pressedSprites;
	public bool blueIsPressed = false;
	private tagChecker tagCheck;

	// Use this for initialization
	void Start () {

		tagCheck = FindObjectOfType<tagChecker> ();
	
	}
	
	// Update is called once per frame
	void Update () {

	}

   void OnMouseDown(){

		if (gameObject.tag == "blueButton") {
			gameObject.GetComponent<SpriteRenderer> ().sprite = pressedSprites [0];
			if(tagCheck.currentTag == "blue"){
				blueIsPressed = true;
				Debug.Log(tagCheck.currentTag);
			}
			else{
				Debug.Log("tag is not blue!!!");
			}
		} else if (gameObject.tag == "yellowButton") {
			gameObject.GetComponent<SpriteRenderer> ().sprite = pressedSprites [1];	
		} else if (gameObject.tag == "redButton") {
			gameObject.GetComponent<SpriteRenderer> ().sprite = pressedSprites [2];	
			if(tagCheck.currentTag == "red"){
				Debug.Log(tagCheck.currentTag);
			}
			else{
				Debug.Log("tag is not red!!!!");
			}

		} else if (gameObject.tag == "greenButton") {
			gameObject.GetComponent<SpriteRenderer> ().sprite = pressedSprites [3];	
		}

	}

		
}
