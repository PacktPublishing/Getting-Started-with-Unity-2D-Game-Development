using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
	public string sceneToLoad="StartScreen";

	public void LoadTheLevel(){
		SceneManager.LoadScene(sceneToLoad);
	}
}
