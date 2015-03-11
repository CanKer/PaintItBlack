using UnityEngine;
using System.Collections;

public class EnemigoP : MonoBehaviour {

	//posiciones Iniciales y Final del enemigo
	float posI;
	float posF;
	//Vector3  checkpointP;
	//patrulla del enemigo
	private bool dirRight = true;
	
	public float speedx = 2.0f;
	//public static RespondeAmbientePhill inst;

	public int distanciaAmover = 100;

	public int velocidad = 20;

	bool movDer = true;

	void Awake()	{
		posI = transform.position.x;
		posF = posI + distanciaAmover;	
	}
	
	// Use this for initialization
	void Start () {

		posI = transform.position.x;
		posF = posI + distanciaAmover;	
	
	}
	
	// Update is called once per frame
	void Update () {
	
	/*	if(movDer)	{
			Debug.Log(rigidbody.position += Vector3.right * velocidad * Time.deltaTime);
			rigidbody.position += Vector3.right * velocidad * Time.deltaTime;
		}

		if(rigidbody.position.x >= posF)	{
			movDer = false;
		}

		if(!movDer)	{
			rigidbody.position -= Vector3.right * velocidad * Time.deltaTime;
		}

		if(rigidbody.position.x <= posI)	{
			movDer = true;
		}*/


		if (dirRight)
			transform.Translate (Vector2.right * speedx * Time.deltaTime);
		else
			transform.Translate (-Vector2.right * speedx * Time.deltaTime);
		
		if(transform.position.x >= 70.0f) {
			dirRight = false;
		}
		
		if(transform.position.x <=  45) {
			dirRight = true;
		}
	}


	void OnTriggerEnter(Collider col)	{
	
		if(col.name == "Phillip")	{

			//Application.LoadLevel("Nivel1");
			Destroy(gameObject);


		}
	
	}
}
