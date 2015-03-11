using UnityEngine;
using System.Collections;

public class RespondeAmbientePhill : MonoBehaviour {
	public static RespondeAmbientePhill res;

	public static bool muerto = false;
	public Vector3 puntoInicio;
	public float tempor;
	/// <summary>
	/// T/////////////	/// </summary>
	public static int vida,exp;
	public static bool dano;
	/// <summary>
	/// T/	/// </summary>

	public int tiempoRespawn=1;

	// Use this for initialization
	void Start () {
		puntoInicio = GameObject.Find ("PuntoInicio").transform.position;
		/// <summary>
		/// T/////////////	/// </summary>
		vida = 100;
	}
	
	// Update is called once per frame
	//Se da un timepo de espera una vez que esta muerto e personaje, reaparece en el punto de inicio
	public void Update () {
		//Si se cae en un pozo

		//if (muerto) {
		//	Reaparece();
		//}	

		if (transform.position.y < -10) {
			muerto=true;
		}

	}
	/// <summary>
	/// anadido por luis 	/// </summary>
	public void Vida(int dan){

		if (vida == 0) {
			muerto=true;
		}

			vida-=dan;
			dano=false;


	}
	public void Exp(){
		exp += 40;
		if (exp == 120) {
			vida+=10;;
		}
	}
	
/*	void Reaparece(){
		gameObject.renderer.enabled=false;
		((movimiento)gameObject.GetComponent<movimiento>()).enabled = false;
		((SaltoC)gameObject.GetComponent<SaltoC>()).enabled = false;
		tempor += Time.deltaTime;
		if(tempor > tiempoRespawn){
			transform.position=puntoInicio;
			gameObject.renderer.enabled=true;
			((movimiento)gameObject.GetComponent<movimiento>()).enabled = true;
			((SaltoC)gameObject.GetComponent<SaltoC>()).enabled = true;
			tempor = 0;
			vida=100;
			muerto=false;
		}
	} */


}
