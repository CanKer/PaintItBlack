using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {
	public float Speed = 5.0f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");		
		move (horizontal, vertical);
	}
	
	
	
	void move (float horizontal, float vertical)	{
		Vector3 position = transform.position;
		position.x += horizontal * Speed * Time.deltaTime;
		position.y += vertical * Speed * Time.deltaTime; 
		transform.position = position;
	}

}

