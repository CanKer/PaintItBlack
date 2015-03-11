using UnityEngine;
using System.Collections;

public class RayCastGenerador : MonoBehaviour {
	public Vector3 puntaGenerador;
	public Vector3 nuevoAnguloReflexion;
	LineRenderer rayoLuz;
	
	// Use this for initialization
	void Start () {
		rayoLuz = GetComponent<LineRenderer> ();
	}
	
	// Update is called once per frame
	void Update()
	{	
		puntaGenerador = new Vector3 (transform.position.x, transform.position.y+1, transform.position.z);
		var up = transform.TransformDirection(new Vector3(0,0,1));
		RaycastHit objetoReflejo;
//		Debug.DrawRay(puntaGenerador, up * 20, Color.red,0,true);		
		if (Physics.Raycast(puntaGenerador, up, out objetoReflejo, 20))
		{			
			//FALTA AGREGAR BOTON PARA HABILITAR O DESHABILITAR LA FUNCION DEL GENERADOS DE HAZ
			rayoLuz.enabled = true;         
			//Indices del Line renderer comienzan en 1
			rayoLuz.SetPosition(0, transform.position); 
			rayoLuz.SetPosition(1, objetoReflejo.point);   

			if(objetoReflejo.collider.tag=="Espejo"){
				nuevoAnguloReflexion = new Vector3 (transform.position.x, transform.position.y, transform.position.z-18);
				Vector3 reflejo = Vector3.Reflect (objetoReflejo.point + nuevoAnguloReflexion, -objetoReflejo.normal);
				rayoLuz.SetPosition(2,reflejo);
			}

			if(objetoReflejo.collider.tag=="Enemigo"){
				Debug.Log("Enemigo!");
				Destroy(objetoReflejo.transform.gameObject);
			}

		}
	}
	
}