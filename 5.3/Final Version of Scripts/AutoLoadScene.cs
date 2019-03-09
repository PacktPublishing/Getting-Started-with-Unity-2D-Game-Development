using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AutoLoadScene : MonoBehaviour {

	public string sceneToLoad="StartScreen";

	public float timeToLoad=0;

	// Use this for initialization
	void Start () {
		Invoke("LoadTheScene", timeToLoad);
	}
	
	void LoadTheScene(){
		SceneManager.LoadScene(sceneToLoad);
	}
}
