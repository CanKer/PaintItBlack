using UnityEngine;
using System.Collections;

public class SaltoC2 : MonoBehaviour {
	private GameObject player2;
	public int nSaltos=0;

void Start () {
	player2 = GameObject.Find ("Sombra");	
}

void Update () {
	
		if(Input.GetKey("space")){
		nSaltos +=1;
		//Permite doble salto
		if(nSaltos ==1||nSaltos ==2)	{
			player2.GetComponent<Rigidbody>().AddForce(new Vector3 (0, 5, 0), ForceMode.VelocityChange);
		}
	}
}



void OnCollisionEnter()	{
	//No puede saltar mas de dos veces hasta que toca el piso
	nSaltos=0;
}
}
