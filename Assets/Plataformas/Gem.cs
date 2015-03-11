using UnityEngine;
using System.Collections;

public class Gem : MonoBehaviour {
	public static RespondeAmbientePhill inst;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider collider){
		if (collider.name == "Phill") {
			inst=GameObject.Find("Phill").GetComponent<RespondeAmbientePhill>();
			inst.Exp();
			Destroy(gameObject);
			
		}
	}
}
