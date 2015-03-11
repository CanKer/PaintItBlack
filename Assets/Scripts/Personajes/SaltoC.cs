//REcordar que JAVASCRIPT si se puede comunciar con C# pero no a la inversa, es por el orden de compliacion

using UnityEngine;
using System.Collections;

public class SaltoC : MonoBehaviour {
	private GameObject player1;
	public int nSaltos=0;
	
	void Start () {
		player1 = GameObject.Find ("Phill");	
	}
	
	void Update () {
		
		if(Input.GetKey("space"))	{
			nSaltos +=1;
			//Permite doble salto
			if(nSaltos ==1||nSaltos ==2)	{
				player1.GetComponent<Rigidbody>().AddForce(new Vector3 (0, 5, 0), ForceMode.VelocityChange);
			}
		}
	}
	
	
	
	void OnCollisionEnter()	{
		//No puede saltar mas de dos veces hasta que toca el piso
		nSaltos=0;
	}
}
