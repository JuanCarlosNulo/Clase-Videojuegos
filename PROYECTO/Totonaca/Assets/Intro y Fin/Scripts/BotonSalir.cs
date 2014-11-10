using UnityEngine;
using System.Collections;

public class BotonSalir : MonoBehaviour {

	void OnMouseOver(){
		if (Input.GetMouseButtonUp(0)){
			Application.Quit();
		}
	}
}
