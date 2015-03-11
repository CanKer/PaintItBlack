using UnityEngine;
using System.Collections;

public class CircularP : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0f,0f,0f); // move forward
		transform.Rotate(0f,0f,Time.deltaTime*70f); // turn a little
	}
}
