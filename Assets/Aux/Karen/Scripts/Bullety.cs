using UnityEngine;
using System.Collections;

public class Bullety : MonoBehaviour {

	void OnBecameInvisible(){
		Destroy (gameObject);
	}

	public float Speed = 13.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPosition = transform.position;
		currentPosition.y += Speed * Time.deltaTime;
		transform.position = currentPosition;
	
	}
}
