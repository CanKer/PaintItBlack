using UnityEngine;
using System.Collections;

public class RespondeAmbienteSombra	 : MonoBehaviour {
	
	public static bool muerto = false;
	public Vector3 puntoInicio;
	public float tempor;
	public int tiempoRespawn=1;
	
	// Use this for initialization
	void Start () {
		puntoInicio = GameObject.Find ("PuntoInicio").transform.position;
	}
	
	// Update is called once per frame
	//Se da un timepo de espera una vez que esta muerto e personaje, reaparece en el punto de inicio
	void Update () {
		//Si se cae en un pozo
		if (muerto) {
			Reaparece();
		}	
		if (transform.position.y < -10) {
			muerto=true;
		}
	}
	
	void Reaparece(){
		gameObject.GetComponent<Renderer>().enabled=false;
		((movimiento2)gameObject.GetComponent<movimiento2>()).enabled = false;
		((SaltoC2)gameObject.GetComponent<SaltoC2>()).enabled = false;
		tempor += Time.deltaTime;
		if(tempor > tiempoRespawn){
			transform.position=puntoInicio;
			gameObject.GetComponent<Renderer>().enabled=true;
			((movimiento2)gameObject.GetComponent<movimiento2>()).enabled = true;
			((SaltoC2)gameObject.GetComponent<SaltoC2>()).enabled = true;
			tempor = 0;
			muerto=false;
		}
	}
	
}
