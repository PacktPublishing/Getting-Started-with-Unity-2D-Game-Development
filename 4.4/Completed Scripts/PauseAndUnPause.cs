using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseAndUnPause : MonoBehaviour {

	public Button pauseButton;

	public bool isPaused=false;

	public GameObject pausePanel;
	CanvasGroup pausePanelCG;

	// happens before start
	void Awake () {
		pausePanelCG=pausePanel.GetComponent<CanvasGroup>();
	}
	
	public void PauseTheGame(){
		if(isPaused==false && pausePanelCG!=null){
			Debug.Log("pause");
			Time.timeScale=0;
			isPaused=true;

			pauseButton.interactable=false;
			pausePanelCG.alpha=1;
			pausePanelCG.interactable=true;
			pausePanelCG.blocksRaycasts=true;
		}
	}

	public void ResumeTheGame(){
		if(isPaused==true && pausePanelCG!=null){
			Debug.Log("unpause");
			Time.timeScale=1;
			isPaused=false;

			pauseButton.interactable=true;
			pausePanelCG.alpha=0;
			pausePanelCG.interactable=false;
			pausePanelCG.blocksRaycasts=false;
		}
	}
}
