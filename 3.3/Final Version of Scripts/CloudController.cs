using UnityEngine;
using System.Collections;

public class CloudController : MonoBehaviour {

	public void InForeground(){
		GetComponent<SpriteRenderer>().sortingLayerName="foreground";
	}

	public void InBackground(){
		GetComponent<SpriteRenderer>().sortingLayerName="background";
	}
}
