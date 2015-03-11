#pragma strict

function Start () {

}
function Update () {
	//Encontrara la sombra e ignorara cualquier otro objeto que pase por la luz
	var encontrarSombra: boolean = false; 
	var hit : RaycastHit;	
	encontrarSombra = Physics.SphereCast(transform.position, .6, transform.forward, hit, Mathf.Infinity, 1 << 8);	
	//Destruir la sombra si entra en contacto con la luz
	if(encontrarSombra){
//	 	Destroy(hit.transform.gameObject);
		print ("La sombra esta en la luz!");
	}
}
