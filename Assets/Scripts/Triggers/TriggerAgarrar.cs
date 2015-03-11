using UnityEngine;
using System.Collections;

public class TriggerAgarrar : MonoBehaviour {
	public GameObject cajaSombra;
	public GameObject sombra;
	public GameObject phill;
	public bool enAreaActivacion=false;
	public static bool activado=false;
	public bool cargando=false;


	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().enabled = false;
		cajaSombra = GameObject.Find ("SombraCaja");
		sombra = GameObject.Find ("Sombra");
		phill = GameObject.Find ("Phill");
		cajaSombra.GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame


//CONTROLES BASICOS
//	Cambiar entre personajes——S
//	Transformar sombra en caja y viceversa——E
//	Cargar objeto——X

	void Update () {
		if (Input.GetKeyDown(KeyCode.E)&&enAreaActivacion&&SwitchCamera.esPhill) {
			if(activado==false){
				sombra.GetComponent<Renderer>().enabled = false;
				cajaSombra.GetComponent<Renderer>().enabled = true;
				((movimiento2)sombra.GetComponent<movimiento2>()).enabled = false;
				((SaltoC2)sombra.GetComponent<SaltoC2>()).enabled = false;
			}
			if(activado==true){
				sombra.GetComponent<Renderer>().enabled = true;
				cajaSombra.GetComponent<Renderer>().enabled = false;
				((movimiento2)sombra.GetComponent<movimiento2>()).enabled = true;
				((SaltoC2)sombra.GetComponent<SaltoC2>()).enabled = true;
			}
			activado=!activado;
		}

		if (activado == true) {
			if (Input.GetKeyDown(KeyCode.X)){
				cargando=!cargando;
			}		
		}

		if (cargando) {
			Cargar();
		}

	}

	void Cargar(){	

		Vector3 posPhillCargaIzquierda= new Vector3(phill.transform.position.x-1,phill.transform.position.y,phill.transform.position.z);
		Vector3 posPhillCargaDerecha= new Vector3(phill.transform.position.x+1,phill.transform.position.y,phill.transform.position.z);	

		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			sombra.transform.position = posPhillCargaIzquierda;
		}
		if(Input.GetKeyDown(KeyCode.RightArrow)){
			sombra.transform.position = posPhillCargaDerecha;
		}
	}


	void OnTriggerEnter(Collider objeto){

		if (objeto.name == "Phill") {
			Debug.Log("Lasdf");
			enAreaActivacion=true;
		}
	}

	void OnTriggerExit(Collider objeto){
		if (objeto.name == "Phill") {
			enAreaActivacion = false;
		}
	}

}
