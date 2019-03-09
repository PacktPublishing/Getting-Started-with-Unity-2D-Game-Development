using UnityEngine;
using System.Collections;

public class BunnyMovement : MonoBehaviour {
	public float speed=1;
	public void MoveUp(){
		transform.Translate(Vector2.up*speed*Time.deltaTime);
	}
	
	public void MoveDown(){
		transform.Translate(-Vector2.up*speed*Time.deltaTime); 
	}
}
