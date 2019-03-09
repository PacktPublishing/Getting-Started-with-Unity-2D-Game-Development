using UnityEngine;
using System.Collections;

public class BunnyController : MonoBehaviour {
	bool moveUp=false; //should the bunny move up?
	//public float speed=1; //how fast the bunny moves

    public Sprite standardSprite;
    public Sprite jumpingSprite; 

    public GameObject smokePuff;
    SpriteRenderer theFlameSRL;
	
    GameObject theFlameR;
    SpriteRenderer theFlameSRR;

    GameObject theCactus;
    SpriteRenderer theCactusSR;


	// Use this for initialization
	void Start () {
		//the Sprite Renderer Component of FlameL
		theFlameSRL=GetComponentsInChildren<SpriteRenderer>()[2];

		//FlameR and its Sprite Renderer Component
		theFlameR=GameObject.Find("FlameR");
		theFlameSRR=theFlameR.GetComponent<SpriteRenderer>();

		//the Cactus and its Sprite Renderer Component
		theCactus=GameObject.FindGameObjectWithTag("flipper");
		theCactusSR=theCactus.GetComponent<SpriteRenderer>();
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
			//transform.Translate(Vector2.up*speed*Time.deltaTime);
			GetComponent<BunnyMovement>().MoveUp();
			FindObjectOfType<CloudController>().InForeground();
		}else{
			//transform.Translate(-Vector2.up*speed*Time.deltaTime); 
			GetComponent<BunnyMovement>().MoveDown();
			FindObjectOfType<CloudController>().InBackground();
		}

		//change the bunny's image with position
		if(transform.position.y>0.5){
			GetComponent<SpriteRenderer>().sprite=jumpingSprite;
			GetComponent<BunnyMovement>().speed=1.5f;
		}else{
			GetComponent<SpriteRenderer>().sprite=standardSprite;
			GetComponent<BunnyMovement>().speed=1;
		}

		//change the smoke puff's transparency based on bunny's position
		if(transform.position.y<.05){
			smokePuff.GetComponent<SpriteRenderer>().color=new Color (255,255,255,1);
		}else{
			smokePuff.GetComponent<SpriteRenderer>().color=new Color (255,255,255,0);
		}

		//change the transparency of the flames based on bunny's position
		//change the flip of the cactus based on bunny's position
		if(transform.position.y>0.5 && moveUp==true){
			theFlameSRL.color=new Color (255,255,255,1);
			theFlameSRR.color=new Color (255,255,255,1);
			theCactusSR.flipX=true;

		}else{
			theFlameSRL.color=new Color (255,255,255,0);
			theFlameSRR.color=new Color (255,255,255,0);
			theCactusSR.flipX=false;
		}


	}
}
