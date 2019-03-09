//goofing about with variables
using UnityEngine;
using System.Collections;

public class OurFirstScript : MonoBehaviour {

	public int firstNumber=10;
	int secondNumber=5;
	public string theText="hey!";

	// Use this for initialization
	void Start () {
		Debug.Log(firstNumber+secondNumber);
	}
	
	// Update is called once per frame
	void Update () {
		if(firstNumber+secondNumber>15){
			Debug.Log(theText);
		}
	}
}
