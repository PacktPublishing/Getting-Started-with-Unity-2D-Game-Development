using UnityEngine;
using System.Collections;

public class GoToURL : MonoBehaviour {

	public string theURL="https://www.packtpub.com/";

	public void OpenTheLink(){
		Application.OpenURL(theURL);
	}
}
