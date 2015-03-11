using UnityEngine;
using System.Collections;

public class CambiarScene : MonoBehaviour {
	
	// Use this for initialization
	void Awake () {//awake pasa antes que start
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	public int cargarScene;
	void OnGUI(){
		GUI.Label (new Rect (Screen.width / 2 - 50, Screen.height -80, 100, 30
		), "Ecena actual:" + (Application.loadedLevel + 1
		                     ));
		if (GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height - 50, 100, 40),
		               "Cargar Ecena " + (cargarScene + 1))) {
			Application.LoadLevel(cargarScene);
		}
	}

}
