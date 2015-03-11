using UnityEngine;
using System.Collections;



public class TriggerCubo2 : MonoBehaviour {
	
	
	
	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().enabled = true;
	}
	
	// Update is called once per frame
	public bool flag=false;
	public float posY=0;
	void Update () {
		GameObject pared2= GameObject.Find ("Pared2");
		posY = pared2.transform.position.y;
		if (flag&&posY>-3.358) {		
			pared2.transform.Translate (transform.up * -2 * Time.deltaTime);			
		} 
		if(!flag&&posY<8.5){
			pared2.transform.Translate (transform.up * 2 * Time.deltaTime);
		}
	}
	
	public float fuerza=1f;
	
	void OnTriggerEnter(Collider objeto){
		if (objeto.name != "Cylinder2") {
			flag = true;
		}

	}
	
//	void OnTriggerStay(Collider objeto){
//		GameObject pared2= GameObject.Find("Pared2");
//		if (objeto.name != "Cylinder2") {
//			pared2.transform.Translate (transform.up * -2 * Time.deltaTime);
//		}
//	}
	
	void OnTriggerExit(Collider objeto){
		flag = false;
	}
}
