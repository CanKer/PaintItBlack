using UnityEngine;
using System.Collections;

public class SeguirSombra : MonoBehaviour {
	public Vector3 posicionSombra;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		posicionSombra=GameObject.Find("Sombra").transform.position;
		transform.position=posicionSombra;
	}
}
