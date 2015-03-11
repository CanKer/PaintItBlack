using UnityEngine;
using System.Collections;

public class PlatUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}		
		
		bool falling=false;
		float fallingSpeed=0;
		
		
		// Use this for initialization
		
		void OnTriggerEnter(Collider collider){
			if (collider.gameObject.name == "Phill") {
				
				falling=true;
				Destroy (gameObject, 100);
			}
		}
		
		
		// Update is called once per frame
		void Update () {
			if (falling) {
				fallingSpeed+= Time.deltaTime/10;
				transform.position = new Vector3 (transform.position.x ,  
			                                      transform.position.y + 0.1f,
				                                  transform.position.z
				                                  );
				
				
				
			}
		}}
	
	

