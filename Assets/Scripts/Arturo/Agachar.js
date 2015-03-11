var Personaje:GameObject;
static var agachado = 0;
function Start () {

Personaje=GameObject.Find("Personaje");

}

function Update () {
	
	var flag = true;
	
	if(Input.GetKeyDown(KeyCode.JoystickButton12))	{
		if(agachado==0){
			Personaje.transform.localScale += new Vector3(5, 5, 5);
			Personaje.transform.position += new Vector3(0, 2.5, 0);
			agachado++;
		}else{
			Personaje.transform.localScale += new Vector3(-5, -5, -5);
			Personaje.transform.position += new Vector3(0, -2.5, 0);
			agachado--;		
		}
	
			
        
        
        
	}
	
	
	//	if(Input.GetKeyDown(KeyCode.JoystickButton12)){
	//	if(flag){
	//		Personaje.transform.localScale += new Vector3(2,2,2);
	//		flag=false;
	//	}else{
	//		Personaje.transform.localScale += new Vector3(5,5,5);
	//		flag=true;
	//	}
	//}

}