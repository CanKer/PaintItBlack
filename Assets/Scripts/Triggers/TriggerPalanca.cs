using UnityEngine;
using System.Collections;

public class TriggerPalanca : MonoBehaviour {

	// Use this for initialization

	void Start () {


	
	}

	// Update is called once per frame

	public bool flag=false;
	public float posY=0;

	void Update () {
		GameObject puerta= GameObject.Find ("Puerta");
		GameObject puerta1= GameObject.Find ("Puerta1");
		GameObject puerta2= GameObject.Find ("Puerta2");
		posY = puerta.transform.position.y;
		if (!flag&&posY>-5.5) {		
			puerta.transform.Translate (transform.up * -2 * Time.deltaTime);
			puerta1.transform.Translate (transform.up * -2 * Time.deltaTime);
			puerta2.transform.Translate (transform.up * -2 * Time.deltaTime);

		} 
		if(flag&&posY<5.5){
			puerta.transform.Translate (transform.up * 2 * Time.deltaTime);
			puerta1.transform.Translate (transform.up * 2 * Time.deltaTime);
			puerta2.transform.Translate (transform.up * 2 * Time.deltaTime);
		}
	
	}


	void OnTriggerEnter(Collider objeto){
		Debug.Log ("Aprieta e para activar o desactivar la palanca!");
	}

	void OnTriggerStay(Collider objeto){

		 GameObject palancaDes= GameObject.Find("PalancaDesactivada");
		 GameObject palancaAct= GameObject.Find("PalancaActivada");

		if (Input.GetKeyUp("e")) {
			if(palancaDes.GetComponent<Renderer>().enabled){
				palancaDes.GetComponent<Renderer>().enabled=false;
				palancaAct.GetComponent<Renderer>().enabled=true;
				flag=false;
			}
			else if(palancaAct.GetComponent<Renderer>().enabled){
				palancaDes.GetComponent<Renderer>().enabled=true;
				palancaAct.GetComponent<Renderer>().enabled=false;
				flag=true;
			}					
		}
	}
}
