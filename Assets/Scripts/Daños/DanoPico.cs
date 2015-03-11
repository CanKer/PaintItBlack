using UnityEngine;
using System.Collections;

public class DanoPico : MonoBehaviour {
	/// <summary>
	/// T/////////////	/// </summary>
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
			/// <summary>
			/// T/////////////	/// </summary>
			inst.Vida(20);

		}

	}
}
