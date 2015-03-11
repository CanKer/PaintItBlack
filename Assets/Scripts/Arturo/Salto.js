var Personaje:GameObject;
static var nSaltos=0;

function Start () {

	Personaje=GameObject.Find("Phill");
// 	Rigidbody rigidbody = Personaje.AddComponent<Rigidbody>();  C#
	Personaje.AddComponent(Rigidbody);
	Personaje.GetComponent.<Rigidbody>().useGravity=true;

}

function Update () {
	//Debug.Log();
	if((Input.GetKeyDown(KeyCode.JoystickButton16))||(Input.GetKeyDown(KeyCode.Space)))	{
		nSaltos +=1;
			if(nSaltos == 1)	{
				Personaje.GetComponent.<Rigidbody>().AddForce(new Vector3 (0, 15, 0), ForceMode.VelocityChange);
			}
		}

}


