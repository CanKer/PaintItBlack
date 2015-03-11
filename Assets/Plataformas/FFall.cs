

using UnityEngine;
using System.Collections;



public class FFall : MonoBehaviour {

	void Start(){

	}


	bool falling=false;
	float fallingSpeed=0;

	
	// Use this for initialization

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == ("Phill")) {

			falling=true;
			Destroy (gameObject, 7);
		}
		}

	
	// Update is called once per frame
	void Update () {
		if (falling) {
			fallingSpeed+= Time.deltaTime/10;
			transform.position = new Vector3 (transform.position.x,  
				                              transform.position.y - fallingSpeed,
				                              transform.position.z
				                                             );
				
				
				
			}
	}}


