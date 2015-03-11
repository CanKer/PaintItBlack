using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	//public float Horizontal;

	public Vector3 puntoInicio;

	public float Speed = 5.0f;
	public static bool muerto = false;

	public float tempor;
	public int tiempoRespawn;

	// Use this for initialization
	void Start () {
		puntoInicio = GameObject.Find ("PuntoInicio").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		//Horizontal = horizontal;
		move (horizontal, vertical);
		//Se da un timepo de espera una vez que esta muerto e personaje, reaparece en el punto de inicio
		if (muerto) {
			Debug.Log("adsaadsfdsf");
			gameObject.GetComponent<Renderer>().enabled=false;
			tempor += Time.deltaTime;
			if(tempor > tiempoRespawn){
				transform.position=puntoInicio;
				tempor = 0;
			}
		}
	}

	void move(float horizontal, float vertical){
		Vector3 position = transform.position;
		position.x += horizontal * Speed * Time.deltaTime; //(deltaTime lock hace independiente del frame del juego)
		position.y += vertical * Speed * Time.deltaTime;
		transform.position = position;
	}

}
