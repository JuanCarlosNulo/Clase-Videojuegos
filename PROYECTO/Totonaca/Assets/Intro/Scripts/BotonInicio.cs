using UnityEngine;
using System.Collections;

public class BotonInicio : MonoBehaviour {
	
	void OnMouseOver(){
		if (Input.GetMouseButtonUp(0)){
			Application.LoadLevel("Nivel 1");
		}
	}
}
