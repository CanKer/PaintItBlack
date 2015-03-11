using UnityEngine;
using System.Collections;

public class AjustarScript : MonoBehaviour {//para implementar el control de xbox 

	// Use this for initialization
void OnGUI()//va en maincamera
	{
		if(GUI.Button(new Rect(10,340,100,30),"Pausa"))
		{
			ControlJuego.control.Pausa();
		}
		/*if(GUI.Button(new Rect(10,100,100,30),"Mas Vida")) //Para probar guardar y cargar..ok
		{
			ControlJuego.control.vida+=10;
		}
		if(GUI.Button(new Rect(10,140,100,30),"Menos Vida"))
		{
			ControlJuego.control.vida-=10;
		}
		if(GUI.Button(new Rect(10,180,100,30),"Mas Exp"))
		{
			ControlJuego.control.exp+=10;
		}
		if(GUI.Button(new Rect(10,220,100,30),"Menos Exp"))
		{
			ControlJuego.control.exp-=10;
		}*/
		if(GUI.Button(new Rect(10,260,100,30),"Guardar"))
		{
			ControlJuego.control.Guardar();
			Debug.Log ("Juego guardado exitosamente");	
		}
		if(GUI.Button(new Rect(10,300,100,30),"Cargar"))
		{
			ControlJuego.control.Cargar();
			Debug.Log ("Juego cargado exitosamente");
		}
	
			

		
		
	}
}