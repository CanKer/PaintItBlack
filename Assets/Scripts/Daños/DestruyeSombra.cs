using UnityEngine;
using System.Collections;

public class DestruyeSombra : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider objeto){
		if(objeto.name=="Sombra"){
			if(DisbleLight.prendido==true){
				RespondeAmbienteSombra.muerto=true;
			}
		}
	}
}
