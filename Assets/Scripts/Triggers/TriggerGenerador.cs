using UnityEngine;
using System.Collections;

public class TriggerGenerador : MonoBehaviour {
	public GameObject generadorLuz;
	public float anguloRotacion;
	public bool enAreaInteraccionConGeneradorLuz=false;



	// Use this for initialization
	void Start () {
		generadorLuz = GameObject.Find ("GeneradorLuz");
	}
	
	// Update is called once per frame
	void Update () {
		if(enAreaInteraccionConGeneradorLuz==true){
			if(Input.GetKey(KeyCode.K)){
				if(anguloRotacion<90){
					anguloRotacion+=3;
					generadorLuz.transform.eulerAngles = new Vector3(anguloRotacion,generadorLuz.transform.eulerAngles.y,generadorLuz.transform.eulerAngles.z);
				}
			}
			if(Input.GetKey(KeyCode.L)){
				if(anguloRotacion>-90){
					anguloRotacion-=3;
					generadorLuz.transform.eulerAngles = new Vector3(anguloRotacion,generadorLuz.transform.eulerAngles.y,generadorLuz.transform.eulerAngles.z);
				}
			}
		}
	}

	void OnTriggerEnter(Collider objeto){
		if (objeto.name == "Phill") {
			enAreaInteraccionConGeneradorLuz=true;
		}
	}

	void OnTriggerExit(Collider objeto){
		if (objeto.name == "Phill") {
			enAreaInteraccionConGeneradorLuz=false;
		}
	}
}

