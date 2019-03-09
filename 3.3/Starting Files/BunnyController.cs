using UnityEngine;
using System.Collections;

public class BunnyController : MonoBehaviour {
	bool moveUp=false; //should the bunny move up?
	public float speed=1; //how fast the bunny moves

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//check position of the bunny for movement
		if(transform.position.y<=0){
			moveUp=true;

		}else if(transform.position.y>=1){
			moveUp=false;

		}

		//translate the bunny up or down
		if(moveUp==true){
			transform.Translate(Vector2.up*speed*Time.deltaTime);
			
		}else{
			transform.Translate(-Vector2.up*speed*Time.deltaTime); 
		}
	}
}