using UnityEngine;
using System.Collections;

public class ResponderSwitchesColab : MonoBehaviour {

	public TriggerColab1 trig1;
	public TriggerColab2 trig2;
	public GameObject pared;

	// Use this for initialization
	void Start () {

	}	
	// Update is called once per frame
	void Update () {
		if(trig1.getFlag()==true&&trig2.getFlag()==true){
			pared= GameObject.Find ("Pared");
			pared.transform.Translate (transform.up * -2 * Time.deltaTime);			
		}
	}
}
