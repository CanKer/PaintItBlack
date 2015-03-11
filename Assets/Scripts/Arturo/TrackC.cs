using UnityEngine;
using System.Collections;

public class TrackC : MonoBehaviour {

	int camara = 0;
//	private GameObject player1;
	public static int DistanceAway =10;
	public static int lejania = 0;
	// Use this for initialization
	void Start () {
		//player1 =  GameObject.Find("Phill");
			
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("escape"))	{

			if(camara == 0)	{
				DistanceAway = 10;
				camara = 1;
				Debug.Log(camara);
			} else if (camara == 1) {

				DistanceAway = 10;
				camara = 0;
				Debug.Log(camara);
			}
		}


		//if(camara == 1)	{
		//	DistanceAway = 20;
			Vector3 PlayerPOS = GameObject.Find("Phill").transform.transform.position;
			GameObject.Find ("MainCamera").transform.position = new Vector3 (PlayerPOS.x, PlayerPOS.y, PlayerPOS.z - DistanceAway);
		
		//} //if (camara == 0)	{
	//		DistanceAway = 10;
	//		Vector3 PlayerPOS = GameObject.Find ("Phill").transform.transform.position;
	//		GameObject.Find ("MainCamera").transform.position = new Vector3 (PlayerPOS.x, PlayerPOS.y, PlayerPOS.z - DistanceAway);

	//	}

	}
}
