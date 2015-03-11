using UnityEngine;
using System.Collections;

public class MenuInicio : MonoBehaviour {

	public int inicio = 1;
	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()	{
		if (inicio == 1) {
			Cursor.visible = true;
			GUI.Box(new Rect(((Screen.width /2)-125), ((Screen.height /2)-180), 250, 360), "Bienvenido");
			if(GUI.Button(new Rect(((Screen.width / 2)-100), ((Screen.height /2)-50), 200, 60), "Iniciar"))	{
				Application.LoadLevel("Nivel1");
			}
			if(GUI.Button(new Rect(((Screen.width / 2)-100), ((Screen.height /2)+30), 200, 60), "Salir"))	{
				Application.Quit();
				}
		}
	}
}
