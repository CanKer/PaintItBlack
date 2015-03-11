using UnityEngine;
using System.Collections;

public class SwitchCamera : MonoBehaviour {
	private GameObject player1;
	private GameObject player2;

	private Vector3 PlayerPOS1;
	private Vector3 PlayerPOS2;
	//Distancia de la camara al jugador
	private int DistanceAway = 10;

	public static bool esPhill=true;

	// Use this for initialization
	void Start () {
		player1 = GameObject.Find ("Phill");
		player2 = GameObject.Find ("Sombra");
		Debug.Log ("Aprieta s para alternar entre los personajes!");		
	}
	
	// Update is called once per frame
	public bool flag=true;
	void Update () {

		
		//Encontrar la posicion del juador con cada update
		PlayerPOS1 = player1.transform.transform.position;
		PlayerPOS2 = player2.transform.transform.position;
		if(Input.GetKeyUp("s")){
			flag=!flag;
		}
		//La posicion de la camara ahora es relativa a la del jugador
		//Switchear entre jugadores
		if (TriggerAgarrar.activado == false) {
			if (flag) {
				siguePhill ();
				esPhill=true;
			} else {
				sigueSombra ();
				esPhill=false;
			}
		}else{
			siguePhill ();
			esPhill=true;
		}
	}

	public void siguePhill(){
		((movimiento)player1.GetComponent<movimiento>()).enabled = true;
		((SaltoC)player1.GetComponent<SaltoC>()).enabled = true;
		((movimiento2)player2.GetComponent<movimiento2>()).enabled = false;
		((SaltoC2)player2.GetComponent<SaltoC2>()).enabled = false;
		GameObject.Find ("MainCamera").transform.position = new Vector3 (PlayerPOS1.x, PlayerPOS1.y, PlayerPOS1.z - DistanceAway);
	}

	public void sigueSombra(){
		((movimiento)player1.GetComponent<movimiento>()).enabled = false;
		((SaltoC)player1.GetComponent<SaltoC>()).enabled = false;
		((movimiento2)player2.GetComponent<movimiento2>()).enabled = true;
		((SaltoC2)player2.GetComponent<SaltoC2>()).enabled = true;
		GameObject.Find ("MainCamera").transform.position = new Vector3 (PlayerPOS2.x, PlayerPOS2.y, PlayerPOS2.z - DistanceAway);
	}

}
