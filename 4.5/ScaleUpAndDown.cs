using UnityEngine;
using System.Collections;


public class ScaleUpAndDown : MonoBehaviour {

	public void ScaleUp(){
		GetComponent<RectTransform>().localScale=new Vector2(1.1f, 1.1f);
	}

	public void ScaleDown(){
		GetComponent<RectTransform>().localScale=new Vector2(1, 1);
	}
}
