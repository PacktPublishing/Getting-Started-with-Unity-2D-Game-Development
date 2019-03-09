using UnityEngine;
using System.Collections;

public class KeepAround : MonoBehaviour {

	public GameObject thingToKeep;
	
	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad(thingToKeep);
	}
}
