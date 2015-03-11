using UnityEngine;
using System.Collections;



public class TriggerColab1 : MonoBehaviour {
	public bool flag=false;


	public bool getFlag(){
		return flag;
	}

	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().enabled = false;
	}


	
	// Update is called once per frame
	void Update () {		
		
	}

	
	void OnTriggerStay(Collider objeto){
		if (objeto.name != "Cylinder1") {
			flag = true;
		}
	}
	
	void OnTriggerExit(Collider objeto){
		flag = false;
	}
}
