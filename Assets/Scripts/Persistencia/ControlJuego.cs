using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class ControlJuego : MonoBehaviour {
	public static ControlJuego control;

	public float vida;
	public float exp;
	public float PosPhillx,PosPhilly,PosPhillz; //lamentablemente vector3 nos es serializable
	public float PosSomx,PosSomy,PosSomz;

	// Use this for initialization
	void Start () {

		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		} else if (control != this) {
			Destroy(gameObject);
		}
	}
	void Update(){
		vida = RespondeAmbientePhill.vida;
		exp = RespondeAmbientePhill.exp;
	}

	
	// Update is called once per frame
	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 100, 30), "Vida: " + vida);
		GUI.Label (new Rect (10, 40, 100, 30), "Exp: " + exp);
	}
	public void Guardar(){//exepcion web
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream archivo = File.Create (Application.persistentDataPath + "infodeJugador.dat");
		PlayerData data = new PlayerData ();
		data.vida = vida;
		data.exp = exp;
		PosPhillx = GameObject.Find ("Phill").transform.position.x;
		PosPhilly = GameObject.Find ("Phill").transform.position.y;
		PosPhillz = GameObject.Find ("Phill").transform.position.z;
		PosSomx = GameObject.Find ("Sombra").transform.position.x;
		PosSomy = GameObject.Find ("Sombra").transform.position.y;
		PosSomz = GameObject.Find ("Sombra").transform.position.z;
		data.PosPhillx = PosPhillx;
		data.PosPhilly = PosPhilly;
		data.PosPhillz = PosPhillz;
		data.PosSomx = PosSomx;
		data.PosSomy = PosSomy;
		data.PosSomz = PosSomz;

		bf.Serialize (archivo, data);
		archivo.Close();
	}
	public void Pausa () {
		bool pause = false;
		if (Time.timeScale == 0) {
			Time.timeScale = 1;
		} else {
			Time.timeScale = 0;
		}
		/*if (Input.GetKeyDown (KeyCode.P)) {   este codigo puede remplazar al boton gui, tiene que ir en update
			if (!pause) {
				Time.timeScale = 0;
				pause = true;
			} else {
				pause = false;
				Time.timeScale = 1;
			}
		} */
	}
	public void Cargar()
	{
		if(File.Exists(Application.persistentDataPath +"infodeJugador.dat")){
			BinaryFormatter bf= new BinaryFormatter();
			FileStream archivo= File.Open(Application.persistentDataPath +"infodeJugador.dat", 
			                              FileMode.Open);
			PlayerData data= (PlayerData)bf.Deserialize(archivo);
			archivo.Close();

			vida=data.vida;
			exp=data.exp;
			PosPhillx=data.PosPhillx;
			PosPhilly=data.PosPhilly;
			PosPhillz=data.PosPhillz;
			PosSomx=data.PosSomx;
			PosSomy=data.PosSomy;
			PosSomz=data.PosSomz;

			GameObject.Find ("Phill").transform.position=new Vector3 (ControlJuego.control.PosPhillx,
			                                                          ControlJuego.control.PosPhilly,
			                                                          ControlJuego.control.PosPhillz);
			GameObject.Find ("Sombra").transform.position=new Vector3 (ControlJuego.control.PosSomx,
			                                                          ControlJuego.control.PosSomy,
			                                                          ControlJuego.control.PosSomz);
		
		}
	
	}

}

[Serializable]//para poder escribir clase en archivo
class PlayerData{
	public float vida;
	public float exp;
	public float PosPhillx,PosPhilly,PosPhillz;
	public float PosSomx,PosSomy,PosSomz;

}