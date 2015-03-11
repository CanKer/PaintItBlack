using UnityEngine;
using System.Collections;



public class TriggerCubo1 : MonoBehaviour {

	//Timer va dentro de update
	//		tiempo -= Time.deltaTime;
	//		Debug.Log (timeLeft);
	//		GameObject pared1= GameObject.Find ("Pared1");
	//		if(tiempo > 0 ){
	//			pared1.transform.Translate (transform.up * -2 * Time.deltaTime);
	//		}



	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().enabled = false;
	}
	
	public bool flag=false;

	// Update is called once per frame
	void Update () {
		if (flag) {
			DisbleLight.prendido=false;
		}	
	}


//	void OnTriggerEnter(Collider objeto){
//	}

	void OnTriggerStay(Collider objeto){
		if (objeto.name != "Cylinder1") {
			flag = true;
		}
	}

	void OnTriggerExit(Collider objeto){
		flag = false;
		DisbleLight.prendido=true;
	}
}
