using UnityEngine;
using System.Collections;

public class Slope : MonoBehaviour  {
	
	private bool dirRight = true;
	private bool dirUp = true;
	public float speedx = 2.0f;
	public float speedy = 4.0f;
	
	void Update () {
		if (dirRight)
			transform.Translate (Vector2.right * speedx * Time.deltaTime);
		else
			transform.Translate (-Vector2.right * speedx * Time.deltaTime);
		
		if(transform.position.x >= 4.0f) {
			dirRight = false;
		}
		
		if(transform.position.x <= -4) {
			dirRight = true;
		}
		if (dirUp)
			transform.Translate (Vector2.up * speedy * Time.deltaTime);
		else
			transform.Translate (-Vector2.up * speedy * Time.deltaTime);
		
		if(transform.position.y >= 4.0f) {
			dirUp = false;
		}
		
		if(transform.position.y <= -4) {
			dirUp = true;
		}
	}
}
