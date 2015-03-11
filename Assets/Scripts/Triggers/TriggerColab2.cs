using UnityEngine;
using System.Collections;



public class TriggerColab2 : MonoBehaviour {
	private bool flag=false;

	public  bool getFlag(){
		return flag;
	}
	
	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame


	void Update () {
	
	}

	
	void OnTriggerEnter(Collider objeto){
		if (objeto.name != "Cylinder2") {
			flag = true;
		}
		
	}
	
	void OnTriggerExit(Collider objeto){
		flag = false;
	}
}
