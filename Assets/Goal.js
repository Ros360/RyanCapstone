#pragma strict

var level: int;

function OnTriggerEnter(other: Collider){
	if(other.tag == "Ball"){
		Application.LoadLevel(level);
	}
}