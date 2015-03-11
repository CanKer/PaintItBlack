using UnityEngine;
using System.Collections;

public class DisbleLight : MonoBehaviour {
	public Light luz;
	public static bool prendido=true;

	// Use this for initialization
	void Start () {
		 luz= gameObject.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		if (prendido) {
			luz.GetComponent<Light>().enabled = true;
		}
		if (!prendido) {
			luz.GetComponent<Light>().enabled = false;
		}
	}
}
